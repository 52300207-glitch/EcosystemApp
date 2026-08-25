namespace EcosystemApp.GUI
{
    public partial class FormLogin : Form
    {
        private Button CurrentButton;
        private Form ActiveForm;
        public FormLogin()
        {
            InitializeComponent();
            this.Load += FormLoginLoad;
        }
        private void FormLoginLoad(object sender, EventArgs e)
        {
            ActivateButton(ButEmployee);
            OpenChildForm(new ChildForm.FormLoginEmp(this), ButEmployee);
        }
        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                if (CurrentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(84, 161, 85);
                    CurrentButton = (Button)sender;
                    CurrentButton.BackColor = color;
                    CurrentButton.ForeColor = Color.White;
                }
            }
        }

        private void DisableButton()
        {
            if (CurrentButton != null)
            {
                CurrentButton.BackColor = Color.FromArgb(248, 255, 245);
                CurrentButton.ForeColor = Color.Black;
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActivateButton(btnSender);
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Clear();
            this.panelChildForm.Controls.Add(childForm);
            this.panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void ButAdminClick(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForm.FormLoginAdmin(this), sender);
        }


        private void ButEmployeeClick(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForm.FormLoginEmp(this), sender);
        }

        private void FormLoginFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
