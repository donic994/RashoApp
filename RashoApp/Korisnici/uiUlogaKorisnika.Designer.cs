namespace RashoApp.Korisnici {
    partial class UIUlogaKorisnika {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.uiInputID = new System.Windows.Forms.TextBox();
            this.uiInputNaziv = new System.Windows.Forms.TextBox();
            this.uiInputOpis = new System.Windows.Forms.TextBox();
            this.uiActionPrihvati = new System.Windows.Forms.Button();
            this.uiActionPoništi = new System.Windows.Forms.Button();
            this.uiOznakaID = new System.Windows.Forms.Label();
            this.uiOznakaNaziv = new System.Windows.Forms.Label();
            this.uiOznakaOpis = new System.Windows.Forms.Label();
            this.uiOznakaGreška = new System.Windows.Forms.Label();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // uiInputID
            // 
            this.uiInputID.Enabled = false;
            this.uiInputID.Location = new System.Drawing.Point(162, 44);
            this.uiInputID.Name = "uiInputID";
            this.uiInputID.Size = new System.Drawing.Size(47, 20);
            this.uiInputID.TabIndex = 0;
            // 
            // uiInputNaziv
            // 
            this.helpProvider.SetHelpString(this.uiInputNaziv, "Unesite naziv uloge");
            this.uiInputNaziv.Location = new System.Drawing.Point(162, 70);
            this.uiInputNaziv.Name = "uiInputNaziv";
            this.helpProvider.SetShowHelp(this.uiInputNaziv, true);
            this.uiInputNaziv.Size = new System.Drawing.Size(170, 20);
            this.uiInputNaziv.TabIndex = 1;
            // 
            // uiInputOpis
            // 
            this.helpProvider.SetHelpString(this.uiInputOpis, "Unesite opis uloge");
            this.uiInputOpis.Location = new System.Drawing.Point(162, 96);
            this.uiInputOpis.Multiline = true;
            this.uiInputOpis.Name = "uiInputOpis";
            this.helpProvider.SetShowHelp(this.uiInputOpis, true);
            this.uiInputOpis.Size = new System.Drawing.Size(170, 45);
            this.uiInputOpis.TabIndex = 2;
            // 
            // uiActionPrihvati
            // 
            this.uiActionPrihvati.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionPrihvati.FlatAppearance.BorderSize = 0;
            this.uiActionPrihvati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionPrihvati.ForeColor = System.Drawing.Color.White;
            this.uiActionPrihvati.Location = new System.Drawing.Point(162, 148);
            this.uiActionPrihvati.Name = "uiActionPrihvati";
            this.uiActionPrihvati.Size = new System.Drawing.Size(75, 23);
            this.uiActionPrihvati.TabIndex = 3;
            this.uiActionPrihvati.Text = "Prihvati";
            this.uiActionPrihvati.UseVisualStyleBackColor = false;
            this.uiActionPrihvati.Click += new System.EventHandler(this.uiActionPrihvati_Click);
            // 
            // uiActionPoništi
            // 
            this.uiActionPoništi.BackColor = System.Drawing.Color.Crimson;
            this.uiActionPoništi.FlatAppearance.BorderSize = 0;
            this.uiActionPoništi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionPoništi.ForeColor = System.Drawing.Color.White;
            this.uiActionPoništi.Location = new System.Drawing.Point(257, 147);
            this.uiActionPoništi.Name = "uiActionPoništi";
            this.uiActionPoništi.Size = new System.Drawing.Size(75, 23);
            this.uiActionPoništi.TabIndex = 4;
            this.uiActionPoništi.Text = "Poništi";
            this.uiActionPoništi.UseVisualStyleBackColor = false;
            this.uiActionPoništi.Click += new System.EventHandler(this.uiActionPoništi_Click);
            // 
            // uiOznakaID
            // 
            this.uiOznakaID.AutoSize = true;
            this.uiOznakaID.Location = new System.Drawing.Point(67, 47);
            this.uiOznakaID.Name = "uiOznakaID";
            this.uiOznakaID.Size = new System.Drawing.Size(18, 13);
            this.uiOznakaID.TabIndex = 5;
            this.uiOznakaID.Text = "ID";
            // 
            // uiOznakaNaziv
            // 
            this.uiOznakaNaziv.AutoSize = true;
            this.uiOznakaNaziv.Location = new System.Drawing.Point(67, 73);
            this.uiOznakaNaziv.Name = "uiOznakaNaziv";
            this.uiOznakaNaziv.Size = new System.Drawing.Size(34, 13);
            this.uiOznakaNaziv.TabIndex = 6;
            this.uiOznakaNaziv.Text = "Naziv";
            // 
            // uiOznakaOpis
            // 
            this.uiOznakaOpis.AutoSize = true;
            this.uiOznakaOpis.Location = new System.Drawing.Point(67, 99);
            this.uiOznakaOpis.Name = "uiOznakaOpis";
            this.uiOznakaOpis.Size = new System.Drawing.Size(28, 13);
            this.uiOznakaOpis.TabIndex = 7;
            this.uiOznakaOpis.Text = "Opis";
            // 
            // uiOznakaGreška
            // 
            this.uiOznakaGreška.AutoSize = true;
            this.uiOznakaGreška.ForeColor = System.Drawing.Color.Red;
            this.uiOznakaGreška.Location = new System.Drawing.Point(159, 184);
            this.uiOznakaGreška.Name = "uiOznakaGreška";
            this.uiOznakaGreška.Size = new System.Drawing.Size(0, 13);
            this.uiOznakaGreška.TabIndex = 8;
            // 
            // UIUlogaKorisnika
            // 
            this.AcceptButton = this.uiActionPrihvati;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 225);
            this.Controls.Add(this.uiOznakaGreška);
            this.Controls.Add(this.uiOznakaOpis);
            this.Controls.Add(this.uiOznakaNaziv);
            this.Controls.Add(this.uiOznakaID);
            this.Controls.Add(this.uiActionPoništi);
            this.Controls.Add(this.uiActionPrihvati);
            this.Controls.Add(this.uiInputOpis);
            this.Controls.Add(this.uiInputNaziv);
            this.Controls.Add(this.uiInputID);
            this.Name = "UIUlogaKorisnika";
            this.Text = "Uloga korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiInputID;
        private System.Windows.Forms.TextBox uiInputNaziv;
        private System.Windows.Forms.TextBox uiInputOpis;
        private System.Windows.Forms.Button uiActionPrihvati;
        private System.Windows.Forms.Button uiActionPoništi;
        private System.Windows.Forms.Label uiOznakaID;
        private System.Windows.Forms.Label uiOznakaNaziv;
        private System.Windows.Forms.Label uiOznakaOpis;
        private System.Windows.Forms.Label uiOznakaGreška;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}