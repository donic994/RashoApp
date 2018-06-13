namespace RashoApp.Proizvod
{
    partial class uiOdaberiProizvod
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
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.uiOutputDataTableProizvod = new System.Windows.Forms.DataGridView();
            this.uiActionOdaberiProizvod = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDataTableProizvod)).BeginInit();
            this.SuspendLayout();
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // uiOutputDataTableProizvod
            // 
            this.uiOutputDataTableProizvod.AllowUserToAddRows = false;
            this.uiOutputDataTableProizvod.AllowUserToDeleteRows = false;
            this.uiOutputDataTableProizvod.AutoGenerateColumns = false;
            this.uiOutputDataTableProizvod.BackgroundColor = System.Drawing.Color.White;
            this.uiOutputDataTableProizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputDataTableProizvod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.uiOutputDataTableProizvod.DataSource = this.proizvodBindingSource;
            this.uiOutputDataTableProizvod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiOutputDataTableProizvod.Location = new System.Drawing.Point(0, 0);
            this.uiOutputDataTableProizvod.MultiSelect = false;
            this.uiOutputDataTableProizvod.Name = "uiOutputDataTableProizvod";
            this.uiOutputDataTableProizvod.ReadOnly = true;
            this.uiOutputDataTableProizvod.RowHeadersVisible = false;
            this.uiOutputDataTableProizvod.RowTemplate.Height = 24;
            this.uiOutputDataTableProizvod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputDataTableProizvod.Size = new System.Drawing.Size(541, 386);
            this.uiOutputDataTableProizvod.TabIndex = 1;
            // 
            // uiActionOdaberiProizvod
            // 
            this.uiActionOdaberiProizvod.BackColor = System.Drawing.Color.DarkTurquoise;
            this.uiActionOdaberiProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionOdaberiProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdaberiProizvod.ForeColor = System.Drawing.Color.White;
            this.uiActionOdaberiProizvod.Location = new System.Drawing.Point(442, 316);
            this.uiActionOdaberiProizvod.Name = "uiActionOdaberiProizvod";
            this.uiActionOdaberiProizvod.Size = new System.Drawing.Size(87, 40);
            this.uiActionOdaberiProizvod.TabIndex = 2;
            this.uiActionOdaberiProizvod.Text = "Odaberi";
            this.uiActionOdaberiProizvod.UseVisualStyleBackColor = false;
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
            this.dataGridViewTextBoxColumn6.HeaderText = "naziv";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "duljina";
            this.dataGridViewTextBoxColumn2.HeaderText = "duljina";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sirina";
            this.dataGridViewTextBoxColumn3.HeaderText = "sirina";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "visina";
            this.dataGridViewTextBoxColumn4.HeaderText = "visina";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "slika";
            this.dataGridViewTextBoxColumn5.HeaderText = "slika";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // uiOdaberiProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 386);
            this.Controls.Add(this.uiActionOdaberiProizvod);
            this.Controls.Add(this.uiOutputDataTableProizvod);
            this.Name = "uiOdaberiProizvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uiOdaberiProizvod";
            this.Load += new System.EventHandler(this.uiOdaberiProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDataTableProizvod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource proizvodBindingSource;
        private Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter proizvodTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView uiOutputDataTableProizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button uiActionOdaberiProizvod;
    }
}