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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonDomuABytu = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonObyvatelstvo = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelMenu.Controls.Add(this.buttonDomuABytu);
            this.panelMenu.Controls.Add(this.buttonObyvatelstvo);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Location = new System.Drawing.Point(0, 63);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 387);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonDomuABytu
            // 
            this.buttonDomuABytu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDomuABytu.AutoSize = true;
            this.buttonDomuABytu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDomuABytu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDomuABytu.Depth = 0;
            this.buttonDomuABytu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDomuABytu.Location = new System.Drawing.Point(10, 165);
            this.buttonDomuABytu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDomuABytu.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDomuABytu.Name = "buttonDomuABytu";
            this.buttonDomuABytu.Primary = false;
            this.buttonDomuABytu.Size = new System.Drawing.Size(157, 36);
            this.buttonDomuABytu.TabIndex = 2;
            this.buttonDomuABytu.Text = "Sčítání Domů a Bytů";
            this.buttonDomuABytu.UseVisualStyleBackColor = false;
            // 
            // buttonObyvatelstvo
            // 
            this.buttonObyvatelstvo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonObyvatelstvo.AutoSize = true;
            this.buttonObyvatelstvo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonObyvatelstvo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonObyvatelstvo.Depth = 0;
            this.buttonObyvatelstvo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonObyvatelstvo.Location = new System.Drawing.Point(10, 77);
            this.buttonObyvatelstvo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonObyvatelstvo.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonObyvatelstvo.Name = "buttonObyvatelstvo";
            this.buttonObyvatelstvo.Primary = false;
            this.buttonObyvatelstvo.Size = new System.Drawing.Size(170, 36);
            this.buttonObyvatelstvo.TabIndex = 1;
            this.buttonObyvatelstvo.Text = "Sčítání Obyvatelstva";
            this.buttonObyvatelstvo.UseVisualStyleBackColor = false;
            this.buttonObyvatelstvo.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 77);
            this.panel1.TabIndex = 0;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(690, 26);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(97, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "Odhlásit se";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click_1);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainPage";
            this.Text = "Scitani Lidu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMenu;
        private MaterialSkin.Controls.MaterialFlatButton buttonObyvatelstvo;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton buttonDomuABytu;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}