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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.MainText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstPassword = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.secondPassword = new System.Windows.Forms.TextBox();
            this.confirmText = new System.Windows.Forms.Label();
            this.checkBoxPodminky = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainText
            // 
            this.MainText.AutoSize = true;
            this.MainText.Location = new System.Drawing.Point(292, 60);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(77, 15);
            this.MainText.TabIndex = 0;
            this.MainText.Text = "Zaregistruj se";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(214, 172);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 15);
            this.name.TabIndex = 2;
            this.name.Text = "Jmeno";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(219, 201);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(37, 15);
            this.password.TabIndex = 3;
            this.password.Text = "Heslo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 23);
            this.textBox1.TabIndex = 4;
            // 
            // firstPassword
            // 
            this.firstPassword.Location = new System.Drawing.Point(262, 198);
            this.firstPassword.Name = "firstPassword";
            this.firstPassword.Size = new System.Drawing.Size(215, 23);
            this.firstPassword.TabIndex = 5;
            // 
            // registerButton
            // 
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
            this.secondPassword.Location = new System.Drawing.Point(262, 227);
            this.secondPassword.Name = "secondPassword";
            this.secondPassword.Size = new System.Drawing.Size(215, 23);
            this.secondPassword.TabIndex = 7;
            // 
            // confirmText
            // 
            this.confirmText.AutoSize = true;
            this.confirmText.Location = new System.Drawing.Point(170, 230);
            this.confirmText.Name = "confirmText";
            this.confirmText.Size = new System.Drawing.Size(86, 15);
            this.confirmText.TabIndex = 8;
            this.confirmText.Text = "Potvrzení hesla";
            // 
            // checkBoxPodminky
            // 
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
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(417, 257);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 15);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBoxPodminky);
            this.Controls.Add(this.confirmText);
            this.Controls.Add(this.secondPassword);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.firstPassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainText);
            this.Name = "RegisterPage";
            this.Text = "RegisterPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MainText;
        private PictureBox pictureBox1;
        private Label name;
        private Label password;
        private TextBox textBox1;
        private TextBox firstPassword;
        private Button registerButton;
        private TextBox secondPassword;
        private Label confirmText;
        private CheckBox checkBoxPodminky;
        private LinkLabel linkLabel1;
    }
}