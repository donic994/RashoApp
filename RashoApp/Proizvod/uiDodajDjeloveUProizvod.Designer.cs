namespace RashoApp.Proizvod
{
    partial class uiDodajDjeloveUProizvod
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label uiLabelDioNaziv;
            System.Windows.Forms.Label uiLabelDioDuljina;
            System.Windows.Forms.Label uiLabelDioSirina;
            System.Windows.Forms.Label uiLabelDioDebljina;
            System.Windows.Forms.Label uiLabelDioSlika;
            System.Windows.Forms.Label uiLabelDioMaterijal;
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label nazivLabel1;
            System.Windows.Forms.Label uiLabelKomponentaKolicina;
            System.Windows.Forms.Label uiLabelKomponentaBoja;
            System.Windows.Forms.Label uiLabelKomponentaKantiranost;
            this.uiActionDalje = new System.Windows.Forms.Button();
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.ulogaDijelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ulogaDijelaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.dioTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.DioTableAdapter();
            this.uiInputUlogaID = new System.Windows.Forms.TextBox();
            this.uiOutputUlogaNaziv = new System.Windows.Forms.TextBox();
            this.dioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiInputDioNaziv = new System.Windows.Forms.TextBox();
            this.uiInputDioDužina = new System.Windows.Forms.TextBox();
            this.uiInputDioŠirina = new System.Windows.Forms.TextBox();
            this.uiInputDioDebljina = new System.Windows.Forms.TextBox();
            this.uiInputDioSlika = new System.Windows.Forms.TextBox();
            this.uiInputDioMaterijal = new System.Windows.Forms.TextBox();
            this.uiInputOdabirTipaUnosaDijela = new System.Windows.Forms.ComboBox();
            this.uiActionOdaberiUloga = new System.Windows.Forms.Button();
            this.uiInputDioID = new System.Windows.Forms.TextBox();
            this.uiOutputDioNaziv = new System.Windows.Forms.TextBox();
            this.komponentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komponentaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter();
            this.uiInputKomponentaKolicina = new System.Windows.Forms.TextBox();
            this.uiInputKomponentaBoja = new System.Windows.Forms.TextBox();
            this.uiInputKomponentaKantiranost = new System.Windows.Forms.TextBox();
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.uiActionOdaberiPostojećiDio = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            uiLabelDioNaziv = new System.Windows.Forms.Label();
            uiLabelDioDuljina = new System.Windows.Forms.Label();
            uiLabelDioSirina = new System.Windows.Forms.Label();
            uiLabelDioDebljina = new System.Windows.Forms.Label();
            uiLabelDioSlika = new System.Windows.Forms.Label();
            uiLabelDioMaterijal = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            nazivLabel1 = new System.Windows.Forms.Label();
            uiLabelKomponentaKolicina = new System.Windows.Forms.Label();
            uiLabelKomponentaBoja = new System.Windows.Forms.Label();
            uiLabelKomponentaKantiranost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(62, 30);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(26, 18);
            iDLabel.TabIndex = 13;
            iDLabel.Text = "ID:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(37, 59);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(51, 18);
            nazivLabel.TabIndex = 14;
            nazivLabel.Text = "Uloga:";
            // 
            // uiLabelDioNaziv
            // 
            uiLabelDioNaziv.AutoSize = true;
            uiLabelDioNaziv.Location = new System.Drawing.Point(42, 165);
            uiLabelDioNaziv.Name = "uiLabelDioNaziv";
            uiLabelDioNaziv.Size = new System.Drawing.Size(46, 18);
            uiLabelDioNaziv.TabIndex = 15;
            uiLabelDioNaziv.Text = "naziv:";
            // 
            // uiLabelDioDuljina
            // 
            uiLabelDioDuljina.AutoSize = true;
            uiLabelDioDuljina.Location = new System.Drawing.Point(35, 195);
            uiLabelDioDuljina.Name = "uiLabelDioDuljina";
            uiLabelDioDuljina.Size = new System.Drawing.Size(53, 18);
            uiLabelDioDuljina.TabIndex = 16;
            uiLabelDioDuljina.Text = "duljina:";
            // 
            // uiLabelDioSirina
            // 
            uiLabelDioSirina.AutoSize = true;
            uiLabelDioSirina.Location = new System.Drawing.Point(41, 225);
            uiLabelDioSirina.Name = "uiLabelDioSirina";
            uiLabelDioSirina.Size = new System.Drawing.Size(47, 18);
            uiLabelDioSirina.TabIndex = 17;
            uiLabelDioSirina.Text = "sirina:";
            // 
            // uiLabelDioDebljina
            // 
            uiLabelDioDebljina.AutoSize = true;
            uiLabelDioDebljina.Location = new System.Drawing.Point(24, 255);
            uiLabelDioDebljina.Name = "uiLabelDioDebljina";
            uiLabelDioDebljina.Size = new System.Drawing.Size(64, 18);
            uiLabelDioDebljina.TabIndex = 18;
            uiLabelDioDebljina.Text = "Debljina:";
            // 
            // uiLabelDioSlika
            // 
            uiLabelDioSlika.AutoSize = true;
            uiLabelDioSlika.Location = new System.Drawing.Point(46, 285);
            uiLabelDioSlika.Name = "uiLabelDioSlika";
            uiLabelDioSlika.Size = new System.Drawing.Size(42, 18);
            uiLabelDioSlika.TabIndex = 19;
            uiLabelDioSlika.Text = "slika:";
            // 
            // uiLabelDioMaterijal
            // 
            uiLabelDioMaterijal.AutoSize = true;
            uiLabelDioMaterijal.Location = new System.Drawing.Point(21, 315);
            uiLabelDioMaterijal.Name = "uiLabelDioMaterijal";
            uiLabelDioMaterijal.Size = new System.Drawing.Size(67, 18);
            uiLabelDioMaterijal.TabIndex = 20;
            uiLabelDioMaterijal.Text = "materijal:";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(298, 30);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(26, 18);
            iDLabel1.TabIndex = 23;
            iDLabel1.Text = "ID:";
            // 
            // nazivLabel1
            // 
            nazivLabel1.AutoSize = true;
            nazivLabel1.Location = new System.Drawing.Point(289, 60);
            nazivLabel1.Name = "nazivLabel1";
            nazivLabel1.Size = new System.Drawing.Size(35, 18);
            nazivLabel1.TabIndex = 24;
            nazivLabel1.Text = "Dio:";
            // 
            // uiLabelKomponentaKolicina
            // 
            uiLabelKomponentaKolicina.AutoSize = true;
            uiLabelKomponentaKolicina.Location = new System.Drawing.Point(262, 165);
            uiLabelKomponentaKolicina.Name = "uiLabelKomponentaKolicina";
            uiLabelKomponentaKolicina.Size = new System.Drawing.Size(62, 18);
            uiLabelKomponentaKolicina.TabIndex = 25;
            uiLabelKomponentaKolicina.Text = "kolicina:";
            // 
            // uiLabelKomponentaBoja
            // 
            uiLabelKomponentaBoja.AutoSize = true;
            uiLabelKomponentaBoja.Location = new System.Drawing.Point(284, 195);
            uiLabelKomponentaBoja.Name = "uiLabelKomponentaBoja";
            uiLabelKomponentaBoja.Size = new System.Drawing.Size(40, 18);
            uiLabelKomponentaBoja.TabIndex = 26;
            uiLabelKomponentaBoja.Text = "boja:";
            // 
            // uiLabelKomponentaKantiranost
            // 
            uiLabelKomponentaKantiranost.AutoSize = true;
            uiLabelKomponentaKantiranost.Location = new System.Drawing.Point(239, 225);
            uiLabelKomponentaKantiranost.Name = "uiLabelKomponentaKantiranost";
            uiLabelKomponentaKantiranost.Size = new System.Drawing.Size(85, 18);
            uiLabelKomponentaKantiranost.TabIndex = 27;
            uiLabelKomponentaKantiranost.Text = "kantiranost:";
            // 
            // uiActionDalje
            // 
            this.uiActionDalje.BackColor = System.Drawing.Color.DarkTurquoise;
            this.uiActionDalje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDalje.ForeColor = System.Drawing.Color.White;
            this.uiActionDalje.Location = new System.Drawing.Point(385, 510);
            this.uiActionDalje.Name = "uiActionDalje";
            this.uiActionDalje.Size = new System.Drawing.Size(135, 51);
            this.uiActionDalje.TabIndex = 12;
            this.uiActionDalje.Text = "DALJE";
            this.uiActionDalje.UseVisualStyleBackColor = false;
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ulogaDijelaBindingSource
            // 
            this.ulogaDijelaBindingSource.DataMember = "UlogaDijela";
            this.ulogaDijelaBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // ulogaDijelaTableAdapter
            // 
            this.ulogaDijelaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DioTableAdapter = this.dioTableAdapter;
            this.tableAdapterManager.DobavljacTableAdapter = null;
            this.tableAdapterManager.ElementTableAdapter = null;
            this.tableAdapterManager.KomponentaTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.ProizvodTableAdapter = null;
            this.tableAdapterManager.StavkaNarudzbeTableAdapter = null;
            this.tableAdapterManager.UlogaDijelaTableAdapter = this.ulogaDijelaTableAdapter;
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dioTableAdapter
            // 
            this.dioTableAdapter.ClearBeforeFill = true;
            // 
            // uiInputUlogaID
            // 
            this.uiInputUlogaID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ulogaDijelaBindingSource, "ID", true));
            this.uiInputUlogaID.Location = new System.Drawing.Point(94, 27);
            this.uiInputUlogaID.Name = "uiInputUlogaID";
            this.uiInputUlogaID.ReadOnly = true;
            this.uiInputUlogaID.Size = new System.Drawing.Size(100, 24);
            this.uiInputUlogaID.TabIndex = 14;
            // 
            // uiOutputUlogaNaziv
            // 
            this.uiOutputUlogaNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ulogaDijelaBindingSource, "naziv", true));
            this.uiOutputUlogaNaziv.Location = new System.Drawing.Point(94, 57);
            this.uiOutputUlogaNaziv.Name = "uiOutputUlogaNaziv";
            this.uiOutputUlogaNaziv.ReadOnly = true;
            this.uiOutputUlogaNaziv.Size = new System.Drawing.Size(100, 24);
            this.uiOutputUlogaNaziv.TabIndex = 15;
            // 
            // dioBindingSource
            // 
            this.dioBindingSource.DataMember = "Dio";
            this.dioBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // uiInputDioNaziv
            // 
            this.uiInputDioNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "naziv", true));
            this.uiInputDioNaziv.Location = new System.Drawing.Point(94, 162);
            this.uiInputDioNaziv.Name = "uiInputDioNaziv";
            this.uiInputDioNaziv.Size = new System.Drawing.Size(100, 24);
            this.uiInputDioNaziv.TabIndex = 16;
            this.uiInputDioNaziv.Visible = false;
            // 
            // uiInputDioDužina
            // 
            this.uiInputDioDužina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "duljina", true));
            this.uiInputDioDužina.Location = new System.Drawing.Point(94, 192);
            this.uiInputDioDužina.Name = "uiInputDioDužina";
            this.uiInputDioDužina.Size = new System.Drawing.Size(100, 24);
            this.uiInputDioDužina.TabIndex = 17;
            this.uiInputDioDužina.Visible = false;
            // 
            // uiInputDioŠirina
            // 
            this.uiInputDioŠirina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "sirina", true));
            this.uiInputDioŠirina.Location = new System.Drawing.Point(94, 222);
            this.uiInputDioŠirina.Name = "uiInputDioŠirina";
            this.uiInputDioŠirina.Size = new System.Drawing.Size(100, 24);
            this.uiInputDioŠirina.TabIndex = 18;
            this.uiInputDioŠirina.Visible = false;
            // 
            // uiInputDioDebljina
            // 
            this.uiInputDioDebljina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "visina", true));
            this.uiInputDioDebljina.Location = new System.Drawing.Point(94, 252);
            this.uiInputDioDebljina.Name = "uiInputDioDebljina";
            this.uiInputDioDebljina.Size = new System.Drawing.Size(100, 24);
            this.uiInputDioDebljina.TabIndex = 19;
            this.uiInputDioDebljina.Visible = false;
            // 
            // uiInputDioSlika
            // 
            this.uiInputDioSlika.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "slika", true));
            this.uiInputDioSlika.Location = new System.Drawing.Point(94, 282);
            this.uiInputDioSlika.Name = "uiInputDioSlika";
            this.uiInputDioSlika.Size = new System.Drawing.Size(100, 24);
            this.uiInputDioSlika.TabIndex = 20;
            this.uiInputDioSlika.Visible = false;
            // 
            // uiInputDioMaterijal
            // 
            this.uiInputDioMaterijal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "materijal", true));
            this.uiInputDioMaterijal.Location = new System.Drawing.Point(94, 312);
            this.uiInputDioMaterijal.Name = "uiInputDioMaterijal";
            this.uiInputDioMaterijal.Size = new System.Drawing.Size(100, 24);
            this.uiInputDioMaterijal.TabIndex = 21;
            this.uiInputDioMaterijal.Visible = false;
            // 
            // uiInputOdabirTipaUnosaDijela
            // 
            this.uiInputOdabirTipaUnosaDijela.FormattingEnabled = true;
            this.uiInputOdabirTipaUnosaDijela.Items.AddRange(new object[] {
            "Kreiraj novi dio",
            "Odaberi postojeći dio"});
            this.uiInputOdabirTipaUnosaDijela.Location = new System.Drawing.Point(45, 104);
            this.uiInputOdabirTipaUnosaDijela.Name = "uiInputOdabirTipaUnosaDijela";
            this.uiInputOdabirTipaUnosaDijela.Size = new System.Drawing.Size(149, 26);
            this.uiInputOdabirTipaUnosaDijela.TabIndex = 22;
            this.uiInputOdabirTipaUnosaDijela.Visible = false;
            this.uiInputOdabirTipaUnosaDijela.SelectedIndexChanged += new System.EventHandler(this.uiInputOdabirTipaUnosaDijela_SelectedIndexChanged);
            // 
            // uiActionOdaberiUloga
            // 
            this.uiActionOdaberiUloga.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionOdaberiUloga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionOdaberiUloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdaberiUloga.ForeColor = System.Drawing.Color.White;
            this.uiActionOdaberiUloga.Location = new System.Drawing.Point(197, 57);
            this.uiActionOdaberiUloga.Margin = new System.Windows.Forms.Padding(0);
            this.uiActionOdaberiUloga.Name = "uiActionOdaberiUloga";
            this.uiActionOdaberiUloga.Size = new System.Drawing.Size(30, 24);
            this.uiActionOdaberiUloga.TabIndex = 23;
            this.uiActionOdaberiUloga.Text = "+";
            this.uiActionOdaberiUloga.UseVisualStyleBackColor = false;
            this.uiActionOdaberiUloga.Click += new System.EventHandler(this.uiActionOdaberiUloga_Click);
            // 
            // uiInputDioID
            // 
            this.uiInputDioID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "ID", true));
            this.uiInputDioID.Location = new System.Drawing.Point(330, 27);
            this.uiInputDioID.Name = "uiInputDioID";
            this.uiInputDioID.ReadOnly = true;
            this.uiInputDioID.Size = new System.Drawing.Size(100, 24);
            this.uiInputDioID.TabIndex = 24;
            this.uiInputDioID.Visible = false;
            // 
            // uiOutputDioNaziv
            // 
            this.uiOutputDioNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "naziv", true));
            this.uiOutputDioNaziv.Location = new System.Drawing.Point(330, 57);
            this.uiOutputDioNaziv.Name = "uiOutputDioNaziv";
            this.uiOutputDioNaziv.ReadOnly = true;
            this.uiOutputDioNaziv.Size = new System.Drawing.Size(100, 24);
            this.uiOutputDioNaziv.TabIndex = 25;
            this.uiOutputDioNaziv.Visible = false;
            // 
            // komponentaBindingSource
            // 
            this.komponentaBindingSource.DataMember = "Komponenta";
            this.komponentaBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // komponentaTableAdapter
            // 
            this.komponentaTableAdapter.ClearBeforeFill = true;
            // 
            // uiInputKomponentaKolicina
            // 
            this.uiInputKomponentaKolicina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "kolicina", true));
            this.uiInputKomponentaKolicina.Location = new System.Drawing.Point(330, 162);
            this.uiInputKomponentaKolicina.Name = "uiInputKomponentaKolicina";
            this.uiInputKomponentaKolicina.Size = new System.Drawing.Size(100, 24);
            this.uiInputKomponentaKolicina.TabIndex = 26;
            // 
            // uiInputKomponentaBoja
            // 
            this.uiInputKomponentaBoja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "boja", true));
            this.uiInputKomponentaBoja.Location = new System.Drawing.Point(330, 192);
            this.uiInputKomponentaBoja.Name = "uiInputKomponentaBoja";
            this.uiInputKomponentaBoja.Size = new System.Drawing.Size(100, 24);
            this.uiInputKomponentaBoja.TabIndex = 27;
            // 
            // uiInputKomponentaKantiranost
            // 
            this.uiInputKomponentaKantiranost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "kantiranost", true));
            this.uiInputKomponentaKantiranost.Location = new System.Drawing.Point(330, 222);
            this.uiInputKomponentaKantiranost.Name = "uiInputKomponentaKantiranost";
            this.uiInputKomponentaKantiranost.Size = new System.Drawing.Size(100, 24);
            this.uiInputKomponentaKantiranost.TabIndex = 28;
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodaj.ForeColor = System.Drawing.Color.White;
            this.uiActionDodaj.Location = new System.Drawing.Point(385, 282);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(135, 51);
            this.uiActionDodaj.TabIndex = 29;
            this.uiActionDodaj.Text = "DODAJ";
            this.uiActionDodaj.UseVisualStyleBackColor = false;
            this.uiActionDodaj.Click += new System.EventHandler(this.uiActionDodaj_Click);
            // 
            // uiActionOdaberiPostojećiDio
            // 
            this.uiActionOdaberiPostojećiDio.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionOdaberiPostojećiDio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionOdaberiPostojećiDio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdaberiPostojećiDio.ForeColor = System.Drawing.Color.White;
            this.uiActionOdaberiPostojećiDio.Location = new System.Drawing.Point(433, 57);
            this.uiActionOdaberiPostojećiDio.Margin = new System.Windows.Forms.Padding(0);
            this.uiActionOdaberiPostojećiDio.Name = "uiActionOdaberiPostojećiDio";
            this.uiActionOdaberiPostojećiDio.Size = new System.Drawing.Size(30, 24);
            this.uiActionOdaberiPostojećiDio.TabIndex = 30;
            this.uiActionOdaberiPostojećiDio.Text = "+";
            this.uiActionOdaberiPostojećiDio.UseVisualStyleBackColor = false;
            this.uiActionOdaberiPostojećiDio.Click += new System.EventHandler(this.uiActionOdaberiPostojećiDio_Click);
            // 
            // uiDodajDjeloveUProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 573);
            this.Controls.Add(this.uiActionOdaberiPostojećiDio);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(uiLabelKomponentaKantiranost);
            this.Controls.Add(this.uiInputKomponentaKantiranost);
            this.Controls.Add(uiLabelKomponentaBoja);
            this.Controls.Add(this.uiInputKomponentaBoja);
            this.Controls.Add(uiLabelKomponentaKolicina);
            this.Controls.Add(this.uiInputKomponentaKolicina);
            this.Controls.Add(nazivLabel1);
            this.Controls.Add(this.uiOutputDioNaziv);
            this.Controls.Add(iDLabel1);
            this.Controls.Add(this.uiInputDioID);
            this.Controls.Add(this.uiActionOdaberiUloga);
            this.Controls.Add(this.uiInputOdabirTipaUnosaDijela);
            this.Controls.Add(uiLabelDioMaterijal);
            this.Controls.Add(this.uiInputDioMaterijal);
            this.Controls.Add(uiLabelDioSlika);
            this.Controls.Add(this.uiInputDioSlika);
            this.Controls.Add(uiLabelDioDebljina);
            this.Controls.Add(this.uiInputDioDebljina);
            this.Controls.Add(uiLabelDioSirina);
            this.Controls.Add(this.uiInputDioŠirina);
            this.Controls.Add(uiLabelDioDuljina);
            this.Controls.Add(this.uiInputDioDužina);
            this.Controls.Add(uiLabelDioNaziv);
            this.Controls.Add(this.uiInputDioNaziv);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.uiOutputUlogaNaziv);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.uiInputUlogaID);
            this.Controls.Add(this.uiActionDalje);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "uiDodajDjeloveUProizvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uiDodajDjeloveUProizvod";
            this.Load += new System.EventHandler(this.uiDodajDjeloveUProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionDalje;
        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource ulogaDijelaBindingSource;
        private Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter ulogaDijelaTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Baza18043_DBDataSetTableAdapters.DioTableAdapter dioTableAdapter;
        private System.Windows.Forms.TextBox uiInputUlogaID;
        private System.Windows.Forms.TextBox uiOutputUlogaNaziv;
        private System.Windows.Forms.BindingSource dioBindingSource;
        private System.Windows.Forms.TextBox uiInputDioNaziv;
        private System.Windows.Forms.TextBox uiInputDioDužina;
        private System.Windows.Forms.TextBox uiInputDioŠirina;
        private System.Windows.Forms.TextBox uiInputDioDebljina;
        private System.Windows.Forms.TextBox uiInputDioSlika;
        private System.Windows.Forms.TextBox uiInputDioMaterijal;
        private System.Windows.Forms.ComboBox uiInputOdabirTipaUnosaDijela;
        private System.Windows.Forms.Button uiActionOdaberiUloga;
        private System.Windows.Forms.TextBox uiInputDioID;
        private System.Windows.Forms.TextBox uiOutputDioNaziv;
        private System.Windows.Forms.BindingSource komponentaBindingSource;
        private Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter komponentaTableAdapter;
        private System.Windows.Forms.TextBox uiInputKomponentaKolicina;
        private System.Windows.Forms.TextBox uiInputKomponentaBoja;
        private System.Windows.Forms.TextBox uiInputKomponentaKantiranost;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.Button uiActionOdaberiPostojećiDio;
    }
}