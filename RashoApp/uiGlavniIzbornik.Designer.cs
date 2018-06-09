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
            this.uiTabControlProizvodi = new System.Windows.Forms.TabControl();
            this.uiTabProizvodiDio = new System.Windows.Forms.TabPage();
            this.uiTabProizvodiElement = new System.Windows.Forms.TabPage();
            this.uiTabProizvodiKomponenta = new System.Windows.Forms.TabPage();
            this.uiTabProizvodiProizvod = new System.Windows.Forms.TabPage();
            this.uiTabProizvodiUlogaDijela = new System.Windows.Forms.TabPage();
            this.Narudžbe = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Dnevnik = new System.Windows.Forms.TabPage();
            this.Korisnici = new System.Windows.Forms.TabPage();
            this.uiTabControl.SuspendLayout();
            this.Proizvodi.SuspendLayout();
            this.uiTabControlProizvodi.SuspendLayout();
            this.Narudžbe.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.Proizvodi.Controls.Add(this.uiTabControlProizvodi);
            this.Proizvodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Proizvodi.Location = new System.Drawing.Point(124, 4);
            this.Proizvodi.Margin = new System.Windows.Forms.Padding(0);
            this.Proizvodi.Name = "Proizvodi";
            this.Proizvodi.Size = new System.Drawing.Size(944, 598);
            this.Proizvodi.TabIndex = 0;
            this.Proizvodi.Text = "Proizvodi";
            // 
            // uiTabControlProizvodi
            // 
            this.uiTabControlProizvodi.Controls.Add(this.uiTabProizvodiDio);
            this.uiTabControlProizvodi.Controls.Add(this.uiTabProizvodiElement);
            this.uiTabControlProizvodi.Controls.Add(this.uiTabProizvodiKomponenta);
            this.uiTabControlProizvodi.Controls.Add(this.uiTabProizvodiProizvod);
            this.uiTabControlProizvodi.Controls.Add(this.uiTabProizvodiUlogaDijela);
            this.uiTabControlProizvodi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControlProizvodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiTabControlProizvodi.ItemSize = new System.Drawing.Size(60, 40);
            this.uiTabControlProizvodi.Location = new System.Drawing.Point(0, 0);
            this.uiTabControlProizvodi.Margin = new System.Windows.Forms.Padding(0);
            this.uiTabControlProizvodi.Name = "uiTabControlProizvodi";
            this.uiTabControlProizvodi.Padding = new System.Drawing.Point(0, 0);
            this.uiTabControlProizvodi.SelectedIndex = 0;
            this.uiTabControlProizvodi.Size = new System.Drawing.Size(942, 596);
            this.uiTabControlProizvodi.TabIndex = 0;
            // 
            // uiTabProizvodiDio
            // 
            this.uiTabProizvodiDio.AutoScroll = true;
            this.uiTabProizvodiDio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiTabProizvodiDio.Location = new System.Drawing.Point(4, 44);
            this.uiTabProizvodiDio.Margin = new System.Windows.Forms.Padding(0);
            this.uiTabProizvodiDio.Name = "uiTabProizvodiDio";
            this.uiTabProizvodiDio.Size = new System.Drawing.Size(934, 548);
            this.uiTabProizvodiDio.TabIndex = 0;
            this.uiTabProizvodiDio.Text = "Dio";
            this.uiTabProizvodiDio.UseVisualStyleBackColor = true;
            // 
            // uiTabProizvodiElement
            // 
            this.uiTabProizvodiElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiTabProizvodiElement.Location = new System.Drawing.Point(4, 44);
            this.uiTabProizvodiElement.Margin = new System.Windows.Forms.Padding(0);
            this.uiTabProizvodiElement.Name = "uiTabProizvodiElement";
            this.uiTabProizvodiElement.Size = new System.Drawing.Size(934, 548);
            this.uiTabProizvodiElement.TabIndex = 1;
            this.uiTabProizvodiElement.Text = "Element";
            this.uiTabProizvodiElement.UseVisualStyleBackColor = true;
            // 
            // uiTabProizvodiKomponenta
            // 
            this.uiTabProizvodiKomponenta.Location = new System.Drawing.Point(4, 44);
            this.uiTabProizvodiKomponenta.Margin = new System.Windows.Forms.Padding(0);
            this.uiTabProizvodiKomponenta.Name = "uiTabProizvodiKomponenta";
            this.uiTabProizvodiKomponenta.Size = new System.Drawing.Size(934, 548);
            this.uiTabProizvodiKomponenta.TabIndex = 2;
            this.uiTabProizvodiKomponenta.Text = "Komponenta";
            this.uiTabProizvodiKomponenta.UseVisualStyleBackColor = true;
            // 
            // uiTabProizvodiProizvod
            // 
            this.uiTabProizvodiProizvod.Location = new System.Drawing.Point(4, 44);
            this.uiTabProizvodiProizvod.Margin = new System.Windows.Forms.Padding(0);
            this.uiTabProizvodiProizvod.Name = "uiTabProizvodiProizvod";
            this.uiTabProizvodiProizvod.Size = new System.Drawing.Size(934, 548);
            this.uiTabProizvodiProizvod.TabIndex = 3;
            this.uiTabProizvodiProizvod.Text = "Proizvod";
            this.uiTabProizvodiProizvod.UseVisualStyleBackColor = true;
            // 
            // uiTabProizvodiUlogaDijela
            // 
            this.uiTabProizvodiUlogaDijela.Location = new System.Drawing.Point(4, 44);
            this.uiTabProizvodiUlogaDijela.Margin = new System.Windows.Forms.Padding(0);
            this.uiTabProizvodiUlogaDijela.Name = "uiTabProizvodiUlogaDijela";
            this.uiTabProizvodiUlogaDijela.Size = new System.Drawing.Size(934, 548);
            this.uiTabProizvodiUlogaDijela.TabIndex = 4;
            this.uiTabProizvodiUlogaDijela.Text = "Uloga dijela";
            this.uiTabProizvodiUlogaDijela.UseVisualStyleBackColor = true;
            // 
            // Narudžbe
            // 
            this.Narudžbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Narudžbe.Controls.Add(this.tabControl1);
            this.Narudžbe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Narudžbe.Location = new System.Drawing.Point(124, 4);
            this.Narudžbe.Margin = new System.Windows.Forms.Padding(0);
            this.Narudžbe.Name = "Narudžbe";
            this.Narudžbe.Size = new System.Drawing.Size(944, 598);
            this.Narudžbe.TabIndex = 1;
            this.Narudžbe.Text = "Narudžbe";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(944, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(936, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 606);
            this.Controls.Add(this.uiTabControl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 300);
            this.Name = "uiGlavniIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uiGlavniIzbornik";
            this.SizeChanged += new System.EventHandler(this.uiGlavniIzbornik_SizeChanged);
            this.uiTabControl.ResumeLayout(false);
            this.Proizvodi.ResumeLayout(false);
            this.uiTabControlProizvodi.ResumeLayout(false);
            this.Narudžbe.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Proizvodi;
        private System.Windows.Forms.TabPage Narudžbe;
        private System.Windows.Forms.TabPage Dnevnik;
        private System.Windows.Forms.TabPage Korisnici;
        private System.Windows.Forms.TabControl uiTabControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl uiTabControlProizvodi;
        private System.Windows.Forms.TabPage uiTabProizvodiDio;
        private System.Windows.Forms.TabPage uiTabProizvodiElement;
        private System.Windows.Forms.TabPage uiTabProizvodiKomponenta;
        private System.Windows.Forms.TabPage uiTabProizvodiProizvod;
        private System.Windows.Forms.TabPage uiTabProizvodiUlogaDijela;
    }
}