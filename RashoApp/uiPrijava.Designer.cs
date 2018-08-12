namespace RashoApp
{
    partial class UIPrijava
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
            this.uiOznakaLozinka = new System.Windows.Forms.Label();
            this.uiOznakaKorisničkoIme = new System.Windows.Forms.Label();
            this.uiInputLozinka = new System.Windows.Forms.TextBox();
            this.uiInputKorisničkoIme = new System.Windows.Forms.TextBox();
            this.uiAkcijaPrijaviSe = new System.Windows.Forms.Button();
            this.uiOznakaGreškaUPrijavi = new System.Windows.Forms.Label();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // uiOznakaLozinka
            // 
            this.uiOznakaLozinka.AutoSize = true;
            this.uiOznakaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiOznakaLozinka.Location = new System.Drawing.Point(139, 72);
            this.uiOznakaLozinka.Name = "uiOznakaLozinka";
            this.uiOznakaLozinka.Size = new System.Drawing.Size(68, 20);
            this.uiOznakaLozinka.TabIndex = 10;
            this.uiOznakaLozinka.Text = "Lozinka:";
            // 
            // uiOznakaKorisničkoIme
            // 
            this.uiOznakaKorisničkoIme.AutoSize = true;
            this.uiOznakaKorisničkoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiOznakaKorisničkoIme.Location = new System.Drawing.Point(93, 46);
            this.uiOznakaKorisničkoIme.Name = "uiOznakaKorisničkoIme";
            this.uiOznakaKorisničkoIme.Size = new System.Drawing.Size(114, 20);
            this.uiOznakaKorisničkoIme.TabIndex = 9;
            this.uiOznakaKorisničkoIme.Text = "Korisničko ime:";
            // 
            // uiInputLozinka
            // 
            this.helpProvider.SetHelpString(this.uiInputLozinka, "Unesite svoju lozinku");
            this.uiInputLozinka.Location = new System.Drawing.Point(213, 72);
            this.uiInputLozinka.Name = "uiInputLozinka";
            this.uiInputLozinka.PasswordChar = '•';
            this.helpProvider.SetShowHelp(this.uiInputLozinka, true);
            this.uiInputLozinka.Size = new System.Drawing.Size(188, 20);
            this.uiInputLozinka.TabIndex = 7;
            // 
            // uiInputKorisničkoIme
            // 
            this.helpProvider.SetHelpString(this.uiInputKorisničkoIme, "Unesite svoje korisničko ime");
            this.uiInputKorisničkoIme.Location = new System.Drawing.Point(213, 46);
            this.uiInputKorisničkoIme.Name = "uiInputKorisničkoIme";
            this.helpProvider.SetShowHelp(this.uiInputKorisničkoIme, true);
            this.uiInputKorisničkoIme.Size = new System.Drawing.Size(188, 20);
            this.uiInputKorisničkoIme.TabIndex = 6;
            // 
            // uiAkcijaPrijaviSe
            // 
            this.uiAkcijaPrijaviSe.BackColor = System.Drawing.Color.LimeGreen;
            this.uiAkcijaPrijaviSe.FlatAppearance.BorderSize = 0;
            this.uiAkcijaPrijaviSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiAkcijaPrijaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiAkcijaPrijaviSe.Location = new System.Drawing.Point(298, 121);
            this.uiAkcijaPrijaviSe.Name = "uiAkcijaPrijaviSe";
            this.uiAkcijaPrijaviSe.Size = new System.Drawing.Size(103, 30);
            this.uiAkcijaPrijaviSe.TabIndex = 11;
            this.uiAkcijaPrijaviSe.Text = "Prijavi se";
            this.uiAkcijaPrijaviSe.UseVisualStyleBackColor = false;
            this.uiAkcijaPrijaviSe.Click += new System.EventHandler(this.uiAkcijaPrijaviSe_Click);
            // 
            // uiOznakaGreškaUPrijavi
            // 
            this.uiOznakaGreškaUPrijavi.AutoSize = true;
            this.uiOznakaGreškaUPrijavi.ForeColor = System.Drawing.Color.Red;
            this.uiOznakaGreškaUPrijavi.Location = new System.Drawing.Point(213, 99);
            this.uiOznakaGreškaUPrijavi.Name = "uiOznakaGreškaUPrijavi";
            this.uiOznakaGreškaUPrijavi.Size = new System.Drawing.Size(0, 13);
            this.uiOznakaGreškaUPrijavi.TabIndex = 12;
            // 
            // UIPrijava
            // 
            this.AcceptButton = this.uiAkcijaPrijaviSe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 182);
            this.Controls.Add(this.uiOznakaGreškaUPrijavi);
            this.Controls.Add(this.uiAkcijaPrijaviSe);
            this.Controls.Add(this.uiOznakaLozinka);
            this.Controls.Add(this.uiOznakaKorisničkoIme);
            this.Controls.Add(this.uiInputLozinka);
            this.Controls.Add(this.uiInputKorisničkoIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uiOznakaLozinka;
        private System.Windows.Forms.Label uiOznakaKorisničkoIme;
        private System.Windows.Forms.TextBox uiInputLozinka;
        private System.Windows.Forms.TextBox uiInputKorisničkoIme;
        private System.Windows.Forms.Button uiAkcijaPrijaviSe;
        private System.Windows.Forms.Label uiOznakaGreškaUPrijavi;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}