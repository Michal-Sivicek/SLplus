namespace ScitaniLidu
{
    partial class UserPopulationPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.religionTextBox = new System.Windows.Forms.TextBox();
            this.textBoxNabozenstvi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameTextBox.Location = new System.Drawing.Point(312, 103);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(211, 23);
            this.usernameTextBox.TabIndex = 0;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(264, 106);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(42, 15);
            this.username.TabIndex = 1;
            this.username.Text = "Jmeno";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(269, 135);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(37, 15);
            this.password.TabIndex = 2;
            this.password.Text = "Heslo";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTextBox.Location = new System.Drawing.Point(312, 132);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(211, 23);
            this.passwordTextBox.TabIndex = 3;
            // 
            // adressTextBox
            // 
            this.adressTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adressTextBox.Location = new System.Drawing.Point(312, 161);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(211, 23);
            this.adressTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bydliště";
            // 
            // religionTextBox
            // 
            this.religionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.religionTextBox.Location = new System.Drawing.Point(312, 190);
            this.religionTextBox.Name = "religionTextBox";
            this.religionTextBox.Size = new System.Drawing.Size(211, 23);
            this.religionTextBox.TabIndex = 6;
            // 
            // textBoxNabozenstvi
            // 
            this.textBoxNabozenstvi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNabozenstvi.AutoSize = true;
            this.textBoxNabozenstvi.Location = new System.Drawing.Point(234, 193);
            this.textBoxNabozenstvi.Name = "textBoxNabozenstvi";
            this.textBoxNabozenstvi.Size = new System.Drawing.Size(72, 15);
            this.textBoxNabozenstvi.TabIndex = 7;
            this.textBoxNabozenstvi.Text = "Náboženství";
            // 
            // UserPopulationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNabozenstvi);
            this.Controls.Add(this.religionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "UserPopulationPage";
            this.Text = "UserPopulationPage";
            this.Load += new System.EventHandler(this.UserPopulationPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usernameTextBox;
        private Label username;
        private Label password;
        private TextBox passwordTextBox;
        private TextBox adressTextBox;
        private Label label1;
        private TextBox religionTextBox;
        private Label textBoxNabozenstvi;
    }
}