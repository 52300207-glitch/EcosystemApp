using EcosystemApp.DTO;
using EcosystemApp.GUI.ChildPackageForm;
using EcosystemApp.GUI.Components;

namespace EcosystemApp.GUI
{
    public partial class PackageForm : Form
    {
        private EmployeeDTO? CurrentEmployee;
        private RJButton? BtnCurrent;
        private new Form? ActiveForm;

        public PackageForm()
        {
            InitializeComponent();
        }
        public PackageForm(EmployeeDTO emp) : this()
        {
            CurrentEmployee = emp;
        }

        public void ShowDefaultPackageList()
        {
            BtnPackageListClick(BtnPackageList, EventArgs.Empty);
        }

        private void StorageFormLoad(object sender, EventArgs e)
        {
            HoverEvents();
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                BtnCurrent = (RJButton)btnSender;
                BtnCurrent.Font = new Font(BtnCurrent.Font.FontFamily, BtnCurrent.Font.Size, FontStyle.Underline | FontStyle.Bold);
                BtnCurrent.ForeColor = Color.FromArgb(86, 142, 89);
            }
        }

        private void HoverEvents()
        {
            foreach (Control ctrl in PanelMenuPackageForm.Controls)
            {
                if (ctrl is RJButton btn)
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
            if (sender is not RJButton btn) return;
            if (btn != BtnCurrent)
            {
                btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Underline);
                btn.ForeColor = Color.FromArgb(86, 142, 89);
            }
        }
        private void ButtonMouseLeave(object? sender, EventArgs e)
        {
            if (sender is not RJButton btn) return;
            if (btn != BtnCurrent)
            {
                btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular);
                btn.ForeColor = Color.Black;
            }
        }
        private void DisableButton()
        {
            foreach (Control ctrl in PanelMenuPackageForm.Controls)
            {
                if (ctrl is RJButton btn)
                {
                    btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular);
                    btn.ForeColor = Color.Black;
                }
            }
        }

        private void OpenChildPackageForm(Form childForm, object btnSender)
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
            this.PanelChildPackageForm.Controls.Add(childForm);
            this.PanelChildPackageForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnPackageListClick(object sender, EventArgs e)
        {
            OpenChildPackageForm(new PackageListForm(CurrentEmployee!), sender);
        }

        private void BtnStatiscalPackageClick(object sender, EventArgs e)
        {
            OpenChildPackageForm(new StatiscalPackageForm(CurrentEmployee!), sender);
        }

        private void BtnPackageCleaningClick(object sender, EventArgs e)
        {
            OpenChildPackageForm(new PackageCleaningForm(CurrentEmployee!), sender);
        }

    }
}
