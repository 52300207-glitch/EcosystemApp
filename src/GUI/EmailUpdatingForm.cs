using EcosystemApp.Utils;

namespace EcosystemApp.GUI
{
    public partial class EmailUpdatingForm : Form
    {
        public EmailUpdatingForm()
        {
            InitializeComponent();
            BtnSave.Click += BtnSaveClick;
        }



        /// <summary>
        /// Sự kiện khi nhấn nút Lưu
        /// </summary>
        private void BtnSaveClick(object sender, EventArgs e)
        {
            string email = TbEnterRecoveryEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                RJMessageBox.Show("Vui lòng nhập email khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!new EmailHelper().IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lưu vào Settings
            EcosystemApp.src.Settings.Default.UserEmail = email;
            EcosystemApp.src.Settings.Default.Save();

            RJMessageBox.Show("✅ Email khôi phục đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
