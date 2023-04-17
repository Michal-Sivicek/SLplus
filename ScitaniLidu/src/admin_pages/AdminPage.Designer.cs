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
            this.panel1 = new System.Windows.Forms.Panel();
            this.vypisBytu = new MaterialSkin.Controls.MaterialFlatButton();
            this.vypisDomu = new MaterialSkin.Controls.MaterialFlatButton();
            this.vypisObyvatelstva = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelPanel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.vypisBytu);
            this.panel1.Controls.Add(this.vypisDomu);
            this.panel1.Controls.Add(this.vypisObyvatelstva);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 388);
            this.panel1.TabIndex = 0;
            // 
            // vypisBytu
            // 
            this.vypisBytu.AutoSize = true;
            this.vypisBytu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vypisBytu.Depth = 0;
            this.vypisBytu.Location = new System.Drawing.Point(47, 268);
            this.vypisBytu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.vypisBytu.MouseState = MaterialSkin.MouseState.HOVER;
            this.vypisBytu.Name = "vypisBytu";
            this.vypisBytu.Primary = false;
            this.vypisBytu.Size = new System.Drawing.Size(88, 36);
            this.vypisBytu.TabIndex = 3;
            this.vypisBytu.Text = "Výpis bytů";
            this.vypisBytu.UseVisualStyleBackColor = true;
            this.vypisBytu.Click += new System.EventHandler(this.vypisBytu_Click);
            // 
            // vypisDomu
            // 
            this.vypisDomu.AutoSize = true;
            this.vypisDomu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vypisDomu.Depth = 0;
            this.vypisDomu.Location = new System.Drawing.Point(42, 197);
            this.vypisDomu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.vypisDomu.MouseState = MaterialSkin.MouseState.HOVER;
            this.vypisDomu.Name = "vypisDomu";
            this.vypisDomu.Primary = false;
            this.vypisDomu.Size = new System.Drawing.Size(93, 36);
            this.vypisDomu.TabIndex = 2;
            this.vypisDomu.Text = "Výpis domů";
            this.vypisDomu.UseVisualStyleBackColor = true;
            this.vypisDomu.Click += new System.EventHandler(this.vypisDomu_Click);
            // 
            // vypisObyvatelstva
            // 
            this.vypisObyvatelstva.AutoSize = true;
            this.vypisObyvatelstva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vypisObyvatelstva.Depth = 0;
            this.vypisObyvatelstva.Location = new System.Drawing.Point(7, 121);
            this.vypisObyvatelstva.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.vypisObyvatelstva.MouseState = MaterialSkin.MouseState.HOVER;
            this.vypisObyvatelstva.Name = "vypisObyvatelstva";
            this.vypisObyvatelstva.Primary = false;
            this.vypisObyvatelstva.Size = new System.Drawing.Size(165, 36);
            this.vypisObyvatelstva.TabIndex = 1;
            this.vypisObyvatelstva.Text = "Výpisy obyvatelstva";
            this.vypisObyvatelstva.UseVisualStyleBackColor = true;
            this.vypisObyvatelstva.Click += new System.EventHandler(this.vypisObyvatelstva_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.labelPanel);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 84);
            this.panel3.TabIndex = 0;
            // 
            // labelPanel
            // 
            this.labelPanel.AutoSize = true;
            this.labelPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPanel.Location = new System.Drawing.Point(21, 31);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(143, 21);
            this.labelPanel.TabIndex = 0;
            this.labelPanel.Text = "Vyberte si možnost";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(179, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 388);
            this.panel2.TabIndex = 1;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(701, 27);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(97, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Odhlásit se";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPage_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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