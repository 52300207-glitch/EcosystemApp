using EcosystemApp.DTO;
using EcosystemApp.GUI.ChildEmployeeForm;

namespace EcosystemApp.GUI
{
    public partial class EmployeeForm : Form
    {
        private EmployeeDTO? CurrentEmployee;
        private EmployeeListForm EmployeeListFormInstance = new EmployeeListForm();
        private ManageLogisticForm ManageLogisticFormInstance = new ManageLogisticForm();
        private Button? BtnCurrent;
        private new Form? ActiveForm;

        public EmployeeForm()
        {
            InitializeComponent();
        }
        public EmployeeForm(EmployeeDTO user) : this()
        {
            CurrentEmployee = user;
            EmployeeListFormInstance = new EmployeeListForm();
            ManageLogisticFormInstance = new ManageLogisticForm();
        }

        public void ShowDefaultEmployeeList()
        {
            BtnEmployeeListClick(BtnEmployeeList, EventArgs.Empty);
        }

        private void EmployeeFormLoad(object sender, EventArgs e)
        {
            HoverEvents();
        }

        private void HoverEvents()
        {
            foreach (Control ctrl in PanelMenuEmployeeForm.Controls)
            {
                if (ctrl is Button btn)
                {
                    // Ensure we don't attach multiple times
                    btn.MouseEnter -= ButtonMouseEnter;
                    btn.MouseLeave -= ButtonMouseLeave;
                    btn.MouseEnter += ButtonMouseEnter;
                    btn.MouseLeave += ButtonMouseLeave;
                }
            }
        }
        private void ButtonMouseEnter(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;
            if (btn != BtnCurrent)
            {
                btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Underline);
                btn.ForeColor = Color.FromArgb(86, 142, 89);
            }
        }
        private void ButtonMouseLeave(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;
            if (btn != BtnCurrent)
            {
                btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular);
                btn.ForeColor = Color.Black;
            }
        }
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                BtnCurrent = (Button)btnSender;
                BtnCurrent.Font = new Font(BtnCurrent.Font.FontFamily, BtnCurrent.Font.Size, FontStyle.Underline | FontStyle.Bold);
                BtnCurrent.ForeColor = Color.FromArgb(86, 142, 89);
            }
        }
        private void DisableButton()
        {
            foreach (Control ctrl in PanelMenuEmployeeForm.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular);
                    btn.ForeColor = Color.Black;
                }
            }
        }


        private void OpenChildEmployeeForm(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Hide();
            }
            ActiveButton(btnSender);
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelChildEmployeeForm.Controls.Add(childForm);
            this.PanelChildEmployeeForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnEmployeeListClick(object sender, EventArgs e)
        {
            FormMessageBox fmb = new FormMessageBox("Hoan nghênh", "Chào mừng ông chủ trở về", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenChildEmployeeForm(EmployeeListFormInstance, sender);
        }

        private void BtnManageLogisticClick(object sender, EventArgs e)
        {
            OpenChildEmployeeForm(ManageLogisticFormInstance, sender);
        }
    }
}
