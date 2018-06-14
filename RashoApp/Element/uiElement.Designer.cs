namespace RashoApp.Element
{
    partial class uiElement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiElement));
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.elementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.ElementTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.uiOutputTableDataElement = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uiActionObrišiElement = new System.Windows.Forms.Button();
            this.uiActionUrediElement = new System.Windows.Forms.Button();
            this.uiActionDodajNoviElement = new System.Windows.Forms.Button();
            this.proizvodTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elementBindingSource
            // 
            this.elementBindingSource.DataMember = "Element";
            this.elementBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // elementTableAdapter
            // 
            this.elementTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DioTableAdapter = null;
            this.tableAdapterManager.DobavljacTableAdapter = null;
            this.tableAdapterManager.ElementTableAdapter = this.elementTableAdapter;
            this.tableAdapterManager.KomponentaTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.ProizvodTableAdapter = null;
            this.tableAdapterManager.StavkaNarudzbeTableAdapter = null;
            this.tableAdapterManager.UlogaDijelaTableAdapter = null;
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uiOutputTableDataElement
            // 
            this.uiOutputTableDataElement.AllowUserToAddRows = false;
            this.uiOutputTableDataElement.AllowUserToDeleteRows = false;
            this.uiOutputTableDataElement.AutoGenerateColumns = false;
            this.uiOutputTableDataElement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.uiOutputTableDataElement.BackgroundColor = System.Drawing.Color.White;
            this.uiOutputTableDataElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputTableDataElement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.uiOutputTableDataElement.DataSource = this.elementBindingSource;
            this.uiOutputTableDataElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiOutputTableDataElement.Location = new System.Drawing.Point(10, 0);
            this.uiOutputTableDataElement.MultiSelect = false;
            this.uiOutputTableDataElement.Name = "uiOutputTableDataElement";
            this.uiOutputTableDataElement.ReadOnly = true;
            this.uiOutputTableDataElement.RowHeadersVisible = false;
            this.uiOutputTableDataElement.RowTemplate.Height = 24;
            this.uiOutputTableDataElement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputTableDataElement.Size = new System.Drawing.Size(792, 508);
            this.uiOutputTableDataElement.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kolicina";
            this.dataGridViewTextBoxColumn1.HeaderText = "Količina";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 86;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_proizvod";
            this.dataGridViewTextBoxColumn2.DataSource = this.proizvodBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "naziv";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "Proizvod";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID";
            this.dataGridViewTextBoxColumn2.Width = 92;
            // 
            // proizvodBindingSource
            // 
            this.proizvodBindingSource.DataMember = "Proizvod";
            this.proizvodBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_element";
            this.dataGridViewTextBoxColumn3.DataSource = this.proizvodBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "naziv";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "Element";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID";
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // uiActionObrišiElement
            // 
            this.uiActionObrišiElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionObrišiElement.BackColor = System.Drawing.Color.Crimson;
            this.uiActionObrišiElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionObrišiElement.ForeColor = System.Drawing.Color.White;
            this.uiActionObrišiElement.Location = new System.Drawing.Point(693, 443);
            this.uiActionObrišiElement.Name = "uiActionObrišiElement";
            this.uiActionObrišiElement.Size = new System.Drawing.Size(97, 39);
            this.uiActionObrišiElement.TabIndex = 6;
            this.uiActionObrišiElement.Text = "Obriši";
            this.uiActionObrišiElement.UseVisualStyleBackColor = false;
            this.uiActionObrišiElement.Click += new System.EventHandler(this.uiActionObrišiDio_Click);
            // 
            // uiActionUrediElement
            // 
            this.uiActionUrediElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionUrediElement.BackColor = System.Drawing.Color.Gold;
            this.uiActionUrediElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionUrediElement.ForeColor = System.Drawing.Color.White;
            this.uiActionUrediElement.Location = new System.Drawing.Point(563, 443);
            this.uiActionUrediElement.Name = "uiActionUrediElement";
            this.uiActionUrediElement.Size = new System.Drawing.Size(97, 39);
            this.uiActionUrediElement.TabIndex = 5;
            this.uiActionUrediElement.Text = "Uredi";
            this.uiActionUrediElement.UseVisualStyleBackColor = false;
            this.uiActionUrediElement.Click += new System.EventHandler(this.uiActionUrediDio_Click);
            // 
            // uiActionDodajNoviElement
            // 
            this.uiActionDodajNoviElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionDodajNoviElement.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionDodajNoviElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDodajNoviElement.ForeColor = System.Drawing.Color.White;
            this.uiActionDodajNoviElement.Location = new System.Drawing.Point(436, 443);
            this.uiActionDodajNoviElement.Name = "uiActionDodajNoviElement";
            this.uiActionDodajNoviElement.Size = new System.Drawing.Size(97, 39);
            this.uiActionDodajNoviElement.TabIndex = 4;
            this.uiActionDodajNoviElement.Text = "Dodaj";
            this.uiActionDodajNoviElement.UseVisualStyleBackColor = false;
            this.uiActionDodajNoviElement.Click += new System.EventHandler(this.uiActionDodajNoviDio_Click);
            // 
            // proizvodTableAdapter
            // 
            this.proizvodTableAdapter.ClearBeforeFill = true;
            // 
            // uiElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 508);
            this.Controls.Add(this.uiActionObrišiElement);
            this.Controls.Add(this.uiActionUrediElement);
            this.Controls.Add(this.uiActionDodajNoviElement);
            this.Controls.Add(this.uiOutputTableDataElement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uiElement";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "Element";
            this.Load += new System.EventHandler(this.uiElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource elementBindingSource;
        private Baza18043_DBDataSetTableAdapters.ElementTableAdapter elementTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView uiOutputTableDataElement;
        private System.Windows.Forms.Button uiActionObrišiElement;
        private System.Windows.Forms.Button uiActionUrediElement;
        private System.Windows.Forms.Button uiActionDodajNoviElement;
        private System.Windows.Forms.BindingSource proizvodBindingSource;
        private Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter proizvodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
    }
}