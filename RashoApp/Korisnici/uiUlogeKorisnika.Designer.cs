namespace RashoApp.Korisnici {
    partial class UIUlogeKorisnika {
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
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.uiActionUredi = new System.Windows.Forms.Button();
            this.uiActionObriši = new System.Windows.Forms.Button();
            this.uiOznakaGreška = new System.Windows.Forms.Label();
            this.fKVidiElementUlogaKorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vidiElementTableAdapter1 = new RashoApp.Baza18043_DBDataSetTableAdapters.VidiElementTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaKorisnikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataUlogaKorisnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVidiElementUlogaKorisnikaBindingSource)).BeginInit();
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
            this.tableAdapterManager.UIElementiTableAdapter = null;
            this.tableAdapterManager.UlogaDijelaTableAdapter = null;
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = this.ulogaKorisnikaTableAdapter;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VidiElementTableAdapter = null;
            // 
            // uiOutputTableDataUlogaKorisnika
            // 
            this.uiOutputTableDataUlogaKorisnika.AutoGenerateColumns = false;
            this.uiOutputTableDataUlogaKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputTableDataUlogaKorisnika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.uiOutputTableDataUlogaKorisnika.DataSource = this.ulogaKorisnikaBindingSource;
            this.uiOutputTableDataUlogaKorisnika.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiOutputTableDataUlogaKorisnika.Location = new System.Drawing.Point(0, 0);
            this.uiOutputTableDataUlogaKorisnika.Name = "uiOutputTableDataUlogaKorisnika";
            this.uiOutputTableDataUlogaKorisnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputTableDataUlogaKorisnika.Size = new System.Drawing.Size(566, 310);
            this.uiOutputTableDataUlogaKorisnika.TabIndex = 1;
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionDodaj.FlatAppearance.BorderSize = 0;
            this.uiActionDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDodaj.ForeColor = System.Drawing.Color.White;
            this.uiActionDodaj.Location = new System.Drawing.Point(12, 341);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(75, 23);
            this.uiActionDodaj.TabIndex = 2;
            this.uiActionDodaj.Text = "Dodaj";
            this.uiActionDodaj.UseVisualStyleBackColor = false;
            this.uiActionDodaj.Click += new System.EventHandler(this.uiActionDodaj_Click);
            // 
            // uiActionUredi
            // 
            this.uiActionUredi.BackColor = System.Drawing.Color.Gold;
            this.uiActionUredi.FlatAppearance.BorderSize = 0;
            this.uiActionUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionUredi.ForeColor = System.Drawing.Color.White;
            this.uiActionUredi.Location = new System.Drawing.Point(93, 341);
            this.uiActionUredi.Name = "uiActionUredi";
            this.uiActionUredi.Size = new System.Drawing.Size(75, 23);
            this.uiActionUredi.TabIndex = 3;
            this.uiActionUredi.Text = "Uredi";
            this.uiActionUredi.UseVisualStyleBackColor = false;
            this.uiActionUredi.Click += new System.EventHandler(this.uiActionUredi_Click);
            // 
            // uiActionObriši
            // 
            this.uiActionObriši.BackColor = System.Drawing.Color.Crimson;
            this.uiActionObriši.FlatAppearance.BorderSize = 0;
            this.uiActionObriši.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionObriši.ForeColor = System.Drawing.Color.White;
            this.uiActionObriši.Location = new System.Drawing.Point(174, 341);
            this.uiActionObriši.Name = "uiActionObriši";
            this.uiActionObriši.Size = new System.Drawing.Size(75, 23);
            this.uiActionObriši.TabIndex = 4;
            this.uiActionObriši.Text = "Obriši";
            this.uiActionObriši.UseVisualStyleBackColor = false;
            this.uiActionObriši.Click += new System.EventHandler(this.uiActionObriši_Click);
            // 
            // uiOznakaGreška
            // 
            this.uiOznakaGreška.AutoSize = true;
            this.uiOznakaGreška.ForeColor = System.Drawing.Color.Red;
            this.uiOznakaGreška.Location = new System.Drawing.Point(13, 317);
            this.uiOznakaGreška.Name = "uiOznakaGreška";
            this.uiOznakaGreška.Size = new System.Drawing.Size(0, 13);
            this.uiOznakaGreška.TabIndex = 5;
            // 
            // fKVidiElementUlogaKorisnikaBindingSource
            // 
            this.fKVidiElementUlogaKorisnikaBindingSource.DataMember = "FK_VidiElement_UlogaKorisnika";
            this.fKVidiElementUlogaKorisnikaBindingSource.DataSource = this.ulogaKorisnikaBindingSource;
            // 
            // vidiElementTableAdapter1
            // 
            this.vidiElementTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // UIUlogeKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 388);
            this.Controls.Add(this.uiOznakaGreška);
            this.Controls.Add(this.uiActionObriši);
            this.Controls.Add(this.uiActionUredi);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(this.uiOutputTableDataUlogaKorisnika);
            this.Name = "UIUlogeKorisnika";
            this.Text = "Uloge korisnika";
            this.Load += new System.EventHandler(this.uiUlogeKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaKorisnikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataUlogaKorisnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVidiElementUlogaKorisnikaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource ulogaKorisnikaBindingSource;
        private Baza18043_DBDataSetTableAdapters.UlogaKorisnikaTableAdapter ulogaKorisnikaTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView uiOutputTableDataUlogaKorisnika;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.Button uiActionUredi;
        private System.Windows.Forms.Button uiActionObriši;
        private System.Windows.Forms.Label uiOznakaGreška;
        private System.Windows.Forms.BindingSource fKVidiElementUlogaKorisnikaBindingSource;
        private Baza18043_DBDataSetTableAdapters.VidiElementTableAdapter vidiElementTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
    }
}