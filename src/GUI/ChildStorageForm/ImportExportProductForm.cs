using EcosystemApp.GUI.Components;
using EcosystemApp.GUI.ChildStorageForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcosystemApp.DTO;

namespace EcosystemApp.GUI.ChildStorageForm
{
    public partial class ImportExportProductForm : Form
    {
        private RJButton? BtnCurrent;
        private new Form? ActiveForm;
        private EmployeeDTO? CurrentEmployee;

        public ImportExportProductForm()
        {
            InitializeComponent();
        }
        public ImportExportProductForm(EmployeeDTO emp)
        {
            InitializeComponent();
            CurrentEmployee = emp;
        }

        private void ImportExportProductFormLoad(object sender, EventArgs e)
        {
            HoverEvents();
        }

        public void ShowDefaultImportProduct()
        {
            BtnImportProductClick(BtnImportProduct, EventArgs.Empty);
        }

        private void HoverEvents()
        {
            foreach (Control ctrl in PanelMenuImportExport.Controls)
            {
                if (ctrl is Button btn)
                {
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
                btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Bold);
                btn.BackgroundColor = Color.FromArgb(228, 255, 207);
            }
        }
        private void ButtonMouseLeave(object? sender, EventArgs e)
        {
            if (sender is not RJButton btn) return;
            if (btn != BtnCurrent)
            {
                btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular);
                btn.BackgroundColor = Color.FromArgb(248, 255, 245);
            }
        }
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                BtnCurrent = (RJButton)btnSender;
                BtnCurrent.Font = new Font(BtnCurrent.Font.FontFamily, BtnCurrent.Font.Size, FontStyle.Bold);
                BtnCurrent.BackgroundColor = Color.FromArgb(228, 255, 207);
            }
        }
        private void DisableButton()
        {
            foreach (Control ctrl in PanelMenuImportExport.Controls)
            {
                if (ctrl is RJButton btn)
                {
                    btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular);
                    btn.BackgroundColor = Color.FromArgb(248, 255, 245);
                }
            }
        }

        private void OpenChildImportExportForm(Form childForm, object btnSender)
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
            this.PanelImportExport.Controls.Add(childForm);
            this.PanelImportExport.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnImportProductClick(object sender, EventArgs e)
        {
            OpenChildImportExportForm(new ImportProductForm(CurrentEmployee), sender);
        }

        private void BtnExportProductClick(object sender, EventArgs e)
        {
            OpenChildImportExportForm(new ExportProductForm(CurrentEmployee), sender);
        }

    }
}
