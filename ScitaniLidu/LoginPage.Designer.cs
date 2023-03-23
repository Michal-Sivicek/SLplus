namespace ScitaniLidu
{
    partial class LoginPage
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
            this.components = new System.ComponentModel.Container();
            this.LoginText = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.UserName = new System.Windows.Forms.Label();
            this.LoginUsername = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.register = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Location = new System.Drawing.Point(302, 51);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(65, 15);
            this.LoginText.TabIndex = 1;
            this.LoginText.Text = "Sčítání lidu";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripComboBox1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(182, 56);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(254, 181);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(42, 15);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Jmeno";
            // 
            // LoginUsername
            // 
            this.LoginUsername.Location = new System.Drawing.Point(302, 178);
            this.LoginUsername.Name = "LoginUsername";
            this.LoginUsername.Size = new System.Drawing.Size(200, 23);
            this.LoginUsername.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(259, 214);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(37, 15);
            this.Password.TabIndex = 4;
            this.Password.Text = "Heslo";
            // 
            // LoginPassword
            // 
            this.LoginPassword.Location = new System.Drawing.Point(302, 211);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(200, 23);
            this.LoginPassword.TabIndex = 5;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(427, 282);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Přihlásit se";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(303, 242);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(92, 19);
            this.ShowPassword.TabIndex = 7;
            this.ShowPassword.Text = "Ukázat heslo";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Location = new System.Drawing.Point(315, 264);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(187, 15);
            this.register.TabIndex = 8;
            this.register.TabStop = true;
            this.register.Text = "Pokud nemáte účet zaregisrujte se";
            this.register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_LinkClicked);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.register);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LoginUsername);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.LoginText);
            this.Name = "LoginPage";
            this.Text = "Sčítání lidu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LoginText;
        private FileSystemWatcher fileSystemWatcher1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripComboBox toolStripComboBox1;
        private Label UserName;
        private TextBox LoginPassword;
        private Label Password;
        private TextBox LoginUsername;
        private Button LoginButton;
        private CheckBox ShowPassword;
        private LinkLabel register;
    }
}