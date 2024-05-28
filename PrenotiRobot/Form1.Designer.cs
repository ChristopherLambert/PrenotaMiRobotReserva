namespace PrenotiRobot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PrenotiLabel = new Label();
            BtnMain = new Button();
            CheckLogin = new Button();
            textLogin = new TextBox();
            testPass = new TextBox();
            loginLabel = new Label();
            passLabel = new Label();
            SuspendLayout();
            // 
            // PrenotiLabel
            // 
            PrenotiLabel.AutoSize = true;
            PrenotiLabel.Location = new Point(36, 27);
            PrenotiLabel.Name = "PrenotiLabel";
            PrenotiLabel.Size = new Size(144, 25);
            PrenotiLabel.TabIndex = 0;
            PrenotiLabel.Text = "PRENOTI ROBOT";
            // 
            // BtnMain
            // 
            BtnMain.Location = new Point(36, 65);
            BtnMain.Name = "BtnMain";
            BtnMain.Size = new Size(201, 38);
            BtnMain.TabIndex = 1;
            BtnMain.Text = "BTN MAIN";
            BtnMain.UseVisualStyleBackColor = true;
            BtnMain.Click += button1_Click;
            // 
            // CheckLogin
            // 
            CheckLogin.Location = new Point(255, 65);
            CheckLogin.Name = "CheckLogin";
            CheckLogin.Size = new Size(201, 38);
            CheckLogin.TabIndex = 2;
            CheckLogin.Text = "Check Login";
            CheckLogin.UseVisualStyleBackColor = true;
            CheckLogin.Click += CheckLogin_Click;
            // 
            // textLogin
            // 
            textLogin.Location = new Point(116, 129);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(340, 31);
            textLogin.TabIndex = 3;
            // 
            // testPass
            // 
            testPass.Location = new Point(116, 181);
            testPass.Name = "testPass";
            testPass.Size = new Size(340, 31);
            testPass.TabIndex = 4;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(39, 134);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(60, 25);
            loginLabel.TabIndex = 5;
            loginLabel.Text = "Login:";
            loginLabel.UseMnemonic = false;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new Point(39, 184);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(50, 25);
            passLabel.TabIndex = 6;
            passLabel.Text = "Pass:";
            passLabel.UseMnemonic = false;
            // 
            // Form1
            // 
            ClientSize = new Size(487, 261);
            Controls.Add(passLabel);
            Controls.Add(loginLabel);
            Controls.Add(testPass);
            Controls.Add(textLogin);
            Controls.Add(CheckLogin);
            Controls.Add(BtnMain);
            Controls.Add(PrenotiLabel);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PrenotiLabel;
        private Button BtnMain;
        private Button CheckLogin;
        private TextBox textLogin;
        private TextBox testPass;
        private Label loginLabel;
        private Label passLabel;
    }
}