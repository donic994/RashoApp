namespace RashoApp
{
    partial class uiGlavniIzbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiGlavniIzbornik));
            this.uiTabControl = new System.Windows.Forms.TabControl();
            this.Proizvodi = new System.Windows.Forms.TabPage();
            this.Narudžbe = new System.Windows.Forms.TabPage();
            this.Dnevnik = new System.Windows.Forms.TabPage();
            this.Korisnici = new System.Windows.Forms.TabPage();
            this.uiTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControl
            // 
            this.uiTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControl.AllowDrop = true;
            this.uiTabControl.Controls.Add(this.Proizvodi);
            this.uiTabControl.Controls.Add(this.Narudžbe);
            this.uiTabControl.Controls.Add(this.Dnevnik);
            this.uiTabControl.Controls.Add(this.Korisnici);
            this.uiTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiTabControl.ItemSize = new System.Drawing.Size(50, 120);
            this.uiTabControl.Location = new System.Drawing.Point(0, 0);
            this.uiTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.uiTabControl.Multiline = true;
            this.uiTabControl.Name = "uiTabControl";
            this.uiTabControl.Padding = new System.Drawing.Point(0, 0);
            this.uiTabControl.SelectedIndex = 0;
            this.uiTabControl.Size = new System.Drawing.Size(1072, 606);
            this.uiTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl.TabIndex = 0;
            this.uiTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.uiTabControl_DrawItem);
            this.uiTabControl.SelectedIndexChanged += new System.EventHandler(this.uiTabControl_SelectedIndexChanged);
            // 
            // Proizvodi
            // 
            this.Proizvodi.AllowDrop = true;
            this.Proizvodi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Proizvodi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Proizvodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Proizvodi.Location = new System.Drawing.Point(124, 4);
            this.Proizvodi.Margin = new System.Windows.Forms.Padding(0);
            this.Proizvodi.Name = "Proizvodi";
            this.Proizvodi.Size = new System.Drawing.Size(944, 598);
            this.Proizvodi.TabIndex = 0;
            this.Proizvodi.Text = "Proizvodi";
            // 
            // Narudžbe
            // 
            this.Narudžbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Narudžbe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Narudžbe.Location = new System.Drawing.Point(124, 4);
            this.Narudžbe.Margin = new System.Windows.Forms.Padding(0);
            this.Narudžbe.Name = "Narudžbe";
            this.Narudžbe.Size = new System.Drawing.Size(944, 598);
            this.Narudžbe.TabIndex = 1;
            this.Narudžbe.Text = "Narudžbe";
            // 
            // Dnevnik
            // 
            this.Dnevnik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(48)))));
            this.Dnevnik.Location = new System.Drawing.Point(124, 4);
            this.Dnevnik.Margin = new System.Windows.Forms.Padding(0);
            this.Dnevnik.Name = "Dnevnik";
            this.Dnevnik.Size = new System.Drawing.Size(944, 598);
            this.Dnevnik.TabIndex = 2;
            this.Dnevnik.Text = "Dnevnik";
            // 
            // Korisnici
            // 
            this.Korisnici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.Korisnici.Location = new System.Drawing.Point(124, 4);
            this.Korisnici.Margin = new System.Windows.Forms.Padding(0);
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Size = new System.Drawing.Size(944, 598);
            this.Korisnici.TabIndex = 3;
            this.Korisnici.Text = "Korisnici";
            // 
            // uiGlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 606);
            this.Controls.Add(this.uiTabControl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uiGlavniIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uiGlavniIzbornik";
            this.uiTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Proizvodi;
        private System.Windows.Forms.TabPage Narudžbe;
        private System.Windows.Forms.TabPage Dnevnik;
        private System.Windows.Forms.TabPage Korisnici;
        private System.Windows.Forms.TabControl uiTabControl;
    }
}