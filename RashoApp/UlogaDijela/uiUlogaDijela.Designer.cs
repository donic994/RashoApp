namespace RashoApp.UlogaDijela
{
    partial class uiUlogaDijela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiUlogaDijela));
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.ulogaDijelaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter();
            this.ulogaDijelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiOutputTableDataUlogaDijela = new System.Windows.Forms.DataGridView();
            this.uiActionObrišiUlogaDijela = new System.Windows.Forms.Button();
            this.uiActionUrediUlogaDijela = new System.Windows.Forms.Button();
            this.uiActionDodajNoviUlogaDijela = new System.Windows.Forms.Button();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.komponentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komponentaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debljina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijedlogIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataUlogaDijela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ulogaDijelaTableAdapter
            // 
            this.ulogaDijelaTableAdapter.ClearBeforeFill = true;
            // 
            // ulogaDijelaBindingSource
            // 
            this.ulogaDijelaBindingSource.DataMember = "UlogaDijela";
            this.ulogaDijelaBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // uiOutputTableDataUlogaDijela
            // 
            this.uiOutputTableDataUlogaDijela.AllowUserToAddRows = false;
            this.uiOutputTableDataUlogaDijela.AllowUserToDeleteRows = false;
            this.uiOutputTableDataUlogaDijela.AutoGenerateColumns = false;
            this.uiOutputTableDataUlogaDijela.BackgroundColor = System.Drawing.Color.White;
            this.uiOutputTableDataUlogaDijela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputTableDataUlogaDijela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.duzina,
            this.sirina,
            this.debljina,
            this.materijal,
            this.prijedlogIme});
            this.uiOutputTableDataUlogaDijela.DataSource = this.ulogaDijelaBindingSource;
            this.uiOutputTableDataUlogaDijela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiOutputTableDataUlogaDijela.Location = new System.Drawing.Point(10, 0);
            this.uiOutputTableDataUlogaDijela.MultiSelect = false;
            this.uiOutputTableDataUlogaDijela.Name = "uiOutputTableDataUlogaDijela";
            this.uiOutputTableDataUlogaDijela.ReadOnly = true;
            this.uiOutputTableDataUlogaDijela.RowHeadersVisible = false;
            this.uiOutputTableDataUlogaDijela.RowTemplate.Height = 24;
            this.uiOutputTableDataUlogaDijela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputTableDataUlogaDijela.Size = new System.Drawing.Size(792, 508);
            this.uiOutputTableDataUlogaDijela.TabIndex = 1;
            // 
            // uiActionObrišiUlogaDijela
            // 
            this.uiActionObrišiUlogaDijela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionObrišiUlogaDijela.BackColor = System.Drawing.Color.Crimson;
            this.uiActionObrišiUlogaDijela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionObrišiUlogaDijela.ForeColor = System.Drawing.Color.White;
            this.uiActionObrišiUlogaDijela.Location = new System.Drawing.Point(693, 443);
            this.uiActionObrišiUlogaDijela.Name = "uiActionObrišiUlogaDijela";
            this.uiActionObrišiUlogaDijela.Size = new System.Drawing.Size(97, 39);
            this.uiActionObrišiUlogaDijela.TabIndex = 15;
            this.uiActionObrišiUlogaDijela.Text = "Obriši";
            this.uiActionObrišiUlogaDijela.UseVisualStyleBackColor = false;
            this.uiActionObrišiUlogaDijela.Click += new System.EventHandler(this.uiActionObrišiUlogaDijela_Click);
            // 
            // uiActionUrediUlogaDijela
            // 
            this.uiActionUrediUlogaDijela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionUrediUlogaDijela.BackColor = System.Drawing.Color.Gold;
            this.uiActionUrediUlogaDijela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionUrediUlogaDijela.ForeColor = System.Drawing.Color.White;
            this.uiActionUrediUlogaDijela.Location = new System.Drawing.Point(563, 443);
            this.uiActionUrediUlogaDijela.Name = "uiActionUrediUlogaDijela";
            this.uiActionUrediUlogaDijela.Size = new System.Drawing.Size(97, 39);
            this.uiActionUrediUlogaDijela.TabIndex = 14;
            this.uiActionUrediUlogaDijela.Text = "Uredi";
            this.uiActionUrediUlogaDijela.UseVisualStyleBackColor = false;
            this.uiActionUrediUlogaDijela.Click += new System.EventHandler(this.uiActionUrediUlogaDijela_Click);
            // 
            // uiActionDodajNoviUlogaDijela
            // 
            this.uiActionDodajNoviUlogaDijela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionDodajNoviUlogaDijela.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionDodajNoviUlogaDijela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDodajNoviUlogaDijela.ForeColor = System.Drawing.Color.White;
            this.uiActionDodajNoviUlogaDijela.Location = new System.Drawing.Point(436, 443);
            this.uiActionDodajNoviUlogaDijela.Name = "uiActionDodajNoviUlogaDijela";
            this.uiActionDodajNoviUlogaDijela.Size = new System.Drawing.Size(97, 39);
            this.uiActionDodajNoviUlogaDijela.TabIndex = 13;
            this.uiActionDodajNoviUlogaDijela.Text = "Dodaj";
            this.uiActionDodajNoviUlogaDijela.UseVisualStyleBackColor = false;
            this.uiActionDodajNoviUlogaDijela.Click += new System.EventHandler(this.uiActionDodajNoviUlogaDijela_Click);
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
            this.tableAdapterManager.ProizvodTableAdapter = null;
            this.tableAdapterManager.StavkaNarudzbeTableAdapter = null;
            this.tableAdapterManager.UIElementiTableAdapter = null;
            this.tableAdapterManager.UlogaDijelaTableAdapter = this.ulogaDijelaTableAdapter;
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VidiElementTableAdapter = null;
            this.tableAdapterManager.VidljiviElementiTableAdapter = null;
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duzina
            // 
            this.duzina.DataPropertyName = "duzina";
            this.duzina.HeaderText = "Dužina";
            this.duzina.Name = "duzina";
            this.duzina.ReadOnly = true;
            // 
            // sirina
            // 
            this.sirina.DataPropertyName = "sirina";
            this.sirina.HeaderText = "Širina";
            this.sirina.Name = "sirina";
            this.sirina.ReadOnly = true;
            // 
            // debljina
            // 
            this.debljina.DataPropertyName = "debljina";
            this.debljina.HeaderText = "Debljina";
            this.debljina.Name = "debljina";
            this.debljina.ReadOnly = true;
            // 
            // materijal
            // 
            this.materijal.DataPropertyName = "materijal";
            this.materijal.HeaderText = "Materijal";
            this.materijal.Name = "materijal";
            this.materijal.ReadOnly = true;
            // 
            // prijedlogIme
            // 
            this.prijedlogIme.DataPropertyName = "prijedlogIme";
            this.prijedlogIme.HeaderText = "Prijedlog imena";
            this.prijedlogIme.Name = "prijedlogIme";
            this.prijedlogIme.ReadOnly = true;
            // 
            // uiUlogaDijela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 508);
            this.Controls.Add(this.uiActionObrišiUlogaDijela);
            this.Controls.Add(this.uiActionUrediUlogaDijela);
            this.Controls.Add(this.uiActionDodajNoviUlogaDijela);
            this.Controls.Add(this.uiOutputTableDataUlogaDijela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uiUlogaDijela";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "Uloga dijela";
            this.Load += new System.EventHandler(this.uiUlogaDijela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataUlogaDijela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource ulogaDijelaBindingSource;
        private Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter ulogaDijelaTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView uiOutputTableDataUlogaDijela;
        private System.Windows.Forms.Button uiActionObrišiUlogaDijela;
        private System.Windows.Forms.Button uiActionUrediUlogaDijela;
        private System.Windows.Forms.Button uiActionDodajNoviUlogaDijela;
        private System.Windows.Forms.BindingSource komponentaBindingSource;
        private Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter komponentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duzina;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirina;
        private System.Windows.Forms.DataGridViewTextBoxColumn debljina;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijal;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijedlogIme;
    }
}