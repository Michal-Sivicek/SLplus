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
            dataGridView1 = new DataGridView();
            buttonVypisBytu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(194, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(433, 280);
            dataGridView1.TabIndex = 0;
            // 
            // buttonVypisBytu
            // 
            buttonVypisBytu.Anchor = AnchorStyles.Top;
            buttonVypisBytu.Location = new Point(491, 338);
            buttonVypisBytu.Name = "buttonVypisBytu";
            buttonVypisBytu.Size = new Size(136, 38);
            buttonVypisBytu.TabIndex = 1;
            buttonVypisBytu.Text = "Výpis bytů";
            buttonVypisBytu.UseVisualStyleBackColor = true;
            buttonVypisBytu.Click += buttonVypisBytu_Click;
            // 
            // AdminFlatsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVypisBytu);
            Controls.Add(dataGridView1);
            Name = "AdminFlatsPage";
            Text = "AdminFlatsPage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonVypisBytu;
    }
}