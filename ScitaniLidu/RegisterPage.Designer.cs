namespace ScitaniLidu
{
    partial class RegisterPage
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
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.registerUsername = new System.Windows.Forms.TextBox();
            this.firstPassword = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.secondPassword = new System.Windows.Forms.TextBox();
            this.confirmText = new System.Windows.Forms.Label();
            this.checkBoxPodminky = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.RegisterPageText = new System.Windows.Forms.Label();
            this.RegisterPageReturn = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(214, 172);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 15);
            this.name.TabIndex = 2;
            this.name.Text = "Jmeno";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(219, 201);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(37, 15);
            this.password.TabIndex = 3;
            this.password.Text = "Heslo";
            // 
            // registerUsername
            // 
            this.registerUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registerUsername.Location = new System.Drawing.Point(262, 169);
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(215, 23);
            this.registerUsername.TabIndex = 4;
            // 
            // firstPassword
            // 
            this.firstPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstPassword.Location = new System.Drawing.Point(262, 198);
            this.firstPassword.Name = "firstPassword";
            this.firstPassword.Size = new System.Drawing.Size(215, 23);
            this.firstPassword.TabIndex = 5;
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registerButton.Location = new System.Drawing.Point(402, 281);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Registrace";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // secondPassword
            // 
            this.secondPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.secondPassword.Location = new System.Drawing.Point(262, 227);
            this.secondPassword.Name = "secondPassword";
            this.secondPassword.Size = new System.Drawing.Size(215, 23);
            this.secondPassword.TabIndex = 7;
            // 
            // confirmText
            // 
            this.confirmText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmText.AutoSize = true;
            this.confirmText.Location = new System.Drawing.Point(170, 230);
            this.confirmText.Name = "confirmText";
            this.confirmText.Size = new System.Drawing.Size(86, 15);
            this.confirmText.TabIndex = 8;
            this.confirmText.Text = "Potvrzení hesla";
            // 
            // checkBoxPodminky
            // 
            this.checkBoxPodminky.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxPodminky.AutoSize = true;
            this.checkBoxPodminky.Location = new System.Drawing.Point(262, 256);
            this.checkBoxPodminky.Name = "checkBoxPodminky";
            this.checkBoxPodminky.Size = new System.Drawing.Size(160, 19);
            this.checkBoxPodminky.TabIndex = 9;
            this.checkBoxPodminky.Text = "Souhlasím s podmínkami";
            this.checkBoxPodminky.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(417, 257);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 15);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RegisterPageText
            // 
            this.RegisterPageText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RegisterPageText.AutoSize = true;
            this.RegisterPageText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterPageText.Location = new System.Drawing.Point(292, 113);
            this.RegisterPageText.Name = "RegisterPageText";
            this.RegisterPageText.Size = new System.Drawing.Size(149, 32);
            this.RegisterPageText.TabIndex = 11;
            this.RegisterPageText.Text = "Zaregisruj se";
            // 
            // RegisterPageReturn
            // 
            this.RegisterPageReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterPageReturn.AutoSize = true;
            this.RegisterPageReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterPageReturn.Depth = 0;
            this.RegisterPageReturn.Location = new System.Drawing.Point(742, 26);
            this.RegisterPageReturn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegisterPageReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterPageReturn.Name = "RegisterPageReturn";
            this.RegisterPageReturn.Primary = false;
            this.RegisterPageReturn.Size = new System.Drawing.Size(45, 36);
            this.RegisterPageReturn.TabIndex = 12;
            this.RegisterPageReturn.Text = "Zpět";
            this.RegisterPageReturn.UseVisualStyleBackColor = true;
            this.RegisterPageReturn.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterPageReturn);
            this.Controls.Add(this.RegisterPageText);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBoxPodminky);
            this.Controls.Add(this.confirmText);
            this.Controls.Add(this.secondPassword);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.firstPassword);
            this.Controls.Add(this.registerUsername);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Name = "RegisterPage";
            this.Text = "RegisterPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterPage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label name;
        private Label password;
        private TextBox registerUsername;
        private TextBox firstPassword;
        private Button registerButton;
        private TextBox secondPassword;
        private Label confirmText;
        private CheckBox checkBoxPodminky;
        private LinkLabel linkLabel1;
        private Label RegisterPageText;
        private MaterialSkin.Controls.MaterialFlatButton RegisterPageReturn;
    }
}