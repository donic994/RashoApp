namespace RashoApp.Korisnici {
    partial class UIKorisnici {
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
            this.ulogaKorisnikaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.UlogaKorisnikaTableAdapter();
            this.uiOutputTableDataKorisnici = new System.Windows.Forms.DataGridView();
            this.ulogaKorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.uiActionUredi = new System.Windows.Forms.Button();
            this.uiActionObriši = new System.Windows.Forms.Button();
            this.uiOznakaGreška = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaKorisnikaBindingSource)).BeginInit();
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
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = this.ulogaKorisnikaTableAdapter;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VidiElementTableAdapter = null;
            // 
            // ulogaKorisnikaTableAdapter
            // 
            this.ulogaKorisnikaTableAdapter.ClearBeforeFill = true;
            // 
            // uiOutputTableDataKorisnici
            // 
            this.uiOutputTableDataKorisnici.AutoGenerateColumns = false;
            this.uiOutputTableDataKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputTableDataKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.uiOutputTableDataKorisnici.DataSource = this.korisnikBindingSource;
            this.uiOutputTableDataKorisnici.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiOutputTableDataKorisnici.Location = new System.Drawing.Point(0, 0);
            this.uiOutputTableDataKorisnici.Name = "uiOutputTableDataKorisnici";
            this.uiOutputTableDataKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputTableDataKorisnici.Size = new System.Drawing.Size(872, 310);
            this.uiOutputTableDataKorisnici.TabIndex = 1;
            // 
            // ulogaKorisnikaBindingSource
            // 
            this.ulogaKorisnikaBindingSource.DataMember = "UlogaKorisnika";
            this.ulogaKorisnikaBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionDodaj.FlatAppearance.BorderSize = 0;
            this.uiActionDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDodaj.ForeColor = System.Drawing.Color.White;
            this.uiActionDodaj.Location = new System.Drawing.Point(12, 342);
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
            this.uiActionUredi.Location = new System.Drawing.Point(93, 342);
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
            this.uiActionObriši.Location = new System.Drawing.Point(174, 342);
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
            this.uiOznakaGreška.Location = new System.Drawing.Point(12, 317);
            this.uiOznakaGreška.Name = "uiOznakaGreška";
            this.uiOznakaGreška.Size = new System.Drawing.Size(0, 13);
            this.uiOznakaGreška.TabIndex = 5;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "adresa";
            this.dataGridViewTextBoxColumn5.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "korisnickoIme";
            this.dataGridViewTextBoxColumn6.HeaderText = "Korisničko ime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "kontaktBroj";
            this.dataGridViewTextBoxColumn8.HeaderText = "Kontakt broj";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_uloga";
            this.dataGridViewTextBoxColumn9.DataSource = this.ulogaKorisnikaBindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "naziv";
            this.dataGridViewTextBoxColumn9.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn9.HeaderText = "Uloga";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "ID";
            // 
            // UIKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 385);
            this.Controls.Add(this.uiOznakaGreška);
            this.Controls.Add(this.uiActionObriši);
            this.Controls.Add(this.uiActionUredi);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(this.uiOutputTableDataKorisnici);
            this.Name = "UIKorisnici";
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.uiKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaKorisnikaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private Baza18043_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Baza18043_DBDataSetTableAdapters.UlogaKorisnikaTableAdapter ulogaKorisnikaTableAdapter;
        private System.Windows.Forms.DataGridView uiOutputTableDataKorisnici;
        private System.Windows.Forms.BindingSource ulogaKorisnikaBindingSource;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.Button uiActionUredi;
        private System.Windows.Forms.Button uiActionObriši;
        private System.Windows.Forms.Label uiOznakaGreška;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
    }
}