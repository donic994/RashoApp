namespace RashoApp.Proizvod
{
    partial class uiProizvod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiProizvod));
            this.uiOutputDataProizvod = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlikaSlika = new System.Windows.Forms.DataGridViewImageColumn();
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.uiActionObrišiProizvod = new System.Windows.Forms.Button();
            this.uiActionUrediProizvod = new System.Windows.Forms.Button();
            this.uiActionDodajNoviProizvod = new System.Windows.Forms.Button();
            this.uiOutputTableDataPogledDjelovaPoProoizvodu = new System.Windows.Forms.DataGridView();
            this.dioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulogaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duljinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.širinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.količinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kantiranost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pogledDjelovaPoProoizvoduBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiOutputTableDataElement = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.elementTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.ElementTableAdapter();
            this.komponentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komponentaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter();
            this.pogledDjelovaPoProoizvoduTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.PogledDjelovaPoProoizvoduTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDataProizvod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataPogledDjelovaPoProoizvodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogledDjelovaPoProoizvoduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputDataProizvod
            // 
            this.uiOutputDataProizvod.AllowUserToAddRows = false;
            this.uiOutputDataProizvod.AllowUserToDeleteRows = false;
            this.uiOutputDataProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiOutputDataProizvod.AutoGenerateColumns = false;
            this.uiOutputDataProizvod.BackgroundColor = System.Drawing.Color.White;
            this.uiOutputDataProizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputDataProizvod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.SlikaSlika});
            this.uiOutputDataProizvod.DataSource = this.proizvodBindingSource;
            this.uiOutputDataProizvod.Location = new System.Drawing.Point(0, 12);
            this.uiOutputDataProizvod.MultiSelect = false;
            this.uiOutputDataProizvod.Name = "uiOutputDataProizvod";
            this.uiOutputDataProizvod.ReadOnly = true;
            this.uiOutputDataProizvod.RowHeadersVisible = false;
            this.uiOutputDataProizvod.RowTemplate.Height = 24;
            this.uiOutputDataProizvod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputDataProizvod.Size = new System.Drawing.Size(882, 170);
            this.uiOutputDataProizvod.TabIndex = 1;
            this.uiOutputDataProizvod.SelectionChanged += new System.EventHandler(this.uiOutputDataProizvod_SelectionChanged);
            this.uiOutputDataProizvod.DoubleClick += new System.EventHandler(this.uiOutputDataProizvod_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "naziv";
            this.dataGridViewTextBoxColumn6.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "duljina";
            this.dataGridViewTextBoxColumn2.HeaderText = "Duljina";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sirina";
            this.dataGridViewTextBoxColumn3.HeaderText = "Širina";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "visina";
            this.dataGridViewTextBoxColumn4.HeaderText = "Debljina";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "slika";
            this.dataGridViewTextBoxColumn5.HeaderText = "SlikaTekst";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SlikaSlika
            // 
            this.SlikaSlika.HeaderText = "Slika";
            this.SlikaSlika.Name = "SlikaSlika";
            this.SlikaSlika.ReadOnly = true;
            // 
            // proizvodBindingSource
            // 
            this.proizvodBindingSource.DataMember = "Proizvod";
            this.proizvodBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uiActionObrišiProizvod
            // 
            this.uiActionObrišiProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionObrišiProizvod.BackColor = System.Drawing.Color.Crimson;
            this.uiActionObrišiProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionObrišiProizvod.ForeColor = System.Drawing.Color.White;
            this.uiActionObrišiProizvod.Location = new System.Drawing.Point(773, 618);
            this.uiActionObrišiProizvod.Name = "uiActionObrišiProizvod";
            this.uiActionObrišiProizvod.Size = new System.Drawing.Size(97, 39);
            this.uiActionObrišiProizvod.TabIndex = 12;
            this.uiActionObrišiProizvod.Text = "Obriši";
            this.uiActionObrišiProizvod.UseVisualStyleBackColor = false;
            this.uiActionObrišiProizvod.Click += new System.EventHandler(this.uiActionObrišiProizvod_Click);
            // 
            // uiActionUrediProizvod
            // 
            this.uiActionUrediProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionUrediProizvod.BackColor = System.Drawing.Color.Gold;
            this.uiActionUrediProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionUrediProizvod.ForeColor = System.Drawing.Color.White;
            this.uiActionUrediProizvod.Location = new System.Drawing.Point(643, 618);
            this.uiActionUrediProizvod.Name = "uiActionUrediProizvod";
            this.uiActionUrediProizvod.Size = new System.Drawing.Size(97, 39);
            this.uiActionUrediProizvod.TabIndex = 11;
            this.uiActionUrediProizvod.Text = "Uredi";
            this.uiActionUrediProizvod.UseVisualStyleBackColor = false;
            this.uiActionUrediProizvod.Click += new System.EventHandler(this.uiActionUrediProizvod_Click);
            // 
            // uiActionDodajNoviProizvod
            // 
            this.uiActionDodajNoviProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionDodajNoviProizvod.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionDodajNoviProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDodajNoviProizvod.ForeColor = System.Drawing.Color.White;
            this.uiActionDodajNoviProizvod.Location = new System.Drawing.Point(516, 618);
            this.uiActionDodajNoviProizvod.Name = "uiActionDodajNoviProizvod";
            this.uiActionDodajNoviProizvod.Size = new System.Drawing.Size(97, 39);
            this.uiActionDodajNoviProizvod.TabIndex = 10;
            this.uiActionDodajNoviProizvod.Text = "Dodaj";
            this.uiActionDodajNoviProizvod.UseVisualStyleBackColor = false;
            this.uiActionDodajNoviProizvod.Click += new System.EventHandler(this.uiActionDodajNoviProizvod_Click);
            // 
            // uiOutputTableDataPogledDjelovaPoProoizvodu
            // 
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.AllowUserToAddRows = false;
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.AllowUserToDeleteRows = false;
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.AutoGenerateColumns = false;
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.BackgroundColor = System.Drawing.Color.White;
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dioIDDataGridViewTextBoxColumn,
            this.ulogaIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.duljinaDataGridViewTextBoxColumn,
            this.širinaDataGridViewTextBoxColumn,
            this.visinaDataGridViewTextBoxColumn,
            this.količinaDataGridViewTextBoxColumn,
            this.materijalDataGridViewTextBoxColumn,
            this.ulogaDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.Kantiranost,
            this.slikaDataGridViewTextBoxColumn});
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.DataSource = this.pogledDjelovaPoProoizvoduBindingSource;
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.Location = new System.Drawing.Point(0, 365);
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.MultiSelect = false;
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.Name = "uiOutputTableDataPogledDjelovaPoProoizvodu";
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.ReadOnly = true;
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.RowHeadersVisible = false;
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.RowTemplate.Height = 24;
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.Size = new System.Drawing.Size(882, 318);
            this.uiOutputTableDataPogledDjelovaPoProoizvodu.TabIndex = 12;
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
            this.duljinaDataGridViewTextBoxColumn.HeaderText = "Duljina";
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
            this.visinaDataGridViewTextBoxColumn.HeaderText = "Visina";
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
            // ulogaDataGridViewTextBoxColumn
            // 
            this.ulogaDataGridViewTextBoxColumn.DataPropertyName = "Uloga";
            this.ulogaDataGridViewTextBoxColumn.HeaderText = "Uloga";
            this.ulogaDataGridViewTextBoxColumn.Name = "ulogaDataGridViewTextBoxColumn";
            this.ulogaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "Boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "Boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            this.bojaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Kantiranost
            // 
            this.Kantiranost.DataPropertyName = "Kantiranost";
            this.Kantiranost.HeaderText = "Kantiranost";
            this.Kantiranost.Name = "Kantiranost";
            this.Kantiranost.ReadOnly = true;
            // 
            // slikaDataGridViewTextBoxColumn
            // 
            this.slikaDataGridViewTextBoxColumn.DataPropertyName = "Slika";
            this.slikaDataGridViewTextBoxColumn.HeaderText = "Slika";
            this.slikaDataGridViewTextBoxColumn.Name = "slikaDataGridViewTextBoxColumn";
            this.slikaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pogledDjelovaPoProoizvoduBindingSource
            // 
            this.pogledDjelovaPoProoizvoduBindingSource.DataMember = "PogledDjelovaPoProoizvodu";
            this.pogledDjelovaPoProoizvoduBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // uiOutputTableDataElement
            // 
            this.uiOutputTableDataElement.AllowUserToAddRows = false;
            this.uiOutputTableDataElement.AllowUserToDeleteRows = false;
            this.uiOutputTableDataElement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiOutputTableDataElement.AutoGenerateColumns = false;
            this.uiOutputTableDataElement.BackgroundColor = System.Drawing.Color.White;
            this.uiOutputTableDataElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputTableDataElement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn7});
            this.uiOutputTableDataElement.DataSource = this.elementBindingSource;
            this.uiOutputTableDataElement.Location = new System.Drawing.Point(0, 188);
            this.uiOutputTableDataElement.MultiSelect = false;
            this.uiOutputTableDataElement.Name = "uiOutputTableDataElement";
            this.uiOutputTableDataElement.ReadOnly = true;
            this.uiOutputTableDataElement.RowHeadersVisible = false;
            this.uiOutputTableDataElement.RowTemplate.Height = 24;
            this.uiOutputTableDataElement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputTableDataElement.Size = new System.Drawing.Size(882, 171);
            this.uiOutputTableDataElement.TabIndex = 12;
            this.uiOutputTableDataElement.SelectionChanged += new System.EventHandler(this.uiOutputTableDataElement_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_proizvod";
            this.dataGridViewTextBoxColumn8.DataSource = this.proizvodBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "naziv";
            this.dataGridViewTextBoxColumn8.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn8.HeaderText = "Proizvod";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "ID";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_element";
            this.dataGridViewTextBoxColumn9.DataSource = this.proizvodBindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "naziv";
            this.dataGridViewTextBoxColumn9.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn9.HeaderText = "Element";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "ID";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "kolicina";
            this.dataGridViewTextBoxColumn7.HeaderText = "Količina";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // elementBindingSource
            // 
            this.elementBindingSource.DataMember = "Element";
            this.elementBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // proizvodTableAdapter
            // 
            this.proizvodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DioTableAdapter = null;
            this.tableAdapterManager.DobavljacTableAdapter = null;
            this.tableAdapterManager.ElementTableAdapter = null;
            this.tableAdapterManager.KomponentaTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.ProizvodTableAdapter = this.proizvodTableAdapter;
            this.tableAdapterManager.StavkaNarudzbeTableAdapter = null;
            this.tableAdapterManager.UlogaDijelaTableAdapter = null;
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // elementTableAdapter
            // 
            this.elementTableAdapter.ClearBeforeFill = true;
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
            // pogledDjelovaPoProoizvoduTableAdapter
            // 
            this.pogledDjelovaPoProoizvoduTableAdapter.ClearBeforeFill = true;
            // 
            // uiProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 683);
            this.Controls.Add(this.uiOutputTableDataElement);
            this.Controls.Add(this.uiActionObrišiProizvod);
            this.Controls.Add(this.uiActionUrediProizvod);
            this.Controls.Add(this.uiActionDodajNoviProizvod);
            this.Controls.Add(this.uiOutputDataProizvod);
            this.Controls.Add(this.uiOutputTableDataPogledDjelovaPoProoizvodu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uiProizvod";
            this.Text = "Proizvod";
            this.Load += new System.EventHandler(this.uiProizvod_Load);
            this.SizeChanged += new System.EventHandler(this.uiProizvod_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDataProizvod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataPogledDjelovaPoProoizvodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogledDjelovaPoProoizvoduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource proizvodBindingSource;
        private Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter proizvodTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView uiOutputDataProizvod;
        private System.Windows.Forms.Button uiActionObrišiProizvod;
        private System.Windows.Forms.Button uiActionUrediProizvod;
        private System.Windows.Forms.Button uiActionDodajNoviProizvod;
        private System.Windows.Forms.BindingSource elementBindingSource;
        private Baza18043_DBDataSetTableAdapters.ElementTableAdapter elementTableAdapter;
        private System.Windows.Forms.DataGridView uiOutputTableDataPogledDjelovaPoProoizvodu;
        private System.Windows.Forms.DataGridView uiOutputTableDataElement;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource komponentaBindingSource;
        private Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter komponentaTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ulogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kantiranost;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn SlikaSlika;
    }
}