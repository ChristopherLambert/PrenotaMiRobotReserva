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
            this.PrenotiLabel = new System.Windows.Forms.Label();
            this.BtnMain = new System.Windows.Forms.Button();
            this.CheckLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrenotiLabel
            // 
            this.PrenotiLabel.AutoSize = true;
            this.PrenotiLabel.Location = new System.Drawing.Point(36, 27);
            this.PrenotiLabel.Name = "PrenotiLabel";
            this.PrenotiLabel.Size = new System.Drawing.Size(93, 15);
            this.PrenotiLabel.TabIndex = 0;
            this.PrenotiLabel.Text = "PRENOTI ROBOT";
            // 
            // BtnMain
            // 
            this.BtnMain.Location = new System.Drawing.Point(36, 65);
            this.BtnMain.Name = "BtnMain";
            this.BtnMain.Size = new System.Drawing.Size(201, 23);
            this.BtnMain.TabIndex = 1;
            this.BtnMain.Text = "BTN MAIN";
            this.BtnMain.UseVisualStyleBackColor = true;
            this.BtnMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckLogin
            // 
            this.CheckLogin.Location = new System.Drawing.Point(36, 94);
            this.CheckLogin.Name = "CheckLogin";
            this.CheckLogin.Size = new System.Drawing.Size(201, 23);
            this.CheckLogin.TabIndex = 2;
            this.CheckLogin.Text = "Check Login";
            this.CheckLogin.UseVisualStyleBackColor = true;
            this.CheckLogin.Click += new System.EventHandler(this.CheckLogin_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CheckLogin);
            this.Controls.Add(this.BtnMain);
            this.Controls.Add(this.PrenotiLabel);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PrenotiLabel;
        private Button BtnMain;
        private Button CheckLogin;
    }
}