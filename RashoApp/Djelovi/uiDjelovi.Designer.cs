namespace RashoApp
{
    partial class uiDjelovi
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
            this.uiActionDodajNoviDio = new System.Windows.Forms.Button();
            this.uiActionUrediDio = new System.Windows.Forms.Button();
            this.uiActionObrišiDio = new System.Windows.Forms.Button();
            this.uiOutputTableDataDio = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.dioTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.DioTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataDio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionDodajNoviDio
            // 
            this.uiActionDodajNoviDio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionDodajNoviDio.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionDodajNoviDio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDodajNoviDio.ForeColor = System.Drawing.Color.White;
            this.uiActionDodajNoviDio.Location = new System.Drawing.Point(436, 443);
            this.uiActionDodajNoviDio.Name = "uiActionDodajNoviDio";
            this.uiActionDodajNoviDio.Size = new System.Drawing.Size(97, 39);
            this.uiActionDodajNoviDio.TabIndex = 1;
            this.uiActionDodajNoviDio.Text = "Dodaj";
            this.uiActionDodajNoviDio.UseVisualStyleBackColor = false;
            this.uiActionDodajNoviDio.Click += new System.EventHandler(this.uiActionDodajNoviDio_Click);
            // 
            // uiActionUrediDio
            // 
            this.uiActionUrediDio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionUrediDio.BackColor = System.Drawing.Color.Gold;
            this.uiActionUrediDio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionUrediDio.ForeColor = System.Drawing.Color.White;
            this.uiActionUrediDio.Location = new System.Drawing.Point(563, 443);
            this.uiActionUrediDio.Name = "uiActionUrediDio";
            this.uiActionUrediDio.Size = new System.Drawing.Size(97, 39);
            this.uiActionUrediDio.TabIndex = 2;
            this.uiActionUrediDio.Text = "Uredi";
            this.uiActionUrediDio.UseVisualStyleBackColor = false;
            this.uiActionUrediDio.Click += new System.EventHandler(this.uiActionUrediDio_Click);
            // 
            // uiActionObrišiDio
            // 
            this.uiActionObrišiDio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionObrišiDio.BackColor = System.Drawing.Color.Crimson;
            this.uiActionObrišiDio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionObrišiDio.ForeColor = System.Drawing.Color.White;
            this.uiActionObrišiDio.Location = new System.Drawing.Point(693, 443);
            this.uiActionObrišiDio.Name = "uiActionObrišiDio";
            this.uiActionObrišiDio.Size = new System.Drawing.Size(97, 39);
            this.uiActionObrišiDio.TabIndex = 3;
            this.uiActionObrišiDio.Text = "Obriši";
            this.uiActionObrišiDio.UseVisualStyleBackColor = false;
            this.uiActionObrišiDio.Click += new System.EventHandler(this.uiActionObrišiDio_Click);
            // 
            // uiOutputTableDataDio
            // 
            this.uiOutputTableDataDio.AllowUserToAddRows = false;
            this.uiOutputTableDataDio.AllowUserToDeleteRows = false;
            this.uiOutputTableDataDio.AllowUserToOrderColumns = true;
            this.uiOutputTableDataDio.AutoGenerateColumns = false;
            this.uiOutputTableDataDio.BackgroundColor = System.Drawing.Color.White;
            this.uiOutputTableDataDio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputTableDataDio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.uiOutputTableDataDio.DataSource = this.dioBindingSource;
            this.uiOutputTableDataDio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiOutputTableDataDio.Location = new System.Drawing.Point(0, 0);
            this.uiOutputTableDataDio.MultiSelect = false;
            this.uiOutputTableDataDio.Name = "uiOutputTableDataDio";
            this.uiOutputTableDataDio.ReadOnly = true;
            this.uiOutputTableDataDio.RowTemplate.Height = 24;
            this.uiOutputTableDataDio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputTableDataDio.Size = new System.Drawing.Size(802, 508);
            this.uiOutputTableDataDio.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 85;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "duljina";
            this.dataGridViewTextBoxColumn3.HeaderText = "Duljina(mm)";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 85;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sirina";
            this.dataGridViewTextBoxColumn4.HeaderText = "Širina(mm)";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 85;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "visina";
            this.dataGridViewTextBoxColumn5.HeaderText = "Visina(mm)";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 85;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "slika";
            this.dataGridViewTextBoxColumn6.HeaderText = "Slika";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 85;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "materijal";
            this.dataGridViewTextBoxColumn7.HeaderText = "Materijal";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dioBindingSource
            // 
            this.dioBindingSource.DataMember = "Dio";
            this.dioBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dioTableAdapter
            // 
            this.dioTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.UlogaDijelaTableAdapter = null;
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uiDjelovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(802, 508);
            this.Controls.Add(this.uiActionObrišiDio);
            this.Controls.Add(this.uiActionUrediDio);
            this.Controls.Add(this.uiActionDodajNoviDio);
            this.Controls.Add(this.uiOutputTableDataDio);
            this.Name = "uiDjelovi";
            this.Text = "uiDjelovi";
            this.Load += new System.EventHandler(this.uiDjelovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataDio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource dioBindingSource;
        private Baza18043_DBDataSetTableAdapters.DioTableAdapter dioTableAdapter;
        private System.Windows.Forms.Button uiActionDodajNoviDio;
        private System.Windows.Forms.Button uiActionUrediDio;
        private System.Windows.Forms.Button uiActionObrišiDio;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView uiOutputTableDataDio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}