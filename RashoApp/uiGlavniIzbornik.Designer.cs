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
            this.uiTabControl.Controls.Add(this.Proizvodi);
            this.uiTabControl.Controls.Add(this.Narudžbe);
            this.uiTabControl.Controls.Add(this.Dnevnik);
            this.uiTabControl.Controls.Add(this.Korisnici);
            this.uiTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiTabControl.ItemSize = new System.Drawing.Size(90, 30);
            this.uiTabControl.Location = new System.Drawing.Point(0, 0);
            this.uiTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.uiTabControl.Name = "uiTabControl";
            this.uiTabControl.Padding = new System.Drawing.Point(0, 0);
            this.uiTabControl.SelectedIndex = 0;
            this.uiTabControl.Size = new System.Drawing.Size(830, 500);
            this.uiTabControl.TabIndex = 0;
            // 
            // Proizvodi
            // 
            this.Proizvodi.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.Proizvodi.Location = new System.Drawing.Point(4, 34);
            this.Proizvodi.Margin = new System.Windows.Forms.Padding(0);
            this.Proizvodi.Name = "Proizvodi";
            this.Proizvodi.Size = new System.Drawing.Size(822, 462);
            this.Proizvodi.TabIndex = 0;
            this.Proizvodi.Text = "Proizvodi";
            // 
            // Narudžbe
            // 
            this.Narudžbe.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.Narudžbe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Narudžbe.Location = new System.Drawing.Point(4, 34);
            this.Narudžbe.Margin = new System.Windows.Forms.Padding(0);
            this.Narudžbe.Name = "Narudžbe";
            this.Narudžbe.Size = new System.Drawing.Size(822, 462);
            this.Narudžbe.TabIndex = 1;
            this.Narudžbe.Text = "Narudžbe";
            // 
            // Dnevnik
            // 
            this.Dnevnik.BackColor = System.Drawing.Color.FromArgb(254, 211, 48); 
            this.Dnevnik.Location = new System.Drawing.Point(4, 34);
            this.Dnevnik.Margin = new System.Windows.Forms.Padding(0);
            this.Dnevnik.Name = "Dnevnik";
            this.Dnevnik.Size = new System.Drawing.Size(822, 462);
            this.Dnevnik.TabIndex = 2;
            this.Dnevnik.Text = "Dnevnik";
            // 
            // Korisnici
            // 
            this.Korisnici.BackColor = System.Drawing.Color.FromArgb(253, 150, 68);
            this.Korisnici.Location = new System.Drawing.Point(4, 34);
            this.Korisnici.Margin = new System.Windows.Forms.Padding(0);
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Size = new System.Drawing.Size(822, 462);
            this.Korisnici.TabIndex = 3;
            this.Korisnici.Text = "Korisnici";
            // 
            // uiGlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 500);
            this.Controls.Add(this.uiTabControl);
            this.Name = "uiGlavniIzbornik";
            this.Text = "uiGlavniIzbornik";
            this.uiTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl uiTabControl;
        private System.Windows.Forms.TabPage Proizvodi;
        private System.Windows.Forms.TabPage Narudžbe;
        private System.Windows.Forms.TabPage Dnevnik;
        private System.Windows.Forms.TabPage Korisnici;
    }
}