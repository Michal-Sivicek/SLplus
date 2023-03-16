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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
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
            this.MainText.Click += new System.EventHandler(this.MainText_Click);
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
            this.name.Click += new System.EventHandler(this.label1_Click);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 23);
            this.textBox2.TabIndex = 5;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(402, 263);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Registrace";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainText);
            this.Name = "RegisterPage";
            this.Text = "RegisterPage";
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
        private TextBox textBox2;
        private Button registerButton;
    }
}