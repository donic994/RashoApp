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
            System.Windows.Forms.Label uiLabelKomponentaKolicina;
            System.Windows.Forms.Label uiLabelKomponentaBoja;
            System.Windows.Forms.Label uiLabelKomponentaKantiranost;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiDodajDjeloveUProizvod));
            this.uiActionDalje = new System.Windows.Forms.Button();
            this.uiInputUlogaID = new System.Windows.Forms.TextBox();
            this.ulogaDijelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.uiOutputUlogaNaziv = new System.Windows.Forms.TextBox();
            this.uiInputDioNaziv = new System.Windows.Forms.TextBox();
            this.dioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiInputDioDužina = new System.Windows.Forms.TextBox();
            this.uiInputDioŠirina = new System.Windows.Forms.TextBox();
            this.uiInputDioDebljina = new System.Windows.Forms.TextBox();
            this.uiInputDioSlika = new System.Windows.Forms.TextBox();
            this.uiInputDioMaterijal = new System.Windows.Forms.TextBox();
            this.uiInputOdabirTipaUnosaDijela = new System.Windows.Forms.ComboBox();
            this.uiActionOdaberiUloga = new System.Windows.Forms.Button();
            this.uiInputDioID = new System.Windows.Forms.TextBox();
            this.uiOutputDioNaziv = new System.Windows.Forms.TextBox();
            this.uiInputKomponentaKolicina = new System.Windows.Forms.TextBox();
            this.komponentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiInputKomponentaBoja = new System.Windows.Forms.TextBox();
            this.uiInputKomponentaKantiranost = new System.Windows.Forms.TextBox();
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.uiActionOdaberiPostojećiDio = new System.Windows.Forms.Button();
            this.ulogaDijelaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.dioTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.DioTableAdapter();
            this.komponentaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter();
            this.pogledDjelovaPoProoizvoduBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pogledDjelovaPoProoizvoduTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.PogledDjelovaPoProoizvoduTableAdapter();
            this.pogledDjelovaPoProoizvoduDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiLabelDioNaziv = new System.Windows.Forms.Label();
            this.uiLabelDioDuzina = new System.Windows.Forms.Label();
            this.uiLabelDioSirina = new System.Windows.Forms.Label();
            this.uiLabelDioDebljina = new System.Windows.Forms.Label();
            this.uiLabelDioSlika = new System.Windows.Forms.Label();
            this.uiLabelDioMaterijal = new System.Windows.Forms.Label();
            this.uiLabelOdabraniDioNaziv = new System.Windows.Forms.Label();
            this.uiLabelOdabraniDioID = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            uiLabelKomponentaKolicina = new System.Windows.Forms.Label();
            uiLabelKomponentaBoja = new System.Windows.Forms.Label();
            uiLabelKomponentaKantiranost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogledDjelovaPoProoizvoduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogledDjelovaPoProoizvoduDataGridView)).BeginInit();
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
            // uiLabelKomponentaKolicina
            // 
            uiLabelKomponentaKolicina.AutoSize = true;
            uiLabelKomponentaKolicina.Location = new System.Drawing.Point(260, 165);
            uiLabelKomponentaKolicina.Name = "uiLabelKomponentaKolicina";
            uiLabelKomponentaKolicina.Size = new System.Drawing.Size(64, 18);
            uiLabelKomponentaKolicina.TabIndex = 25;
            uiLabelKomponentaKolicina.Text = "Količina:";
            // 
            // uiLabelKomponentaBoja
            // 
            uiLabelKomponentaBoja.AutoSize = true;
            uiLabelKomponentaBoja.Location = new System.Drawing.Point(282, 195);
            uiLabelKomponentaBoja.Name = "uiLabelKomponentaBoja";
            uiLabelKomponentaBoja.Size = new System.Drawing.Size(42, 18);
            uiLabelKomponentaBoja.TabIndex = 26;
            uiLabelKomponentaBoja.Text = "Boja:";
            // 
            // uiLabelKomponentaKantiranost
            // 
            uiLabelKomponentaKantiranost.AutoSize = true;
            uiLabelKomponentaKantiranost.Location = new System.Drawing.Point(237, 225);
            uiLabelKomponentaKantiranost.Name = "uiLabelKomponentaKantiranost";
            uiLabelKomponentaKantiranost.Size = new System.Drawing.Size(87, 18);
            uiLabelKomponentaKantiranost.TabIndex = 27;
            uiLabelKomponentaKantiranost.Text = "Kantiranost:";
            // 
            // uiActionDalje
            // 
            this.uiActionDalje.BackColor = System.Drawing.Color.DarkTurquoise;
            this.uiActionDalje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDalje.ForeColor = System.Drawing.Color.White;
            this.uiActionDalje.Location = new System.Drawing.Point(385, 519);
            this.uiActionDalje.Name = "uiActionDalje";
            this.uiActionDalje.Size = new System.Drawing.Size(135, 51);
            this.uiActionDalje.TabIndex = 12;
            this.uiActionDalje.Text = "DALJE";
            this.uiActionDalje.UseVisualStyleBackColor = false;
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
            // ulogaDijelaBindingSource
            // 
            this.ulogaDijelaBindingSource.DataMember = "UlogaDijela";
            this.ulogaDijelaBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // uiInputDioNaziv
            // 
            this.uiInputDioNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "naziv", true));
            this.uiInputDioNaziv.Location = new System.Drawing.Point(94, 162);
            this.uiInputDioNaziv.Name = "uiInputDioNaziv";
            this.uiInputDioNaziv.Size = new System.Drawing.Size(100, 24);
            this.uiInputDioNaziv.TabIndex = 16;
            this.uiInputDioNaziv.Visible = false;
            // 
            // dioBindingSource
            // 
            this.dioBindingSource.DataMember = "Dio";
            this.dioBindingSource.DataSource = this.baza18043_DBDataSet;
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
            // uiInputKomponentaKolicina
            // 
            this.uiInputKomponentaKolicina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "kolicina", true));
            this.uiInputKomponentaKolicina.Location = new System.Drawing.Point(330, 162);
            this.uiInputKomponentaKolicina.Name = "uiInputKomponentaKolicina";
            this.uiInputKomponentaKolicina.Size = new System.Drawing.Size(100, 24);
            this.uiInputKomponentaKolicina.TabIndex = 26;
            // 
            // komponentaBindingSource
            // 
            this.komponentaBindingSource.DataMember = "Komponenta";
            this.komponentaBindingSource.DataSource = this.baza18043_DBDataSet;
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
            this.uiActionOdaberiPostojećiDio.Visible = false;
            this.uiActionOdaberiPostojećiDio.Click += new System.EventHandler(this.uiActionOdaberiPostojećiDio_Click);
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
            // komponentaTableAdapter
            // 
            this.komponentaTableAdapter.ClearBeforeFill = true;
            // 
            // pogledDjelovaPoProoizvoduBindingSource
            // 
            this.pogledDjelovaPoProoizvoduBindingSource.DataMember = "PogledDjelovaPoProoizvodu";
            this.pogledDjelovaPoProoizvoduBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // pogledDjelovaPoProoizvoduTableAdapter
            // 
            this.pogledDjelovaPoProoizvoduTableAdapter.ClearBeforeFill = true;
            // 
            // pogledDjelovaPoProoizvoduDataGridView
            // 
            this.pogledDjelovaPoProoizvoduDataGridView.AutoGenerateColumns = false;
            this.pogledDjelovaPoProoizvoduDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.pogledDjelovaPoProoizvoduDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pogledDjelovaPoProoizvoduDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.pogledDjelovaPoProoizvoduDataGridView.DataSource = this.pogledDjelovaPoProoizvoduBindingSource;
            this.pogledDjelovaPoProoizvoduDataGridView.Location = new System.Drawing.Point(0, 342);
            this.pogledDjelovaPoProoizvoduDataGridView.Name = "pogledDjelovaPoProoizvoduDataGridView";
            this.pogledDjelovaPoProoizvoduDataGridView.ReadOnly = true;
            this.pogledDjelovaPoProoizvoduDataGridView.RowHeadersVisible = false;
            this.pogledDjelovaPoProoizvoduDataGridView.RowTemplate.Height = 24;
            this.pogledDjelovaPoProoizvoduDataGridView.Size = new System.Drawing.Size(539, 243);
            this.pogledDjelovaPoProoizvoduDataGridView.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Duljina";
            this.dataGridViewTextBoxColumn2.HeaderText = "Duljina";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Širina";
            this.dataGridViewTextBoxColumn3.HeaderText = "Širina";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Visina";
            this.dataGridViewTextBoxColumn4.HeaderText = "Visina";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Slika";
            this.dataGridViewTextBoxColumn5.HeaderText = "Slika";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Materijal";
            this.dataGridViewTextBoxColumn6.HeaderText = "Materijal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Uloga";
            this.dataGridViewTextBoxColumn7.HeaderText = "Uloga";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Količina";
            this.dataGridViewTextBoxColumn8.HeaderText = "Količina";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Boja";
            this.dataGridViewTextBoxColumn9.HeaderText = "Boja";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Kantiranost";
            this.dataGridViewTextBoxColumn10.HeaderText = "Kantiranost";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // uiLabelDioNaziv
            // 
            this.uiLabelDioNaziv.AutoSize = true;
            this.uiLabelDioNaziv.Location = new System.Drawing.Point(39, 165);
            this.uiLabelDioNaziv.Name = "uiLabelDioNaziv";
            this.uiLabelDioNaziv.Size = new System.Drawing.Size(49, 18);
            this.uiLabelDioNaziv.TabIndex = 32;
            this.uiLabelDioNaziv.Text = "Naziv:";
            // 
            // uiLabelDioDuzina
            // 
            this.uiLabelDioDuzina.AutoSize = true;
            this.uiLabelDioDuzina.Location = new System.Drawing.Point(30, 195);
            this.uiLabelDioDuzina.Name = "uiLabelDioDuzina";
            this.uiLabelDioDuzina.Size = new System.Drawing.Size(58, 18);
            this.uiLabelDioDuzina.TabIndex = 33;
            this.uiLabelDioDuzina.Text = "Dužina:";
            // 
            // uiLabelDioSirina
            // 
            this.uiLabelDioSirina.AutoSize = true;
            this.uiLabelDioSirina.Location = new System.Drawing.Point(39, 225);
            this.uiLabelDioSirina.Name = "uiLabelDioSirina";
            this.uiLabelDioSirina.Size = new System.Drawing.Size(49, 18);
            this.uiLabelDioSirina.TabIndex = 34;
            this.uiLabelDioSirina.Text = "Širina:";
            // 
            // uiLabelDioDebljina
            // 
            this.uiLabelDioDebljina.AutoSize = true;
            this.uiLabelDioDebljina.Location = new System.Drawing.Point(24, 255);
            this.uiLabelDioDebljina.Name = "uiLabelDioDebljina";
            this.uiLabelDioDebljina.Size = new System.Drawing.Size(64, 18);
            this.uiLabelDioDebljina.TabIndex = 35;
            this.uiLabelDioDebljina.Text = "Debljina:";
            // 
            // uiLabelDioSlika
            // 
            this.uiLabelDioSlika.AutoSize = true;
            this.uiLabelDioSlika.Location = new System.Drawing.Point(44, 285);
            this.uiLabelDioSlika.Name = "uiLabelDioSlika";
            this.uiLabelDioSlika.Size = new System.Drawing.Size(44, 18);
            this.uiLabelDioSlika.TabIndex = 36;
            this.uiLabelDioSlika.Text = "Slika:";
            // 
            // uiLabelDioMaterijal
            // 
            this.uiLabelDioMaterijal.AutoSize = true;
            this.uiLabelDioMaterijal.Location = new System.Drawing.Point(21, 315);
            this.uiLabelDioMaterijal.Name = "uiLabelDioMaterijal";
            this.uiLabelDioMaterijal.Size = new System.Drawing.Size(67, 18);
            this.uiLabelDioMaterijal.TabIndex = 37;
            this.uiLabelDioMaterijal.Text = "Materijal:";
            // 
            // uiLabelOdabraniDioNaziv
            // 
            this.uiLabelOdabraniDioNaziv.AutoSize = true;
            this.uiLabelOdabraniDioNaziv.Location = new System.Drawing.Point(275, 60);
            this.uiLabelOdabraniDioNaziv.Name = "uiLabelOdabraniDioNaziv";
            this.uiLabelOdabraniDioNaziv.Size = new System.Drawing.Size(49, 18);
            this.uiLabelOdabraniDioNaziv.TabIndex = 38;
            this.uiLabelOdabraniDioNaziv.Text = "Naziv:";
            // 
            // uiLabelOdabraniDioID
            // 
            this.uiLabelOdabraniDioID.AutoSize = true;
            this.uiLabelOdabraniDioID.Location = new System.Drawing.Point(298, 30);
            this.uiLabelOdabraniDioID.Name = "uiLabelOdabraniDioID";
            this.uiLabelOdabraniDioID.Size = new System.Drawing.Size(26, 18);
            this.uiLabelOdabraniDioID.TabIndex = 39;
            this.uiLabelOdabraniDioID.Text = "ID:";
            // 
            // uiDodajDjeloveUProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 582);
            this.Controls.Add(this.uiLabelOdabraniDioID);
            this.Controls.Add(this.uiLabelOdabraniDioNaziv);
            this.Controls.Add(this.uiLabelDioMaterijal);
            this.Controls.Add(this.uiLabelDioSlika);
            this.Controls.Add(this.uiLabelDioDebljina);
            this.Controls.Add(this.uiLabelDioSirina);
            this.Controls.Add(this.uiLabelDioDuzina);
            this.Controls.Add(this.uiLabelDioNaziv);
            this.Controls.Add(this.uiActionOdaberiPostojećiDio);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(uiLabelKomponentaKantiranost);
            this.Controls.Add(this.uiInputKomponentaKantiranost);
            this.Controls.Add(uiLabelKomponentaBoja);
            this.Controls.Add(this.uiInputKomponentaBoja);
            this.Controls.Add(uiLabelKomponentaKolicina);
            this.Controls.Add(this.uiInputKomponentaKolicina);
            this.Controls.Add(this.uiOutputDioNaziv);
            this.Controls.Add(this.uiInputDioID);
            this.Controls.Add(this.uiActionOdaberiUloga);
            this.Controls.Add(this.uiInputOdabirTipaUnosaDijela);
            this.Controls.Add(this.uiInputDioMaterijal);
            this.Controls.Add(this.uiInputDioSlika);
            this.Controls.Add(this.uiInputDioDebljina);
            this.Controls.Add(this.uiInputDioŠirina);
            this.Controls.Add(this.uiInputDioDužina);
            this.Controls.Add(this.uiInputDioNaziv);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.uiOutputUlogaNaziv);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.uiInputUlogaID);
            this.Controls.Add(this.uiActionDalje);
            this.Controls.Add(this.pogledDjelovaPoProoizvoduDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uiDodajDjeloveUProizvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj dio u proizvod";
            this.Load += new System.EventHandler(this.uiDodajDjeloveUProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogledDjelovaPoProoizvoduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogledDjelovaPoProoizvoduDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource pogledDjelovaPoProoizvoduBindingSource;
        private Baza18043_DBDataSetTableAdapters.PogledDjelovaPoProoizvoduTableAdapter pogledDjelovaPoProoizvoduTableAdapter;
        private System.Windows.Forms.DataGridView pogledDjelovaPoProoizvoduDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label uiLabelDioNaziv;
        private System.Windows.Forms.Label uiLabelDioDuzina;
        private System.Windows.Forms.Label uiLabelDioSirina;
        private System.Windows.Forms.Label uiLabelDioDebljina;
        private System.Windows.Forms.Label uiLabelDioSlika;
        private System.Windows.Forms.Label uiLabelDioMaterijal;
        private System.Windows.Forms.Label uiLabelOdabraniDioNaziv;
        private System.Windows.Forms.Label uiLabelOdabraniDioID;
    }
}