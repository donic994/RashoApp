namespace RashoApp.Korisnici {
    partial class uiUlogeKorisnika {
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
            this.ulogaKorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ulogaKorisnikaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.UlogaKorisnikaTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.uiOutputTableDataUlogaKorisnika = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.uiActionUredi = new System.Windows.Forms.Button();
            this.uiActionObriši = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaKorisnikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataUlogaKorisnika)).BeginInit();
            this.SuspendLayout();
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ulogaKorisnikaBindingSource
            // 
            this.ulogaKorisnikaBindingSource.DataMember = "UlogaKorisnika";
            this.ulogaKorisnikaBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // ulogaKorisnikaTableAdapter
            // 
            this.ulogaKorisnikaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.UlogaDijelaTableAdapter = null;
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = this.ulogaKorisnikaTableAdapter;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uiOutputTableDataUlogaKorisnika
            // 
            this.uiOutputTableDataUlogaKorisnika.AutoGenerateColumns = false;
            this.uiOutputTableDataUlogaKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputTableDataUlogaKorisnika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.uiOutputTableDataUlogaKorisnika.DataSource = this.ulogaKorisnikaBindingSource;
            this.uiOutputTableDataUlogaKorisnika.Location = new System.Drawing.Point(12, 12);
            this.uiOutputTableDataUlogaKorisnika.Name = "uiOutputTableDataUlogaKorisnika";
            this.uiOutputTableDataUlogaKorisnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputTableDataUlogaKorisnika.Size = new System.Drawing.Size(541, 309);
            this.uiOutputTableDataUlogaKorisnika.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "opis";
            this.dataGridViewTextBoxColumn3.HeaderText = "opis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.Location = new System.Drawing.Point(12, 341);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(75, 23);
            this.uiActionDodaj.TabIndex = 2;
            this.uiActionDodaj.Text = "Dodaj";
            this.uiActionDodaj.UseVisualStyleBackColor = true;
            this.uiActionDodaj.Click += new System.EventHandler(this.uiActionDodaj_Click);
            // 
            // uiActionUredi
            // 
            this.uiActionUredi.Location = new System.Drawing.Point(93, 341);
            this.uiActionUredi.Name = "uiActionUredi";
            this.uiActionUredi.Size = new System.Drawing.Size(75, 23);
            this.uiActionUredi.TabIndex = 3;
            this.uiActionUredi.Text = "Uredi";
            this.uiActionUredi.UseVisualStyleBackColor = true;
            this.uiActionUredi.Click += new System.EventHandler(this.uiActionUredi_Click);
            // 
            // uiActionObriši
            // 
            this.uiActionObriši.Location = new System.Drawing.Point(174, 341);
            this.uiActionObriši.Name = "uiActionObriši";
            this.uiActionObriši.Size = new System.Drawing.Size(75, 23);
            this.uiActionObriši.TabIndex = 4;
            this.uiActionObriši.Text = "Obriši";
            this.uiActionObriši.UseVisualStyleBackColor = true;
            this.uiActionObriši.Click += new System.EventHandler(this.uiActionObriši_Click);
            // 
            // uiUlogeKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 388);
            this.Controls.Add(this.uiActionObriši);
            this.Controls.Add(this.uiActionUredi);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(this.uiOutputTableDataUlogaKorisnika);
            this.Name = "uiUlogeKorisnika";
            this.Text = "Uloge korisnika";
            this.Load += new System.EventHandler(this.uiUlogeKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaKorisnikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataUlogaKorisnika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource ulogaKorisnikaBindingSource;
        private Baza18043_DBDataSetTableAdapters.UlogaKorisnikaTableAdapter ulogaKorisnikaTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView uiOutputTableDataUlogaKorisnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.Button uiActionUredi;
        private System.Windows.Forms.Button uiActionObriši;
    }
}