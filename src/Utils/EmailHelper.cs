using MailKit.Net.Smtp;
using MimeKit;
using System.Net.Mail;

namespace EcosystemApp.Utils
{
    public class EmailHelper
    {
        private readonly string SmtpServer = "smtp.gmail.com";
        private readonly int SmtpPort = 587; // TLS

        private readonly string SenderEmail = "nhat2127.ytb@gmail.com";
        private readonly string SenderPassword = "puov mjgt pugn vujl"; // App password Gmail

        private string ToEmail = EcosystemApp.src.Settings.Default.UserEmail;


        private string GenerateToken(int length = 6)
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString();
        }

        public async Task<string> SendVerificationCodeAsync()
        {
            // Tạo token
            string token = GenerateToken();

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Ecosystem Service", SenderEmail));
            message.To.Add(new MailboxAddress("", ToEmail));

            message.Subject = "[Ecosystem] Mã xác nhận thay đổi mật khẩu";

            string body =
                $"Xin chào,\n\n" +
                $"Mã xác nhận để thay đổi mật khẩu của bạn là: {token}\n\n" +
                $"Mã có hiệu lực trong 5 phút.\n" +
                $"Vui lòng không chia sẻ mã này cho bất kỳ ai.\n\n" +
                $"Trân trọng,\nĐội ngũ hỗ trợ Ecosystem.";

            message.Body = new TextPart("plain")
            {
                Text = body
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                try
                {
                    await client.ConnectAsync(SmtpServer, SmtpPort, MailKit.Security.SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync(SenderEmail, SenderPassword);

                    await client.SendAsync(message);

                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    await client.DisconnectAsync(true);
                }
            }
            return token;
        }


        public  bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
