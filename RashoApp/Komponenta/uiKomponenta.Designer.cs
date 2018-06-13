namespace RashoApp.Komponenta
{
    partial class uiKomponenta
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
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.komponentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komponentaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.uiOutputTableDataKoponenta = new System.Windows.Forms.DataGridView();
            this.uiActionObrišiKomponenta = new System.Windows.Forms.Button();
            this.uiActionUrediKomponenta = new System.Windows.Forms.Button();
            this.uiActionDodajNoviKomponenta = new System.Windows.Forms.Button();
            this.ulogaDijelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ulogaDijelaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter();
            this.dioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dioTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.DioTableAdapter();
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataKoponenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DioTableAdapter = null;
            this.tableAdapterManager.DobavljacTableAdapter = null;
            this.tableAdapterManager.ElementTableAdapter = null;
            this.tableAdapterManager.KomponentaTableAdapter = this.komponentaTableAdapter;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.ProizvodTableAdapter = null;
            this.tableAdapterManager.StavkaNarudzbeTableAdapter = null;
            this.tableAdapterManager.UlogaDijelaTableAdapter = null;
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uiOutputTableDataKoponenta
            // 
            this.uiOutputTableDataKoponenta.AllowUserToAddRows = false;
            this.uiOutputTableDataKoponenta.AllowUserToDeleteRows = false;
            this.uiOutputTableDataKoponenta.AutoGenerateColumns = false;
            this.uiOutputTableDataKoponenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiOutputTableDataKoponenta.BackgroundColor = System.Drawing.Color.White;
            this.uiOutputTableDataKoponenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputTableDataKoponenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6});
            this.uiOutputTableDataKoponenta.DataSource = this.komponentaBindingSource;
            this.uiOutputTableDataKoponenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiOutputTableDataKoponenta.Location = new System.Drawing.Point(10, 0);
            this.uiOutputTableDataKoponenta.MultiSelect = false;
            this.uiOutputTableDataKoponenta.Name = "uiOutputTableDataKoponenta";
            this.uiOutputTableDataKoponenta.ReadOnly = true;
            this.uiOutputTableDataKoponenta.RowHeadersVisible = false;
            this.uiOutputTableDataKoponenta.RowTemplate.Height = 24;
            this.uiOutputTableDataKoponenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputTableDataKoponenta.Size = new System.Drawing.Size(792, 508);
            this.uiOutputTableDataKoponenta.TabIndex = 1;
            // 
            // uiActionObrišiKomponenta
            // 
            this.uiActionObrišiKomponenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionObrišiKomponenta.BackColor = System.Drawing.Color.Crimson;
            this.uiActionObrišiKomponenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionObrišiKomponenta.ForeColor = System.Drawing.Color.White;
            this.uiActionObrišiKomponenta.Location = new System.Drawing.Point(693, 443);
            this.uiActionObrišiKomponenta.Name = "uiActionObrišiKomponenta";
            this.uiActionObrišiKomponenta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.uiActionObrišiKomponenta.Size = new System.Drawing.Size(97, 39);
            this.uiActionObrišiKomponenta.TabIndex = 9;
            this.uiActionObrišiKomponenta.Text = "Obriši";
            this.uiActionObrišiKomponenta.UseVisualStyleBackColor = false;
            this.uiActionObrišiKomponenta.Click += new System.EventHandler(this.uiActionObrišiKomponenta_Click);
            // 
            // uiActionUrediKomponenta
            // 
            this.uiActionUrediKomponenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionUrediKomponenta.BackColor = System.Drawing.Color.Gold;
            this.uiActionUrediKomponenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionUrediKomponenta.ForeColor = System.Drawing.Color.White;
            this.uiActionUrediKomponenta.Location = new System.Drawing.Point(563, 443);
            this.uiActionUrediKomponenta.Name = "uiActionUrediKomponenta";
            this.uiActionUrediKomponenta.Size = new System.Drawing.Size(97, 39);
            this.uiActionUrediKomponenta.TabIndex = 8;
            this.uiActionUrediKomponenta.Text = "Uredi";
            this.uiActionUrediKomponenta.UseVisualStyleBackColor = false;
            this.uiActionUrediKomponenta.Click += new System.EventHandler(this.uiActionUrediKomponenta_Click);
            // 
            // uiActionDodajNoviKomponenta
            // 
            this.uiActionDodajNoviKomponenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionDodajNoviKomponenta.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionDodajNoviKomponenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDodajNoviKomponenta.ForeColor = System.Drawing.Color.White;
            this.uiActionDodajNoviKomponenta.Location = new System.Drawing.Point(436, 443);
            this.uiActionDodajNoviKomponenta.Name = "uiActionDodajNoviKomponenta";
            this.uiActionDodajNoviKomponenta.Size = new System.Drawing.Size(97, 39);
            this.uiActionDodajNoviKomponenta.TabIndex = 7;
            this.uiActionDodajNoviKomponenta.Text = "Dodaj";
            this.uiActionDodajNoviKomponenta.UseVisualStyleBackColor = false;
            this.uiActionDodajNoviKomponenta.Click += new System.EventHandler(this.uiActionDodajNoviKomponenta_Click);
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
            // dioBindingSource
            // 
            this.dioBindingSource.DataMember = "Dio";
            this.dioBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // dioTableAdapter
            // 
            this.dioTableAdapter.ClearBeforeFill = true;
            // 
            // proizvodBindingSource
            // 
            this.proizvodBindingSource.DataMember = "Proizvod";
            this.proizvodBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // proizvodTableAdapter
            // 
            this.proizvodTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_dio";
            this.dataGridViewTextBoxColumn5.DataSource = this.dioBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "naziv";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn5.HeaderText = "Dio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "ID";
            this.dataGridViewTextBoxColumn5.Width = 58;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kolicina";
            this.dataGridViewTextBoxColumn1.HeaderText = "Količina";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 86;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_uloga";
            this.dataGridViewTextBoxColumn4.DataSource = this.ulogaDijelaBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "naziv";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "Uloga";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "ID";
            this.dataGridViewTextBoxColumn4.Width = 74;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "boja";
            this.dataGridViewTextBoxColumn2.HeaderText = "Boja";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 65;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kantiranost";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kantoranost";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 114;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_proizvod";
            this.dataGridViewTextBoxColumn6.DataSource = this.proizvodBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "naziv";
            this.dataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn6.HeaderText = "Proizvod";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "ID";
            this.dataGridViewTextBoxColumn6.Width = 92;
            // 
            // uiKomponenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 508);
            this.Controls.Add(this.uiActionObrišiKomponenta);
            this.Controls.Add(this.uiActionUrediKomponenta);
            this.Controls.Add(this.uiActionDodajNoviKomponenta);
            this.Controls.Add(this.uiOutputTableDataKoponenta);
            this.Name = "uiKomponenta";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "uiKomponenta";
            this.Load += new System.EventHandler(this.uiKomponenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataKoponenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource komponentaBindingSource;
        private Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter komponentaTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView uiOutputTableDataKoponenta;
        private System.Windows.Forms.Button uiActionObrišiKomponenta;
        private System.Windows.Forms.Button uiActionUrediKomponenta;
        private System.Windows.Forms.Button uiActionDodajNoviKomponenta;
        private System.Windows.Forms.BindingSource ulogaDijelaBindingSource;
        private Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter ulogaDijelaTableAdapter;
        private System.Windows.Forms.BindingSource dioBindingSource;
        private Baza18043_DBDataSetTableAdapters.DioTableAdapter dioTableAdapter;
        private System.Windows.Forms.BindingSource proizvodBindingSource;
        private Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter proizvodTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
    }
}