using EcosystemApp.DTO;
using EcosystemApp.BUS;

namespace EcosystemApp.GUI
{


    public partial class AccountManagement : Form
    {
        private readonly AccountManagementBUS AccBUS = new AccountManagementBUS();
        private AdminDTO CurrentAdmin;
        private string CurrentAction = ""; // "add" hoặc "edit"
        public AccountManagement()
        {
            InitializeComponent();
        }

        private void AccountManagementLoad(object sender, EventArgs e)
        {
            EnableInput(false);
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
        }

        public AccountManagement(AdminDTO admin)
        {
            InitializeComponent();
            CurrentAdmin = admin;
            EnableInput(false);
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            AccountManagementDTO acc = new AccountManagementDTO();
            acc.SetEmployeePhone(TbEmployeePhone.Text.Trim());
            acc.SetEmployeeName(TbEmployeeName.Text.Trim());
            acc.SetUserName(TbUserName.Text.Trim());
            acc.SetPassword(TbPassword.Text.Trim());

            bool result = false;
            if (CurrentAction == "add")
            {
                result = AccBUS.CreateAccount(acc);
            }
            else if (CurrentAction == "edit")
            {
                result = AccBUS.UpdateAccount(acc);
            }

            if (result)
            {
                RJMessageBox.Show("Lưu tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                EnableInput(false);
                BtnViewClick(sender, e); // load lại bảng
            }
            else
            {
                RJMessageBox.Show("Lưu tài khoản thất bại. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BtnAdd.Enabled = true;
            BtnFix.Enabled = true;
            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
        }
        private void BtnCancelClick(object sender, EventArgs e)
        {
            ClearForm();
            EnableInput(false);
            BtnAdd.Enabled = true;
            BtnFix.Enabled = true;
            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
        }

        private void BtnViewClick(object sender, EventArgs e)
        {
            DgvAccountList.AutoGenerateColumns = true;
            DgvAccountList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvAccountList.DataSource = AccBUS.GetAllAccounts();
        }

        private void BtnFixClick(object sender, EventArgs e)
        {
            AccountManagementDTO acc = new AccountManagementDTO();
            if (DgvAccountList.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn 1 dòng để sửa!", "Thông báo");
                return;
            }

            CurrentAction = "edit";
            EnableInput(true);

            TbEmployeePhone.Text = DgvAccountList.CurrentRow.Cells["Số điện thoại nhân viên"].Value.ToString();
            TbEmployeeName.Text = DgvAccountList.CurrentRow.Cells["Tên nhân viên"].Value.ToString();
            TbUserName.Text = DgvAccountList.CurrentRow.Cells["Tên tài khoản"].Value.ToString();
            TbPassword.Text = DgvAccountList.CurrentRow.Cells["Mật khẩu"].Value.ToString();

            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
            BtnAdd.Enabled = false;
            BtnFix.Enabled = false;
            BtnDelete.Enabled = false;
            TbEmployeeName.Enabled = false;
            TbEmployeePhone.Enabled = false;
            TbUserName.Enabled = false;

        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            if (DgvAccountList.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string username = DgvAccountList.CurrentRow.Cells["Tên tài khoản"].Value.ToString();
            DialogResult confirm = MessageBox.Show($"Bạn có chắc muốn xóa tài khoản '{username}' không?",
                                                   "Xác nhận xóa",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                bool result = AccBUS.DeleteAccount(username);

                if (result)
                {
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgvAccountList.DataSource = AccBUS.GetAllAccounts();
                }
                else
                {
                    MessageBox.Show("Không thể xóa tài khoản. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void BtnAddClick(object sender, EventArgs e)
        {
            CurrentAction = "add";
            EnableInput(true); // bật các textbox
            ClearForm();       // xóa dữ liệu cũ

            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
            BtnAdd.Enabled = false;
            BtnFix.Enabled = false;
            BtnDelete.Enabled = false;
        }
        private void EnableInput(bool enable)
        {
            TbEmployeePhone.Enabled = enable;
            TbEmployeeName.Enabled = enable;
            TbUserName.Enabled = enable;
            TbPassword.Enabled = enable;
        }
        private void ClearForm()
        {
            TbUserName.Clear();
            TbPassword.Clear();
            TbEmployeePhone.Clear();
            TbEmployeeName.Clear();
        }
    }
}
