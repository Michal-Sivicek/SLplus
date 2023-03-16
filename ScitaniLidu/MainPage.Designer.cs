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
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainText);
            this.Name = "MainPage";
            this.Text = "Scitani Lidu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MainText;
    }
}