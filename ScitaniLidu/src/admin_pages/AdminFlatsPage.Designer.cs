namespace ScitaniLidu
{
    partial class AdminFlatsPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonVypisBytu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(158, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(473, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonVypisBytu
            // 
            this.buttonVypisBytu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonVypisBytu.Location = new System.Drawing.Point(472, 345);
            this.buttonVypisBytu.Name = "buttonVypisBytu";
            this.buttonVypisBytu.Size = new System.Drawing.Size(159, 38);
            this.buttonVypisBytu.TabIndex = 1;
            this.buttonVypisBytu.Text = "Výpis bytů";
            this.buttonVypisBytu.UseVisualStyleBackColor = true;
            this.buttonVypisBytu.Click += new System.EventHandler(this.buttonVypisBytu_Click);
            // 
            // AdminFlatsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVypisBytu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminFlatsPage";
            this.Text = "AdminFlatsPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonVypisBytu;
    }
}