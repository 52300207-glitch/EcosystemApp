using EcosystemApp.DTO;
using EcosystemApp.GUI.ChildReportForm;
using EcosystemApp.GUI.Components;

namespace EcosystemApp.GUI
{
    public partial class ReportForm : Form
    {
        private EmployeeDTO? CurrentEmployee;
        private RJButton? BtnCurrent;
        private new Form? ActiveForm;

        public ReportForm()
        {
            InitializeComponent();
        }

        public ReportForm(EmployeeDTO emp) : this()
        {
            CurrentEmployee = emp;
        }

        public void ShowDefaultRevenueReport()
        {
            BtnRevenueReportClick(BtnRevenueReport, EventArgs.Empty);
        }

        private void ReportFormLoad(object sender, EventArgs e)
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
            foreach (Control ctrl in PanelMenuReportForm.Controls)
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
            foreach (Control ctrl in PanelMenuReportForm.Controls)
            {
                if (ctrl is RJButton btn)
                {
                    btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular);
                    btn.ForeColor = Color.Black;
                }
            }
        }

        private void OpenChildReportForm(Form childForm, object btnSender)
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
            this.PanelChildReportForm.Controls.Add(childForm);
            this.PanelChildReportForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnRevenueReportClick(object sender, EventArgs e)
        {
            OpenChildReportForm(new RevenueReportForm(), sender);
        }

        private void BtnFrequencyCustomerRefillClick(object sender, EventArgs e)
        {
            OpenChildReportForm(new StatisticsForm(), sender);
        }
    }
}
