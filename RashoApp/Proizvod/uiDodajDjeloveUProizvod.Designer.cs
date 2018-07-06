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
            this.uiOutputDataTableDioUProizvodu = new System.Windows.Forms.DataGridView();
            this.dioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulogaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duljinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.širinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.količinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kantiranostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pogledDjelovaPoProoizvoduBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiLabelDioNaziv = new System.Windows.Forms.Label();
            this.uiLabelDioDuzina = new System.Windows.Forms.Label();
            this.uiLabelDioSirina = new System.Windows.Forms.Label();
            this.uiLabelDioDebljina = new System.Windows.Forms.Label();
            this.uiLabelDioMaterijal = new System.Windows.Forms.Label();
            this.uiLabelOdabraniDioNaziv = new System.Windows.Forms.Label();
            this.uiLabelOdabraniDioID = new System.Windows.Forms.Label();
            this.uiActionObrišiDio = new System.Windows.Forms.Button();
            this.pogledDjelovaPoProoizvoduTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.PogledDjelovaPoProoizvoduTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            uiLabelKomponentaKolicina = new System.Windows.Forms.Label();
            uiLabelKomponentaBoja = new System.Windows.Forms.Label();
            uiLabelKomponentaKantiranost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDataTableDioUProizvodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogledDjelovaPoProoizvoduBindingSource)).BeginInit();
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
            this.uiActionDalje.Location = new System.Drawing.Point(521, 255);
            this.uiActionDalje.Name = "uiActionDalje";
            this.uiActionDalje.Size = new System.Drawing.Size(135, 51);
            this.uiActionDalje.TabIndex = 12;
            this.uiActionDalje.Text = "DALJE";
            this.uiActionDalje.UseVisualStyleBackColor = false;
            this.uiActionDalje.Click += new System.EventHandler(this.uiActionDalje_Click);
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
            // uiInputDioMaterijal
            // 
            this.uiInputDioMaterijal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "materijal", true));
            this.uiInputDioMaterijal.Location = new System.Drawing.Point(94, 282);
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
            this.uiActionDodaj.Location = new System.Drawing.Point(239, 255);
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
            // uiOutputDataTableDioUProizvodu
            // 
            this.uiOutputDataTableDioUProizvodu.AllowUserToAddRows = false;
            this.uiOutputDataTableDioUProizvodu.AllowUserToDeleteRows = false;
            this.uiOutputDataTableDioUProizvodu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiOutputDataTableDioUProizvodu.AutoGenerateColumns = false;
            this.uiOutputDataTableDioUProizvodu.BackgroundColor = System.Drawing.Color.White;
            this.uiOutputDataTableDioUProizvodu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputDataTableDioUProizvodu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dioIDDataGridViewTextBoxColumn,
            this.ulogaIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.duljinaDataGridViewTextBoxColumn,
            this.širinaDataGridViewTextBoxColumn,
            this.visinaDataGridViewTextBoxColumn,
            this.količinaDataGridViewTextBoxColumn,
            this.materijalDataGridViewTextBoxColumn,
            this.kantiranostDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.ulogaDataGridViewTextBoxColumn,
            this.slikaDataGridViewTextBoxColumn});
            this.uiOutputDataTableDioUProizvodu.DataSource = this.pogledDjelovaPoProoizvoduBindingSource;
            this.uiOutputDataTableDioUProizvodu.Location = new System.Drawing.Point(0, 325);
            this.uiOutputDataTableDioUProizvodu.Name = "uiOutputDataTableDioUProizvodu";
            this.uiOutputDataTableDioUProizvodu.ReadOnly = true;
            this.uiOutputDataTableDioUProizvodu.RowHeadersVisible = false;
            this.uiOutputDataTableDioUProizvodu.RowTemplate.Height = 24;
            this.uiOutputDataTableDioUProizvodu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputDataTableDioUProizvodu.Size = new System.Drawing.Size(667, 260);
            this.uiOutputDataTableDioUProizvodu.TabIndex = 31;
            // 
            // dioIDDataGridViewTextBoxColumn
            // 
            this.dioIDDataGridViewTextBoxColumn.DataPropertyName = "DioID";
            this.dioIDDataGridViewTextBoxColumn.HeaderText = "DioID";
            this.dioIDDataGridViewTextBoxColumn.Name = "dioIDDataGridViewTextBoxColumn";
            this.dioIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dioIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ulogaIDDataGridViewTextBoxColumn
            // 
            this.ulogaIDDataGridViewTextBoxColumn.DataPropertyName = "UlogaID";
            this.ulogaIDDataGridViewTextBoxColumn.HeaderText = "UlogaID";
            this.ulogaIDDataGridViewTextBoxColumn.Name = "ulogaIDDataGridViewTextBoxColumn";
            this.ulogaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ulogaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duljinaDataGridViewTextBoxColumn
            // 
            this.duljinaDataGridViewTextBoxColumn.DataPropertyName = "Duljina";
            this.duljinaDataGridViewTextBoxColumn.HeaderText = "Dužina";
            this.duljinaDataGridViewTextBoxColumn.Name = "duljinaDataGridViewTextBoxColumn";
            this.duljinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // širinaDataGridViewTextBoxColumn
            // 
            this.širinaDataGridViewTextBoxColumn.DataPropertyName = "Širina";
            this.širinaDataGridViewTextBoxColumn.HeaderText = "Širina";
            this.širinaDataGridViewTextBoxColumn.Name = "širinaDataGridViewTextBoxColumn";
            this.širinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visinaDataGridViewTextBoxColumn
            // 
            this.visinaDataGridViewTextBoxColumn.DataPropertyName = "Visina";
            this.visinaDataGridViewTextBoxColumn.HeaderText = "Debljina";
            this.visinaDataGridViewTextBoxColumn.Name = "visinaDataGridViewTextBoxColumn";
            this.visinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // količinaDataGridViewTextBoxColumn
            // 
            this.količinaDataGridViewTextBoxColumn.DataPropertyName = "Količina";
            this.količinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.količinaDataGridViewTextBoxColumn.Name = "količinaDataGridViewTextBoxColumn";
            this.količinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materijalDataGridViewTextBoxColumn
            // 
            this.materijalDataGridViewTextBoxColumn.DataPropertyName = "Materijal";
            this.materijalDataGridViewTextBoxColumn.HeaderText = "Materijal";
            this.materijalDataGridViewTextBoxColumn.Name = "materijalDataGridViewTextBoxColumn";
            this.materijalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kantiranostDataGridViewTextBoxColumn
            // 
            this.kantiranostDataGridViewTextBoxColumn.DataPropertyName = "Kantiranost";
            this.kantiranostDataGridViewTextBoxColumn.HeaderText = "Kantiranost";
            this.kantiranostDataGridViewTextBoxColumn.Name = "kantiranostDataGridViewTextBoxColumn";
            this.kantiranostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "Boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "Boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            this.bojaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ulogaDataGridViewTextBoxColumn
            // 
            this.ulogaDataGridViewTextBoxColumn.DataPropertyName = "Uloga";
            this.ulogaDataGridViewTextBoxColumn.HeaderText = "Uloga";
            this.ulogaDataGridViewTextBoxColumn.Name = "ulogaDataGridViewTextBoxColumn";
            this.ulogaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slikaDataGridViewTextBoxColumn
            // 
            this.slikaDataGridViewTextBoxColumn.DataPropertyName = "Slika";
            this.slikaDataGridViewTextBoxColumn.HeaderText = "Slika";
            this.slikaDataGridViewTextBoxColumn.Name = "slikaDataGridViewTextBoxColumn";
            this.slikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.slikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // pogledDjelovaPoProoizvoduBindingSource
            // 
            this.pogledDjelovaPoProoizvoduBindingSource.DataMember = "PogledDjelovaPoProoizvodu";
            this.pogledDjelovaPoProoizvoduBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // uiLabelDioNaziv
            // 
            this.uiLabelDioNaziv.AutoSize = true;
            this.uiLabelDioNaziv.Location = new System.Drawing.Point(39, 165);
            this.uiLabelDioNaziv.Name = "uiLabelDioNaziv";
            this.uiLabelDioNaziv.Size = new System.Drawing.Size(49, 18);
            this.uiLabelDioNaziv.TabIndex = 32;
            this.uiLabelDioNaziv.Text = "Naziv:";
            this.uiLabelDioNaziv.Visible = false;
            // 
            // uiLabelDioDuzina
            // 
            this.uiLabelDioDuzina.AutoSize = true;
            this.uiLabelDioDuzina.Location = new System.Drawing.Point(30, 195);
            this.uiLabelDioDuzina.Name = "uiLabelDioDuzina";
            this.uiLabelDioDuzina.Size = new System.Drawing.Size(58, 18);
            this.uiLabelDioDuzina.TabIndex = 33;
            this.uiLabelDioDuzina.Text = "Dužina:";
            this.uiLabelDioDuzina.Visible = false;
            // 
            // uiLabelDioSirina
            // 
            this.uiLabelDioSirina.AutoSize = true;
            this.uiLabelDioSirina.Location = new System.Drawing.Point(39, 225);
            this.uiLabelDioSirina.Name = "uiLabelDioSirina";
            this.uiLabelDioSirina.Size = new System.Drawing.Size(49, 18);
            this.uiLabelDioSirina.TabIndex = 34;
            this.uiLabelDioSirina.Text = "Širina:";
            this.uiLabelDioSirina.Visible = false;
            // 
            // uiLabelDioDebljina
            // 
            this.uiLabelDioDebljina.AutoSize = true;
            this.uiLabelDioDebljina.Location = new System.Drawing.Point(24, 255);
            this.uiLabelDioDebljina.Name = "uiLabelDioDebljina";
            this.uiLabelDioDebljina.Size = new System.Drawing.Size(64, 18);
            this.uiLabelDioDebljina.TabIndex = 35;
            this.uiLabelDioDebljina.Text = "Debljina:";
            this.uiLabelDioDebljina.Visible = false;
            // 
            // uiLabelDioMaterijal
            // 
            this.uiLabelDioMaterijal.AutoSize = true;
            this.uiLabelDioMaterijal.Location = new System.Drawing.Point(21, 285);
            this.uiLabelDioMaterijal.Name = "uiLabelDioMaterijal";
            this.uiLabelDioMaterijal.Size = new System.Drawing.Size(67, 18);
            this.uiLabelDioMaterijal.TabIndex = 37;
            this.uiLabelDioMaterijal.Text = "Materijal:";
            this.uiLabelDioMaterijal.Visible = false;
            // 
            // uiLabelOdabraniDioNaziv
            // 
            this.uiLabelOdabraniDioNaziv.AutoSize = true;
            this.uiLabelOdabraniDioNaziv.Location = new System.Drawing.Point(275, 59);
            this.uiLabelOdabraniDioNaziv.Name = "uiLabelOdabraniDioNaziv";
            this.uiLabelOdabraniDioNaziv.Size = new System.Drawing.Size(49, 18);
            this.uiLabelOdabraniDioNaziv.TabIndex = 38;
            this.uiLabelOdabraniDioNaziv.Text = "Naziv:";
            this.uiLabelOdabraniDioNaziv.Visible = false;
            // 
            // uiLabelOdabraniDioID
            // 
            this.uiLabelOdabraniDioID.AutoSize = true;
            this.uiLabelOdabraniDioID.Location = new System.Drawing.Point(298, 30);
            this.uiLabelOdabraniDioID.Name = "uiLabelOdabraniDioID";
            this.uiLabelOdabraniDioID.Size = new System.Drawing.Size(26, 18);
            this.uiLabelOdabraniDioID.TabIndex = 39;
            this.uiLabelOdabraniDioID.Text = "ID:";
            this.uiLabelOdabraniDioID.Visible = false;
            // 
            // uiActionObrišiDio
            // 
            this.uiActionObrišiDio.BackColor = System.Drawing.Color.Crimson;
            this.uiActionObrišiDio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionObrišiDio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionObrišiDio.ForeColor = System.Drawing.Color.White;
            this.uiActionObrišiDio.Location = new System.Drawing.Point(380, 255);
            this.uiActionObrišiDio.Name = "uiActionObrišiDio";
            this.uiActionObrišiDio.Size = new System.Drawing.Size(135, 51);
            this.uiActionObrišiDio.TabIndex = 40;
            this.uiActionObrišiDio.Text = "OBRIŠI";
            this.uiActionObrišiDio.UseVisualStyleBackColor = false;
            this.uiActionObrišiDio.Click += new System.EventHandler(this.uiActionObrišiDio_Click);
            // 
            // pogledDjelovaPoProoizvoduTableAdapter
            // 
            this.pogledDjelovaPoProoizvoduTableAdapter.ClearBeforeFill = true;
            // 
            // uiDodajDjeloveUProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 582);
            this.Controls.Add(this.uiActionObrišiDio);
            this.Controls.Add(this.uiLabelOdabraniDioID);
            this.Controls.Add(this.uiLabelOdabraniDioNaziv);
            this.Controls.Add(this.uiLabelDioMaterijal);
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
            this.Controls.Add(this.uiInputDioDebljina);
            this.Controls.Add(this.uiInputDioŠirina);
            this.Controls.Add(this.uiInputDioDužina);
            this.Controls.Add(this.uiInputDioNaziv);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.uiOutputUlogaNaziv);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.uiInputUlogaID);
            this.Controls.Add(this.uiActionDalje);
            this.Controls.Add(this.uiOutputDataTableDioUProizvodu);
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
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDataTableDioUProizvodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogledDjelovaPoProoizvoduBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView uiOutputDataTableDioUProizvodu;
        private System.Windows.Forms.Label uiLabelDioNaziv;
        private System.Windows.Forms.Label uiLabelDioDuzina;
        private System.Windows.Forms.Label uiLabelDioSirina;
        private System.Windows.Forms.Label uiLabelDioDebljina;
        private System.Windows.Forms.Label uiLabelDioMaterijal;
        private System.Windows.Forms.Label uiLabelOdabraniDioNaziv;
        private System.Windows.Forms.Label uiLabelOdabraniDioID;
        private System.Windows.Forms.Button uiActionObrišiDio;
        private System.Windows.Forms.BindingSource pogledDjelovaPoProoizvoduBindingSource;
        private Baza18043_DBDataSetTableAdapters.PogledDjelovaPoProoizvoduTableAdapter pogledDjelovaPoProoizvoduTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulogaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duljinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn širinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn količinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kantiranostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikaDataGridViewTextBoxColumn;
    }
}