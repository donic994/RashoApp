namespace RashoApp.Korisnici {
    partial class UIKorisnik {
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
            this.components = new System.ComponentModel.Container();
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.KorisnikTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.uiInputID = new System.Windows.Forms.TextBox();
            this.uiInputIme = new System.Windows.Forms.TextBox();
            this.uiInputPrezime = new System.Windows.Forms.TextBox();
            this.uiInputAdresa = new System.Windows.Forms.TextBox();
            this.uiInputEmail = new System.Windows.Forms.TextBox();
            this.uiInputKorisničkoIme = new System.Windows.Forms.TextBox();
            this.uiInputLozinka = new System.Windows.Forms.TextBox();
            this.uiInputKontaktBroj = new System.Windows.Forms.TextBox();
            this.uiOznakaID = new System.Windows.Forms.Label();
            this.uiOznakaIme = new System.Windows.Forms.Label();
            this.uiOznakaPrezime = new System.Windows.Forms.Label();
            this.uiOznakaAdresa = new System.Windows.Forms.Label();
            this.uiOznakaKorisničkoIme = new System.Windows.Forms.Label();
            this.uiOznakaLozinka = new System.Windows.Forms.Label();
            this.uiOznakaKontaktBroj = new System.Windows.Forms.Label();
            this.uiOznakaEmail = new System.Windows.Forms.Label();
            this.uiOznakaUloga = new System.Windows.Forms.Label();
            this.uiInputOdabirUloga = new System.Windows.Forms.ComboBox();
            this.ulogaKorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionPrihvati = new System.Windows.Forms.Button();
            this.uiActionPoništi = new System.Windows.Forms.Button();
            this.ulogaKorisnikaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.UlogaKorisnikaTableAdapter();
            this.ulogaKorisnikaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uiOznakaGreška = new System.Windows.Forms.Label();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaKorisnikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaKorisnikaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DioTableAdapter = null;
            this.tableAdapterManager.DobavljacTableAdapter = null;
            this.tableAdapterManager.ElementTableAdapter = null;
            this.tableAdapterManager.KomponentaTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = this.korisnikTableAdapter;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.ProizvodTableAdapter = null;
            this.tableAdapterManager.StavkaNarudzbeTableAdapter = null;
            this.tableAdapterManager.UIElementiTableAdapter = null;
            this.tableAdapterManager.UlogaDijelaTableAdapter = null;
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VidiElementTableAdapter = null;
            // 
            // uiInputID
            // 
            this.uiInputID.Enabled = false;
            this.uiInputID.Location = new System.Drawing.Point(234, 33);
            this.uiInputID.Name = "uiInputID";
            this.uiInputID.Size = new System.Drawing.Size(52, 20);
            this.uiInputID.TabIndex = 0;
            // 
            // uiInputIme
            // 
            this.helpProvider.SetHelpString(this.uiInputIme, "Unesite ime korisnika. Koristite velika i mala slova te znak -");
            this.uiInputIme.Location = new System.Drawing.Point(234, 59);
            this.uiInputIme.Name = "uiInputIme";
            this.helpProvider.SetShowHelp(this.uiInputIme, true);
            this.uiInputIme.Size = new System.Drawing.Size(161, 20);
            this.uiInputIme.TabIndex = 1;
            // 
            // uiInputPrezime
            // 
            this.helpProvider.SetHelpString(this.uiInputPrezime, "Unesite prezime korisnika. Koristite velika i mala slova te znak -");
            this.uiInputPrezime.Location = new System.Drawing.Point(234, 85);
            this.uiInputPrezime.Name = "uiInputPrezime";
            this.helpProvider.SetShowHelp(this.uiInputPrezime, true);
            this.uiInputPrezime.Size = new System.Drawing.Size(161, 20);
            this.uiInputPrezime.TabIndex = 2;
            // 
            // uiInputAdresa
            // 
            this.helpProvider.SetHelpString(this.uiInputAdresa, "Unesite adresu korisnika.");
            this.uiInputAdresa.Location = new System.Drawing.Point(234, 111);
            this.uiInputAdresa.Multiline = true;
            this.uiInputAdresa.Name = "uiInputAdresa";
            this.helpProvider.SetShowHelp(this.uiInputAdresa, true);
            this.uiInputAdresa.Size = new System.Drawing.Size(161, 31);
            this.uiInputAdresa.TabIndex = 3;
            // 
            // uiInputEmail
            // 
            this.helpProvider.SetHelpString(this.uiInputEmail, "Unesite email korisnika.");
            this.uiInputEmail.Location = new System.Drawing.Point(234, 148);
            this.uiInputEmail.Name = "uiInputEmail";
            this.helpProvider.SetShowHelp(this.uiInputEmail, true);
            this.uiInputEmail.Size = new System.Drawing.Size(161, 20);
            this.uiInputEmail.TabIndex = 4;
            // 
            // uiInputKorisničkoIme
            // 
            this.helpProvider.SetHelpString(this.uiInputKorisničkoIme, "Unesite korisničko ime korisnika. Koristite mala slova i brojeve.");
            this.uiInputKorisničkoIme.Location = new System.Drawing.Point(234, 174);
            this.uiInputKorisničkoIme.Name = "uiInputKorisničkoIme";
            this.helpProvider.SetShowHelp(this.uiInputKorisničkoIme, true);
            this.uiInputKorisničkoIme.Size = new System.Drawing.Size(161, 20);
            this.uiInputKorisničkoIme.TabIndex = 5;
            // 
            // uiInputLozinka
            // 
            this.helpProvider.SetHelpString(this.uiInputLozinka, "Unesite lozinku korisnika. Lozinka mora imati 4-20 znakova.");
            this.uiInputLozinka.Location = new System.Drawing.Point(234, 200);
            this.uiInputLozinka.Name = "uiInputLozinka";
            this.uiInputLozinka.PasswordChar = '•';
            this.helpProvider.SetShowHelp(this.uiInputLozinka, true);
            this.uiInputLozinka.Size = new System.Drawing.Size(161, 20);
            this.uiInputLozinka.TabIndex = 6;
            // 
            // uiInputKontaktBroj
            // 
            this.helpProvider.SetHelpString(this.uiInputKontaktBroj, "Unesite kontakt broj korisnika. Dozvoljeno je koristiti znamenke, razmake te znak" +
        "ove -, /, \\");
            this.uiInputKontaktBroj.Location = new System.Drawing.Point(234, 226);
            this.uiInputKontaktBroj.Name = "uiInputKontaktBroj";
            this.helpProvider.SetShowHelp(this.uiInputKontaktBroj, true);
            this.uiInputKontaktBroj.Size = new System.Drawing.Size(161, 20);
            this.uiInputKontaktBroj.TabIndex = 7;
            // 
            // uiOznakaID
            // 
            this.uiOznakaID.AutoSize = true;
            this.uiOznakaID.Location = new System.Drawing.Point(102, 36);
            this.uiOznakaID.Name = "uiOznakaID";
            this.uiOznakaID.Size = new System.Drawing.Size(18, 13);
            this.uiOznakaID.TabIndex = 8;
            this.uiOznakaID.Text = "ID";
            // 
            // uiOznakaIme
            // 
            this.uiOznakaIme.AutoSize = true;
            this.uiOznakaIme.Location = new System.Drawing.Point(102, 62);
            this.uiOznakaIme.Name = "uiOznakaIme";
            this.uiOznakaIme.Size = new System.Drawing.Size(24, 13);
            this.uiOznakaIme.TabIndex = 9;
            this.uiOznakaIme.Text = "Ime";
            // 
            // uiOznakaPrezime
            // 
            this.uiOznakaPrezime.AutoSize = true;
            this.uiOznakaPrezime.Location = new System.Drawing.Point(102, 88);
            this.uiOznakaPrezime.Name = "uiOznakaPrezime";
            this.uiOznakaPrezime.Size = new System.Drawing.Size(44, 13);
            this.uiOznakaPrezime.TabIndex = 10;
            this.uiOznakaPrezime.Text = "Prezime";
            // 
            // uiOznakaAdresa
            // 
            this.uiOznakaAdresa.AutoSize = true;
            this.uiOznakaAdresa.Location = new System.Drawing.Point(102, 114);
            this.uiOznakaAdresa.Name = "uiOznakaAdresa";
            this.uiOznakaAdresa.Size = new System.Drawing.Size(40, 13);
            this.uiOznakaAdresa.TabIndex = 11;
            this.uiOznakaAdresa.Text = "Adresa";
            // 
            // uiOznakaKorisničkoIme
            // 
            this.uiOznakaKorisničkoIme.AutoSize = true;
            this.uiOznakaKorisničkoIme.Location = new System.Drawing.Point(102, 177);
            this.uiOznakaKorisničkoIme.Name = "uiOznakaKorisničkoIme";
            this.uiOznakaKorisničkoIme.Size = new System.Drawing.Size(75, 13);
            this.uiOznakaKorisničkoIme.TabIndex = 12;
            this.uiOznakaKorisničkoIme.Text = "Korisničko ime";
            // 
            // uiOznakaLozinka
            // 
            this.uiOznakaLozinka.AutoSize = true;
            this.uiOznakaLozinka.Location = new System.Drawing.Point(102, 203);
            this.uiOznakaLozinka.Name = "uiOznakaLozinka";
            this.uiOznakaLozinka.Size = new System.Drawing.Size(44, 13);
            this.uiOznakaLozinka.TabIndex = 13;
            this.uiOznakaLozinka.Text = "Lozinka";
            // 
            // uiOznakaKontaktBroj
            // 
            this.uiOznakaKontaktBroj.AutoSize = true;
            this.uiOznakaKontaktBroj.Location = new System.Drawing.Point(102, 229);
            this.uiOznakaKontaktBroj.Name = "uiOznakaKontaktBroj";
            this.uiOznakaKontaktBroj.Size = new System.Drawing.Size(64, 13);
            this.uiOznakaKontaktBroj.TabIndex = 14;
            this.uiOznakaKontaktBroj.Text = "Kontakt broj";
            // 
            // uiOznakaEmail
            // 
            this.uiOznakaEmail.AutoSize = true;
            this.uiOznakaEmail.Location = new System.Drawing.Point(102, 151);
            this.uiOznakaEmail.Name = "uiOznakaEmail";
            this.uiOznakaEmail.Size = new System.Drawing.Size(32, 13);
            this.uiOznakaEmail.TabIndex = 15;
            this.uiOznakaEmail.Text = "Email";
            // 
            // uiOznakaUloga
            // 
            this.uiOznakaUloga.AutoSize = true;
            this.uiOznakaUloga.Location = new System.Drawing.Point(102, 255);
            this.uiOznakaUloga.Name = "uiOznakaUloga";
            this.uiOznakaUloga.Size = new System.Drawing.Size(35, 13);
            this.uiOznakaUloga.TabIndex = 17;
            this.uiOznakaUloga.Text = "Uloga";
            // 
            // uiInputOdabirUloga
            // 
            this.uiInputOdabirUloga.DataSource = this.ulogaKorisnikaBindingSource;
            this.uiInputOdabirUloga.DisplayMember = "naziv";
            this.uiInputOdabirUloga.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.uiInputOdabirUloga, "Odaberite ulogu korisnika");
            this.uiInputOdabirUloga.Location = new System.Drawing.Point(234, 252);
            this.uiInputOdabirUloga.Name = "uiInputOdabirUloga";
            this.helpProvider.SetShowHelp(this.uiInputOdabirUloga, true);
            this.uiInputOdabirUloga.Size = new System.Drawing.Size(161, 21);
            this.uiInputOdabirUloga.TabIndex = 18;
            this.uiInputOdabirUloga.ValueMember = "ID";
            // 
            // ulogaKorisnikaBindingSource
            // 
            this.ulogaKorisnikaBindingSource.DataMember = "UlogaKorisnika";
            this.ulogaKorisnikaBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // uiActionPrihvati
            // 
            this.uiActionPrihvati.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionPrihvati.FlatAppearance.BorderSize = 0;
            this.uiActionPrihvati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionPrihvati.ForeColor = System.Drawing.Color.White;
            this.uiActionPrihvati.Location = new System.Drawing.Point(139, 308);
            this.uiActionPrihvati.Name = "uiActionPrihvati";
            this.uiActionPrihvati.Size = new System.Drawing.Size(75, 23);
            this.uiActionPrihvati.TabIndex = 19;
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
            this.uiActionPoništi.Location = new System.Drawing.Point(257, 308);
            this.uiActionPoništi.Name = "uiActionPoništi";
            this.uiActionPoništi.Size = new System.Drawing.Size(75, 23);
            this.uiActionPoništi.TabIndex = 20;
            this.uiActionPoništi.Text = "Poništi";
            this.uiActionPoništi.UseVisualStyleBackColor = false;
            this.uiActionPoništi.Click += new System.EventHandler(this.uiActionPoništi_Click);
            // 
            // ulogaKorisnikaTableAdapter
            // 
            this.ulogaKorisnikaTableAdapter.ClearBeforeFill = true;
            // 
            // ulogaKorisnikaBindingSource1
            // 
            this.ulogaKorisnikaBindingSource1.DataMember = "UlogaKorisnika";
            this.ulogaKorisnikaBindingSource1.DataSource = this.baza18043_DBDataSet;
            // 
            // uiOznakaGreška
            // 
            this.uiOznakaGreška.AutoSize = true;
            this.uiOznakaGreška.ForeColor = System.Drawing.Color.Red;
            this.uiOznakaGreška.Location = new System.Drawing.Point(107, 282);
            this.uiOznakaGreška.Name = "uiOznakaGreška";
            this.uiOznakaGreška.Size = new System.Drawing.Size(0, 13);
            this.uiOznakaGreška.TabIndex = 21;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notifyIcon1.BalloonTipText = "Hello";
            this.notifyIcon1.BalloonTipTitle = "HelloWorld";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // UIKorisnik
            // 
            this.AcceptButton = this.uiActionPrihvati;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 343);
            this.Controls.Add(this.uiOznakaGreška);
            this.Controls.Add(this.uiActionPoništi);
            this.Controls.Add(this.uiActionPrihvati);
            this.Controls.Add(this.uiInputOdabirUloga);
            this.Controls.Add(this.uiOznakaUloga);
            this.Controls.Add(this.uiOznakaEmail);
            this.Controls.Add(this.uiOznakaKontaktBroj);
            this.Controls.Add(this.uiOznakaLozinka);
            this.Controls.Add(this.uiOznakaKorisničkoIme);
            this.Controls.Add(this.uiOznakaAdresa);
            this.Controls.Add(this.uiOznakaPrezime);
            this.Controls.Add(this.uiOznakaIme);
            this.Controls.Add(this.uiOznakaID);
            this.Controls.Add(this.uiInputKontaktBroj);
            this.Controls.Add(this.uiInputLozinka);
            this.Controls.Add(this.uiInputKorisničkoIme);
            this.Controls.Add(this.uiInputEmail);
            this.Controls.Add(this.uiInputAdresa);
            this.Controls.Add(this.uiInputPrezime);
            this.Controls.Add(this.uiInputIme);
            this.Controls.Add(this.uiInputID);
            this.HelpButton = true;
            this.helpProvider.SetHelpString(this, "Unesite prezime korisnika");
            this.Name = "UIKorisnik";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Korisnik";
            this.Load += new System.EventHandler(this.uiKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaKorisnikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaKorisnikaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private Baza18043_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox uiInputID;
        private System.Windows.Forms.TextBox uiInputIme;
        private System.Windows.Forms.TextBox uiInputPrezime;
        private System.Windows.Forms.TextBox uiInputAdresa;
        private System.Windows.Forms.TextBox uiInputEmail;
        private System.Windows.Forms.TextBox uiInputKorisničkoIme;
        private System.Windows.Forms.TextBox uiInputLozinka;
        private System.Windows.Forms.TextBox uiInputKontaktBroj;
        private System.Windows.Forms.Label uiOznakaID;
        private System.Windows.Forms.Label uiOznakaIme;
        private System.Windows.Forms.Label uiOznakaPrezime;
        private System.Windows.Forms.Label uiOznakaAdresa;
        private System.Windows.Forms.Label uiOznakaKorisničkoIme;
        private System.Windows.Forms.Label uiOznakaLozinka;
        private System.Windows.Forms.Label uiOznakaKontaktBroj;
        private System.Windows.Forms.Label uiOznakaEmail;
        private System.Windows.Forms.Label uiOznakaUloga;
        private System.Windows.Forms.ComboBox uiInputOdabirUloga;
        private System.Windows.Forms.Button uiActionPrihvati;
        private System.Windows.Forms.Button uiActionPoništi;
        private System.Windows.Forms.BindingSource ulogaKorisnikaBindingSource;
        private Baza18043_DBDataSetTableAdapters.UlogaKorisnikaTableAdapter ulogaKorisnikaTableAdapter;
        private System.Windows.Forms.BindingSource ulogaKorisnikaBindingSource1;
        private System.Windows.Forms.Label uiOznakaGreška;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}