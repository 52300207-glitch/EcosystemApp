using EcosystemApp.Utils;
using EcosystemApp.BUS;
using EcosystemApp.GUI;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcosystemApp.GUI.ChildForm
{
    public partial class ForgotPasswordForm : Form
    {
        private readonly AdminBUS AdminBUS = new AdminBUS();
        private EmailHelper EmailHelper = new EmailHelper();
        private string Token; // Lưu token gửi email
        private DateTime TokenCreatedTime; // Thời gian tạo token
        private readonly int TokenExpiryMinutes = 5; // Token hiệu lực 5 phút

        public ForgotPasswordForm()
        {
            InitializeComponent();

            // Đăng ký event
            this.Load += ForgotPasswordFormLoad;

            BtnOTPConfirmation.Click += BtnOTPConfirmationClick;
            BtnResend.Click += BtnResendClick;
            BtnPasswordConfirmation.Click += BtnPasswordConfirmationClick;
        }

        // Khi form load → gửi OTP
        private async void ForgotPasswordFormLoad(object sender, EventArgs e)
        {
            await SendOtpAsync();
        }

        // Hàm gửi OTP
        private async Task SendOtpAsync()
        {
            Token = await EmailHelper.SendVerificationCodeAsync();

            if (Token == null)
            {
                RJMessageBox.Show("Lỗi gửi email. Vui lòng thử lại!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TokenCreatedTime = DateTime.Now;
            RJMessageBox.Show($"Mã xác nhận đã được gửi tới {EcosystemApp.src.Settings.Default.UserEmail}", "Thành công", MessageBoxButtons.OK);
        }

        // Xác nhận OTP
        private void BtnOTPConfirmationClick(object sender, EventArgs e)
        {
            string userInput = TbOTPCode.Text.Trim();

            if (string.IsNullOrEmpty(userInput))
            {
                RJMessageBox.Show("Vui lòng nhập OTP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra token hết hạn
            if (DateTime.Now > TokenCreatedTime.AddMinutes(TokenExpiryMinutes))
            {
                RJMessageBox.Show("OTP đã hết hạn. Vui lòng gửi lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PanelChangePassword.Visible = false;
                return;
            }

            if (userInput == Token)
            {
                RJMessageBox.Show($"OTP hợp lệ. Bạn có thể đổi mật khẩu mới.", "Thành công", MessageBoxButtons.OK);

                PanelChangePassword.Visible = true;
            }
            else
            {
                RJMessageBox.Show("OTP không đúng. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Gửi lại OTP
        private async void BtnResendClick(object sender, EventArgs e)
        {
            await SendOtpAsync();
        }

        // Xác nhận mật khẩu mới
        private void BtnPasswordConfirmationClick(object sender, EventArgs e)
        {
            string newPassword = TbChangePassword.Text.Trim();
            string confirmPassword = TbEnterAgain.Text.Trim();

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                RJMessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (newPassword != confirmPassword)
            {
                RJMessageBox.Show("Mật khẩu nhập lại không trùng khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return;
            }

            // Gọi AdminBUS để cập nhật mật khẩu
            bool success = AdminBUS.UpdatePassword(newPassword);


            if (success)
            {
                RJMessageBox.Show($"Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK);

                this.Close();
            }
            else
            {
                RJMessageBox.Show("Lỗi đổi mật khẩu. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
