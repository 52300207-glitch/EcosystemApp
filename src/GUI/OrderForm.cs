using EcosystemApp.DTO;
using EcosystemApp.GUI.ChildOrderForm;

namespace EcosystemApp.GUI
{
    public partial class OrderForm : Form
    {
        private Button? BtnCurrent;
        private new Form? ActiveForm;
        private EmployeeDTO? CurrentUser;
        private CollectDataForm CollectDataFormInstance = new CollectDataForm();
        private OrderListForm OrderListFormInstance = new OrderListForm();
        public OrderForm()
        {
            InitializeComponent();
        }
        public OrderForm(EmployeeDTO user) : this()
        {
            CurrentUser = user;
            CollectDataFormInstance = new CollectDataForm(CurrentUser);
            OrderListFormInstance = new OrderListForm(CurrentUser);
        }

        public void ShowDefaultCollectData()
        {
            BtnCollectDataClick(BtnCollectData, EventArgs.Empty);
        }

        private void OrderFormLoad(object sender, EventArgs e)
        {
            HoverEvents();
        }

        private void HoverEvents()
        {
            foreach (Control ctrl in PanelMenuOrderForm.Controls)
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
            foreach (Control ctrl in PanelMenuOrderForm.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular);
                    btn.ForeColor = Color.Black;
                }
            }
        }

        private void OpenChildOrderForm(Form childForm, object btnSender)
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
            this.PanelChildOrderForm.Controls.Add(childForm);
            this.PanelChildOrderForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnCollectDataClick(object sender, EventArgs e)
        {
            OpenChildOrderForm(CollectDataFormInstance, sender);
        }

        private void BtnDataListClick(object sender, EventArgs e)
        {
            OpenChildOrderForm(OrderListFormInstance, sender);
        }
    }
}
