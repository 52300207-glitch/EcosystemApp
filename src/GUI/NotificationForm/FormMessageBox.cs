using System.Drawing;
using System.Runtime.InteropServices;


namespace EcosystemApp.GUI
{
    public partial class FormMessageBox : Form
    {
        //Fields
        private Color primaryColor = Color.CornflowerBlue;
        private int borderSize = 2;

        //Properties
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set
            {
                primaryColor = value;
                this.BackColor = primaryColor;//Form Border Color
                this.PanelTitleBar.BackColor = PrimaryColor;//Title Bar Back Color
            }
        }

        //Constructors
        // success
        public FormMessageBox(string text)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = SetColorBorder(MessageBoxIcon.None);
            this.LabelMessage.Text = text;
            this.LabelCaption.Text = "Thành công";
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        // thành công
        public FormMessageBox(string text, string caption)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = SetColorBorder(MessageBoxIcon.None);
            this.LabelMessage.Text = text;
            this.LabelCaption.Text = caption;
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }


        // thành công, button yesNo, ok
        public FormMessageBox(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = SetColorBorder(MessageBoxIcon.None);
            this.LabelMessage.Text = text;
            this.LabelCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
        }
        // error warning informatio
        public FormMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) 
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = SetColorBorder(icon);
            this.LabelMessage.Text = text;
            this.LabelCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
            SetIcon(icon);
        }
        public FormMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = SetColorBorder(icon);
            this.LabelMessage.Text = text;
            this.LabelCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, defaultButton);
            SetIcon(icon);
        }

        private Color SetColorBorder(MessageBoxIcon icon) 
        {
            Color color;

            switch (icon)
            {
                case MessageBoxIcon.Information:     // ℹ️ Thông tin
                    color = Color.FromArgb(41, 128, 185); // #2980B9 - xanh lam
                    break;

                case MessageBoxIcon.Question:        // ❓ Câu hỏi / xác nhận
                    color = Color.FromArgb(52, 152, 219); // #3498DB - xanh dương nhạt
                    break;

                case MessageBoxIcon.Warning:         // ⚠️ Cảnh báo / chấm than
                    color = Color.FromArgb(243, 156, 18); // #F39C12 - cam vàng
                    break;

                case MessageBoxIcon.Error:           // ❌ Lỗi nghiêm trọng
                    color = Color.FromArgb(231, 76, 60); // #E74C3C - đỏ
                    break;
                case MessageBoxIcon.None:
                default:
                    color = Color.FromArgb(46, 204, 113); // #BDC3C7 - xám trung tính
                    break;
            }

            return color;
        }
        //-> Private Methods
        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);//Set border size
            this.LabelMessage.MaximumSize = new Size(550, 0);
            this.BtnClose.DialogResult = DialogResult.Cancel;
            this.BtnFirst.DialogResult = DialogResult.OK;
            this.BtnFirst.Visible = false;
            this.BtnSecond.Visible = false;
            this.BtnThird.Visible = false;
        }
        private void SetFormSize()
        {
            int widht = this.LabelMessage.Width + this.PictureBoxIcon.Width + this.PanelBody.Padding.Left;
            int height = this.PanelTitleBar.Height + this.LabelMessage.Height + this.PanelButtons.Height + this.PanelBody.Padding.Top;
            this.Size = new Size(widht, height);
        }
        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.PanelButtons.Width - BtnFirst.Width) / 2;
            int yCenter = (this.PanelButtons.Height - BtnFirst.Height) / 2;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    //OK Button
                    BtnFirst.Visible = true;
                    BtnFirst.Location = new Point(xCenter, yCenter);
                    BtnFirst.Text = "Đồng ý";
                    BtnFirst.DialogResult = DialogResult.OK;//Set DialogResult

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.OKCancel:
                    //OK Button
                    BtnFirst.Visible = true;
                    BtnFirst.Location = new Point(xCenter - (BtnFirst.Width / 2) - 5, yCenter);
                    BtnFirst.Text = "Đồng ý";
                    BtnFirst.DialogResult = DialogResult.OK;//Set DialogResult

                    //Cancel Button
                    BtnSecond.Visible = true;
                    BtnSecond.Location = new Point(xCenter + (BtnSecond.Width / 2) + 5, yCenter);
                    BtnSecond.Text = "Hủy";
                    BtnSecond.DialogResult = DialogResult.Cancel;//Set DialogResult
                    BtnSecond.BackColor = Color.DimGray;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be BtnThird
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.RetryCancel:
                    //Retry Button
                    BtnFirst.Visible = true;
                    BtnFirst.Location = new Point(xCenter - (BtnFirst.Width / 2) - 5, yCenter);
                    BtnFirst.Text = "Thử lại";
                    BtnFirst.DialogResult = DialogResult.Retry;//Set DialogResult

                    //Cancel Button
                    BtnSecond.Visible = true;
                    BtnSecond.Location = new Point(xCenter + (BtnSecond.Width / 2) + 5, yCenter);
                    BtnSecond.Text = "Hủy";
                    BtnSecond.DialogResult = DialogResult.Cancel;//Set DialogResult
                    BtnSecond.BackColor = Color.DimGray;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be BtnThird
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.YesNo:
                    //Yes Button
                    BtnFirst.Visible = true;
                    BtnFirst.Location = new Point(xCenter - (BtnFirst.Width / 2) - 5, yCenter);
                    BtnFirst.Text = "Đồng ý";
                    BtnFirst.DialogResult = DialogResult.Yes;//Set DialogResult

                    //No Button
                    BtnSecond.Visible = true;
                    BtnSecond.Location = new Point(xCenter + (BtnSecond.Width / 2) + 5, yCenter);
                    BtnSecond.Text = "Không";
                    BtnSecond.DialogResult = DialogResult.No;//Set DialogResult
                    BtnSecond.BackColor = Color.IndianRed;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be BtnThird
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    //Yes Button
                    BtnFirst.Visible = true;
                    BtnFirst.Location = new Point(xCenter - BtnFirst.Width - 5, yCenter);
                    BtnFirst.Text = "Đồng ý";
                    BtnFirst.DialogResult = DialogResult.Yes;//Set DialogResult

                    //No Button
                    BtnSecond.Visible = true;
                    BtnSecond.Location = new Point(xCenter, yCenter);
                    BtnSecond.Text = "Không";
                    BtnSecond.DialogResult = DialogResult.No;//Set DialogResult
                    BtnSecond.BackColor = Color.IndianRed;

                    //Cancel Button
                    BtnThird.Visible = true;
                    BtnThird.Location = new Point(xCenter + BtnSecond.Width + 5, yCenter);
                    BtnThird.Text = "Hủy";
                    BtnThird.DialogResult = DialogResult.Cancel;//Set DialogResult
                    BtnThird.BackColor = Color.DimGray;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;

                case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    BtnFirst.Visible = true;
                    BtnFirst.Location = new Point(xCenter - BtnFirst.Width - 5, yCenter);
                    BtnFirst.Text = "Dừng";
                    BtnFirst.DialogResult = DialogResult.Abort;//Set DialogResult
                    BtnFirst.BackColor = Color.Goldenrod;

                    //Retry Button
                    BtnSecond.Visible = true;
                    BtnSecond.Location = new Point(xCenter, yCenter);
                    BtnSecond.Text = "Thử lại";
                    BtnSecond.DialogResult = DialogResult.Retry;//Set DialogResult                    

                    //Ignore Button
                    BtnThird.Visible = true;
                    BtnThird.Location = new Point(xCenter + BtnSecond.Width + 5, yCenter);
                    BtnThird.Text = "Bỏ qua";
                    BtnThird.DialogResult = DialogResult.Ignore;//Set DialogResult
                    BtnThird.BackColor = Color.IndianRed;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
            }
        }
        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1://Focus button 1
                    BtnFirst.Select();
                    BtnFirst.ForeColor = Color.White;
                    BtnFirst.Font = new Font(BtnFirst.Font, FontStyle.Regular);
                    break;
                case MessageBoxDefaultButton.Button2://Focus button 2
                    BtnSecond.Select();
                    BtnSecond.ForeColor = Color.White;
                    BtnSecond.Font = new Font(BtnSecond.Font, FontStyle.Regular);
                    break;
                case MessageBoxDefaultButton.Button3://Focus button 3
                    BtnThird.Select();
                    BtnThird.ForeColor = Color.White;
                    BtnThird.Font = new Font(BtnThird.Font, FontStyle.Regular);
                    break;
            }
        }
        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.PictureBoxIcon.Image = EcosystemApp.src.assets.Image.Resource.error;
                    PrimaryColor = Color.FromArgb(224, 79, 95);
                    this.BtnClose.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    break;
                case MessageBoxIcon.Information: //Information
                    this.PictureBoxIcon.Image = EcosystemApp.src.assets.Image.Resource.information;
                    PrimaryColor = Color.FromArgb(38, 191, 166);
                    break;
                case MessageBoxIcon.Question://Question
                    this.PictureBoxIcon.Image = EcosystemApp.src.assets.Image.Resource.question;
                    PrimaryColor = Color.FromArgb(10, 119, 232);
                    break;
                case MessageBoxIcon.Exclamation://Exclamation
                    this.PictureBoxIcon.Image = EcosystemApp.src.assets.Image.Resource.exclamation;
                    PrimaryColor = Color.FromArgb(255, 140, 0);
                    break;
                case MessageBoxIcon.None: //None
                    this.PictureBoxIcon.Image = EcosystemApp.src.assets.Image.Resource.chat;
                    PrimaryColor = Color.CornflowerBlue;
                    break;
            }
        }

        //-> Events Methods
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region -> Drag Form
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }

}

