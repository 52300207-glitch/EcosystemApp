using DocumentFormat.OpenXml.Spreadsheet;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System.ComponentModel;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace EcosystemApp.Utils
{
    public class GoogleSheetSyncHelper
    {
        // The permissions your app requires
        private string[] Scopes = { SheetsService.Scope.Spreadsheets };
        private string ApplicationName = "Ecosystem";
        private string SpreadSheetID;
        private string SheetName;
        private SheetsService Service;
        private string CredentialPath = Path.Combine(Application.StartupPath, "credentials.json");
        // Dictionary tracking RowIndex (trên sheet) → dòng đọc được
        private Dictionary<int, string> RowTracking = new Dictionary<int, string>();

        public static string GetEmailCredential()
        {
            string exeDir = Application.StartupPath;
            string credentialPath = Path.Combine(exeDir, "credentials.json");

            string jsonContent = File.ReadAllText(credentialPath);

            using JsonDocument doc = JsonDocument.Parse(jsonContent);
            JsonElement root = doc.RootElement;

            string clientEmail = root.GetProperty("client_email").GetString();
            return clientEmail;
        }
        public GoogleSheetSyncHelper(string googleSheetLink, string sheetName)
        {
            SpreadSheetID = ExtractSheetId(googleSheetLink?.Trim());
            SheetName = sheetName?.Trim();
            if (string.IsNullOrWhiteSpace(SpreadSheetID))
                throw new ArgumentException("Url không phù hợp!", nameof(googleSheetLink));
            if (string.IsNullOrWhiteSpace(SheetName))
                throw new ArgumentException("Tên Sheet không được để trống", nameof(SheetName));

            if (string.IsNullOrWhiteSpace(CredentialPath))
                throw new ArgumentException("Credential path must not be null or empty.", nameof(CredentialPath));

            GoogleCredential credential;
            using (var stream = new FileStream(CredentialPath, FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
            }

            if (credential == null)
                throw new Exception("Thất bại trong việc khởi tạo credential");

            Service = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            //coi thử spreadsheet và sheetname có tồn tại không 
            try
            {
                // 📥 Lấy thông tin Spreadsheet
                Spreadsheet spreadsheet = Service.Spreadsheets.Get(SpreadSheetID).Execute();

                if (spreadsheet == null)
                    throw new Exception("Không thể truy cập vào Google Spreadsheet!");

                // 🧾 Lấy danh sách sheet trong Spreadsheet
                IList<Google.Apis.Sheets.v4.Data.Sheet> sheets = spreadsheet.Sheets;

                // Kiểm tra tên sheet có tồn tại không
                bool sheetExists = sheets.Any(s => s.Properties.Title.Equals(SheetName, StringComparison.OrdinalIgnoreCase));

                if (!sheetExists)
                {
                    string allSheets = string.Join(", ", sheets.Select(s => s.Properties.Title));
                    throw new Exception($"Tên sheet '{SheetName}' không tồn tại!");
                }

                Console.WriteLine("✅ Spreadsheet ID và Sheet Name hợp lệ!");
            }
            catch (Google.GoogleApiException ex)
            {
                // Nếu ID không hợp lệ hoặc không có quyền truy cập
                if (ex.HttpStatusCode == System.Net.HttpStatusCode.NotFound)
                    throw new Exception("❌ Spreadsheet ID không tồn tại hoặc bạn không có quyền truy cập.");
                else
                    throw;
            }
        }


        private string ExtractSheetId(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return null;

            // Pattern to find the part between "/d/" and the next "/"
            string pattern = @"\/d\/([a-zA-Z0-9-_]+)";
            Match match = Regex.Match(url, pattern);

            if (match.Success)
                return match.Groups[1].Value;

            return null;
        }


        public List<string> GetOrderLines()
        {
            List<string> lines = new List<string>();
            RowTracking.Clear();

            try
            {
                if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                    throw new Exception("Không có kết nối Internet. Vui lòng kiểm tra mạng!");

                var request = Service.Spreadsheets.Values.Get(SpreadSheetID, $"{SheetName}!A:I");
                var response = request.Execute();

                if (response.Values == null || response.Values.Count == 0)
                    return new List<string>();

                try
                {
                    int totalColumns = response.Values.Max(r => r.Count);

                    for (int i = 1; i < response.Values.Count; i++)
                    {
                        var row = response.Values[i];
                        var values = Enumerable.Range(0, totalColumns)
                                               .Select(c => c < row.Count ? row[c]?.ToString()?.Trim().Replace(",", " ") ?? "" : "")
                                               .ToList();

                        string status = values.ElementAtOrDefault(7)?.ToLower() ?? "";
                        if (!string.IsNullOrEmpty(status))
                            continue;

                        string line = string.Join(",", values);
                        lines.Add(line);

                        // Lưu RowIndex → line để update trạng thái hoặc lỗi sau này
                        RowTracking[i + 1] = line;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi xử lý dữ liệu từ Google Sheets.\n" + ex.Message);
                }
            }
            catch (HttpRequestException)
            {
                throw new Exception("Không thể kết nối tới Google Sheets. Vui lòng kiểm tra mạng!");
            }
            catch (SocketException)
            {
                throw new Exception("Mạng bị gián đoạn. Hãy thử lại sau!");
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi không xác định khi đọc dữ liệu:\n" + ex.Message);
            }

            return lines;
        }

        // detailError: danh sách trạng thái (thành công hoặc lỗi) tương ứng từng dòng trong List<string> trả về từ GetOrderLines()
        public void UpdateStatus(List<string> detailError)
        {
            if (detailError == null || detailError.Count == 0)
                return;

            var updateList = new List<ValueRange>();
            int index = 0;

            foreach (var kvp in RowTracking)
            {
                int rowIndex = kvp.Key;
                string errorMessage = index < detailError.Count ? detailError[index] : "";

                string statusText = errorMessage;

                updateList.Add(new ValueRange
                {
                    Range = $"{SheetName}!H{rowIndex}", // cột H là trạng thái
                    Values = new List<IList<object>> { new List<object> { statusText } }
                });

                index++;
            }

            if (updateList.Count > 0)
            {
                var batchUpdateRequest = new BatchUpdateValuesRequest
                {
                    Data = updateList,
                    ValueInputOption = "RAW"
                };
                Service.Spreadsheets.Values.BatchUpdate(batchUpdateRequest, SpreadSheetID).Execute();
            }
        }
    }
}

