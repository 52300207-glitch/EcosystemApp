using EcosystemApp.Utils;
using EcosystemApp.DTO;
using EcosystemApp.BUS;

namespace EcosystemApp.GUI.ChildEmployeeForm
{
    public partial class GetDeliveryRouteByExcel : Form
    {
        private UserDTO CurrentUser = Program.CurrentUser;
        private DeliveryAssignmentBUS DeliveryAssignmentBUS = new DeliveryAssignmentBUS();
        public GetDeliveryRouteByExcel()
        {
            InitializeComponent();
        }

        private void ChosenFileClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel/CSV Files|*.xlsx;*.xls;*.csv";
                openFileDialog.Title = "Chọn file Excel hoặc CSV";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    TbFile.Text = filePath;

                    try
                    {

                        if (!File.Exists(filePath))
                        {
                            RJMessageBox.Show("Không tìm thấy file được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string ext = Path.GetExtension(filePath).ToLower();
                        CbbSheetNameFromExcel.Items.Clear();

                        if (ext == ".xlsx" || ext == ".xls")
                        {
                            List<string> sheetNames = ExcelHelper.GetSheetNames(filePath);

                            foreach (var name in sheetNames)
                            {
                                CbbSheetNameFromExcel.Items.Add(name);
                            }

                            if (sheetNames.Count > 0)
                                CbbSheetNameFromExcel.SelectedIndex = 0;

                            CbbSheetNameFromExcel.Enabled = true;
                            BtnGetDataExcel.Enabled = true;

                        }

                        else if (ext == ".csv")
                        {
                            CbbSheetNameFromExcel.Enabled = false;
                            CbbSheetNameFromExcel.Text = "";
                            BtnGetDataExcel.Enabled = true;
                        }
                        else
                        {
                            CbbSheetNameFromExcel.Enabled = false;
                            CbbSheetNameFromExcel.Text = "";
                            BtnGetDataExcel.Enabled = false;

                        }
                    }
                    catch (Exception ex)
                    {
                        RJMessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnGetDataExcelClick(object sender, EventArgs e)
        {
            LbText2.Visible = true;
            LbText1.Visible = true;
            LbText3.Visible = true;
            TbOrderExcelSucess.Visible = true;
            TbOrderExcelFault.Visible = true;
            try
            {
                var details = DeliveryAssignmentBUS.UpdateCompletedFromExcel(TbFile.Text, CbbSheetNameFromExcel.Text);
                TbOrderExcelFault.Text = details[0].ToString();
                TbOrderExcelSucess.Text = details[1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetDeliveryRouteByExcelLoad(object sender, EventArgs e)
        {

        }
    }
}
