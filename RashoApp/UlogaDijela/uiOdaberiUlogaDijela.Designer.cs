namespace RashoApp.UlogaDijela
{
    partial class uiOdaberiUlogaDijela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiOdaberiUlogaDijela));
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.ulogaDijelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ulogaDijelaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.uiOutputDataTableUlogaDijela = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiActionOdaberiUlogaDijela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDataTableUlogaDijela)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.DioTableAdapter = null;
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
            // uiOutputDataTableUlogaDijela
            // 
            this.uiOutputDataTableUlogaDijela.AllowUserToAddRows = false;
            this.uiOutputDataTableUlogaDijela.AllowUserToDeleteRows = false;
            this.uiOutputDataTableUlogaDijela.AutoGenerateColumns = false;
            this.uiOutputDataTableUlogaDijela.BackgroundColor = System.Drawing.Color.White;
            this.uiOutputDataTableUlogaDijela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputDataTableUlogaDijela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.uiOutputDataTableUlogaDijela.DataSource = this.ulogaDijelaBindingSource;
            this.uiOutputDataTableUlogaDijela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiOutputDataTableUlogaDijela.Location = new System.Drawing.Point(0, 0);
            this.uiOutputDataTableUlogaDijela.MultiSelect = false;
            this.uiOutputDataTableUlogaDijela.Name = "uiOutputDataTableUlogaDijela";
            this.uiOutputDataTableUlogaDijela.ReadOnly = true;
            this.uiOutputDataTableUlogaDijela.RowHeadersVisible = false;
            this.uiOutputDataTableUlogaDijela.RowTemplate.Height = 24;
            this.uiOutputDataTableUlogaDijela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputDataTableUlogaDijela.Size = new System.Drawing.Size(351, 325);
            this.uiOutputDataTableUlogaDijela.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // uiActionOdaberiUlogaDijela
            // 
            this.uiActionOdaberiUlogaDijela.BackColor = System.Drawing.Color.DarkTurquoise;
            this.uiActionOdaberiUlogaDijela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionOdaberiUlogaDijela.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdaberiUlogaDijela.ForeColor = System.Drawing.Color.White;
            this.uiActionOdaberiUlogaDijela.Location = new System.Drawing.Point(252, 273);
            this.uiActionOdaberiUlogaDijela.Name = "uiActionOdaberiUlogaDijela";
            this.uiActionOdaberiUlogaDijela.Size = new System.Drawing.Size(87, 40);
            this.uiActionOdaberiUlogaDijela.TabIndex = 3;
            this.uiActionOdaberiUlogaDijela.Text = "Odaberi";
            this.uiActionOdaberiUlogaDijela.UseVisualStyleBackColor = false;
            this.uiActionOdaberiUlogaDijela.Click += new System.EventHandler(this.uiActionOdaberiUlogaDijela_Click);
            // 
            // uiOdaberiUlogaDijela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 325);
            this.Controls.Add(this.uiActionOdaberiUlogaDijela);
            this.Controls.Add(this.uiOutputDataTableUlogaDijela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uiOdaberiUlogaDijela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odaberi ulogu dijela";
            this.Load += new System.EventHandler(this.uiOdaberiUlogaDijela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDataTableUlogaDijela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource ulogaDijelaBindingSource;
        private Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter ulogaDijelaTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView uiOutputDataTableUlogaDijela;
        private System.Windows.Forms.Button uiActionOdaberiUlogaDijela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}