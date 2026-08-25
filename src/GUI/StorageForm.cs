using EcosystemApp.DTO;
using EcosystemApp.GUI.ChildStorageForm;
using EcosystemApp.GUI.Components;

namespace EcosystemApp.GUI
{
    public partial class StorageForm : Form
    {
        private RJButton? BtnCurrent;
        private new Form? ActiveForm;
        private EmployeeDTO? CurrentEmployee;

        public StorageForm(EmployeeDTO emp)
        {
            InitializeComponent();
            CurrentEmployee = emp;
        }

        public void ShowDefaultInventoryList()
        {
            BtnInventoryListClick(BtnInventoryList, EventArgs.Empty);
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
            foreach (Control ctrl in PanelMenuStorageForm.Controls)
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
            foreach (Control ctrl in PanelMenuStorageForm.Controls)
            {
                if (ctrl is RJButton btn)
                {
                    btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular);
                    btn.ForeColor = Color.Black;
                }
            }
        }

        private void OpenChildStorageForm(Form childForm, object btnSender)
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
            this.PanelChildStorageForm.Controls.Add(childForm);
            this.PanelChildStorageForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void BtnInventoryListClick(object sender, EventArgs e)
        {
            OpenChildStorageForm(new InventoryListForm(CurrentEmployee), sender);
        }

        private void BtnImportExportProductClick(object sender, EventArgs e)
        {
            OpenChildStorageForm(new ImportExportProductForm(), sender);
            ImportExportProductForm importExport = new ImportExportProductForm(CurrentEmployee);
            OpenChildStorageForm(importExport, sender);
            importExport.ShowDefaultImportProduct();
        }

        private void BtnTankCleaningScheduleClick(object sender, EventArgs e)
        {
            OpenChildStorageForm(new TankCleaningScheduleForm(CurrentEmployee), sender);
        }

        private void BtnProductListClick(object sender, EventArgs e)
        {
            OpenChildStorageForm(new ProductListForm(CurrentEmployee), sender);
        }
    }
}
