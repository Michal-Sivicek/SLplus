namespace ScitaniLidu
{
    partial class Contact
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
            this.richTextBoxZprava = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.predmet = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxZprava
            // 
            this.richTextBoxZprava.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBoxZprava.Location = new System.Drawing.Point(256, 84);
            this.richTextBoxZprava.Name = "richTextBoxZprava";
            this.richTextBoxZprava.Size = new System.Drawing.Size(405, 239);
            this.richTextBoxZprava.TabIndex = 0;
            this.richTextBoxZprava.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(586, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "odeslat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vaše zpráva";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSubject.Location = new System.Drawing.Point(256, 55);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(405, 23);
            this.textBoxSubject.TabIndex = 5;
            // 
            // predmet
            // 
            this.predmet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.predmet.AutoSize = true;
            this.predmet.Location = new System.Drawing.Point(198, 58);
            this.predmet.Name = "predmet";
            this.predmet.Size = new System.Drawing.Size(52, 15);
            this.predmet.TabIndex = 6;
            this.predmet.Text = "Předmět";
            // 
            // labelText
            // 
            this.labelText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelText.Location = new System.Drawing.Point(159, 9);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(537, 32);
            this.labelText.TabIndex = 7;
            this.labelText.Text = "Pokud máte požadavek, můžete se na nás obrátit";
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.predmet);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxZprava);
            this.Name = "Contact";
            this.Text = "Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBoxZprava;
        private Button button1;
        private Label label1;
        private TextBox textBoxSubject;
        private Label predmet;
        private Label labelText;
    }
}