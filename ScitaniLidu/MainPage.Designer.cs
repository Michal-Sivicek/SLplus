namespace ScitaniLidu
{
    partial class MainPage
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
            this.MainText = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainText
            // 
            this.MainText.AutoSize = true;
            this.MainText.Location = new System.Drawing.Point(259, 32);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(246, 15);
            this.MainText.TabIndex = 0;
            this.MainText.Text = "Vítej, pro sečtení prosím vyplň tento formulář";
            this.MainText.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(89, 94);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 15);
            this.name.TabIndex = 1;
            this.name.Text = "jmeno";
            this.name.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 2;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(80, 123);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(51, 15);
            this.lastname.TabIndex = 3;
            this.lastname.Text = "prijmeni";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.TabIndex = 4;
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Location = new System.Drawing.Point(80, 154);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(50, 15);
            this.phoneNumber.TabIndex = 5;
            this.phoneNumber.Text = "tel. číslo";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 23);
            this.textBox3.TabIndex = 6;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.MainText);
            this.Name = "MainPage";
            this.Text = "Scitani Lidu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MainText;
        private Label name;
        private TextBox textBox1;
        private Label lastname;
        private TextBox textBox2;
        private Label phoneNumber;
        private TextBox textBox3;
    }
}