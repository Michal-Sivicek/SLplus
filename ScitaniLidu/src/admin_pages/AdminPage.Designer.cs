namespace ScitaniLidu
{
    partial class AdminPage
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
            panel1 = new Panel();
            vypisBytu = new MaterialSkin.Controls.MaterialFlatButton();
            vypisDomu = new MaterialSkin.Controls.MaterialFlatButton();
            vypisObyvatelstva = new MaterialSkin.Controls.MaterialFlatButton();
            panel3 = new Panel();
            labelPanel = new Label();
            panel2 = new Panel();
            materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(vypisBytu);
            panel1.Controls.Add(vypisDomu);
            panel1.Controls.Add(vypisObyvatelstva);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 388);
            panel1.TabIndex = 0;
            // 
            // vypisBytu
            // 
            vypisBytu.AutoSize = true;
            vypisBytu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            vypisBytu.Depth = 0;
            vypisBytu.Location = new Point(47, 268);
            vypisBytu.Margin = new Padding(4, 6, 4, 6);
            vypisBytu.MouseState = MaterialSkin.MouseState.HOVER;
            vypisBytu.Name = "vypisBytu";
            vypisBytu.Primary = false;
            vypisBytu.Size = new Size(88, 36);
            vypisBytu.TabIndex = 3;
            vypisBytu.Text = "Výpis bytů";
            vypisBytu.UseVisualStyleBackColor = true;
            vypisBytu.Click += vypisBytu_Click;
            // 
            // vypisDomu
            // 
            vypisDomu.AutoSize = true;
            vypisDomu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            vypisDomu.Depth = 0;
            vypisDomu.Location = new Point(42, 197);
            vypisDomu.Margin = new Padding(4, 6, 4, 6);
            vypisDomu.MouseState = MaterialSkin.MouseState.HOVER;
            vypisDomu.Name = "vypisDomu";
            vypisDomu.Primary = false;
            vypisDomu.Size = new Size(93, 36);
            vypisDomu.TabIndex = 2;
            vypisDomu.Text = "Výpis domů";
            vypisDomu.UseVisualStyleBackColor = true;
            vypisDomu.Click += vypisDomu_Click;
            // 
            // vypisObyvatelstva
            // 
            vypisObyvatelstva.AutoSize = true;
            vypisObyvatelstva.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            vypisObyvatelstva.Depth = 0;
            vypisObyvatelstva.Location = new Point(13, 125);
            vypisObyvatelstva.Margin = new Padding(4, 6, 4, 6);
            vypisObyvatelstva.MouseState = MaterialSkin.MouseState.HOVER;
            vypisObyvatelstva.Name = "vypisObyvatelstva";
            vypisObyvatelstva.Primary = false;
            vypisObyvatelstva.Size = new Size(156, 36);
            vypisObyvatelstva.TabIndex = 1;
            vypisObyvatelstva.Text = "Výpis obyvatelstva";
            vypisObyvatelstva.UseVisualStyleBackColor = true;
            vypisObyvatelstva.Click += vypisObyvatelstva_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Controls.Add(labelPanel);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 84);
            panel3.TabIndex = 0;
            // 
            // labelPanel
            // 
            labelPanel.AutoSize = true;
            labelPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPanel.Location = new Point(21, 31);
            labelPanel.Name = "labelPanel";
            labelPanel.Size = new Size(143, 21);
            labelPanel.TabIndex = 0;
            labelPanel.Text = "Vyberte si možnost";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Location = new Point(179, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(623, 388);
            panel2.TabIndex = 1;
            // 
            // materialFlatButton1
            // 
            materialFlatButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            materialFlatButton1.AutoSize = true;
            materialFlatButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialFlatButton1.Depth = 0;
            materialFlatButton1.Location = new Point(701, 27);
            materialFlatButton1.Margin = new Padding(4, 6, 4, 6);
            materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFlatButton1.Name = "materialFlatButton1";
            materialFlatButton1.Primary = false;
            materialFlatButton1.Size = new Size(97, 36);
            materialFlatButton1.TabIndex = 2;
            materialFlatButton1.Text = "Odhlásit se";
            materialFlatButton1.UseVisualStyleBackColor = true;
            materialFlatButton1.Click += materialFlatButton1_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(materialFlatButton1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminPage";
            Text = "AdminPage";
            FormClosing += AdminPage_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label labelPanel;
        private MaterialSkin.Controls.MaterialFlatButton vypisBytu;
        private MaterialSkin.Controls.MaterialFlatButton vypisDomu;
        private MaterialSkin.Controls.MaterialFlatButton vypisObyvatelstva;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}