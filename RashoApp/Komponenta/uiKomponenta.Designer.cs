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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiKomponenta));
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.komponentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komponentaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.komponentaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.komponentaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.uiOutputTableDataKoponenta = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiActionObrišiKomponenta = new System.Windows.Forms.Button();
            this.uiActionUrediKomponenta = new System.Windows.Forms.Button();
            this.uiActionDodajNoviKomponenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingNavigator)).BeginInit();
            this.komponentaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataKoponenta)).BeginInit();
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
            // komponentaBindingNavigator
            // 
            this.komponentaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.komponentaBindingNavigator.BindingSource = this.komponentaBindingSource;
            this.komponentaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.komponentaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.komponentaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.komponentaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.komponentaBindingNavigatorSaveItem});
            this.komponentaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.komponentaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.komponentaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.komponentaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.komponentaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.komponentaBindingNavigator.Name = "komponentaBindingNavigator";
            this.komponentaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.komponentaBindingNavigator.Size = new System.Drawing.Size(802, 27);
            this.komponentaBindingNavigator.TabIndex = 0;
            this.komponentaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // komponentaBindingNavigatorSaveItem
            // 
            this.komponentaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.komponentaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("komponentaBindingNavigatorSaveItem.Image")));
            this.komponentaBindingNavigatorSaveItem.Name = "komponentaBindingNavigatorSaveItem";
            this.komponentaBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.komponentaBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // uiOutputTableDataKoponenta
            // 
            this.uiOutputTableDataKoponenta.AllowUserToAddRows = false;
            this.uiOutputTableDataKoponenta.AllowUserToDeleteRows = false;
            this.uiOutputTableDataKoponenta.AutoGenerateColumns = false;
            this.uiOutputTableDataKoponenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.uiOutputTableDataKoponenta.BackgroundColor = System.Drawing.Color.White;
            this.uiOutputTableDataKoponenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputTableDataKoponenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.uiOutputTableDataKoponenta.DataSource = this.komponentaBindingSource;
            this.uiOutputTableDataKoponenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiOutputTableDataKoponenta.Location = new System.Drawing.Point(0, 27);
            this.uiOutputTableDataKoponenta.MultiSelect = false;
            this.uiOutputTableDataKoponenta.Name = "uiOutputTableDataKoponenta";
            this.uiOutputTableDataKoponenta.ReadOnly = true;
            this.uiOutputTableDataKoponenta.RowHeadersVisible = false;
            this.uiOutputTableDataKoponenta.RowTemplate.Height = 24;
            this.uiOutputTableDataKoponenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputTableDataKoponenta.Size = new System.Drawing.Size(802, 481);
            this.uiOutputTableDataKoponenta.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kolicina";
            this.dataGridViewTextBoxColumn1.HeaderText = "kolicina";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 84;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "boja";
            this.dataGridViewTextBoxColumn2.HeaderText = "boja";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 64;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kantiranost";
            this.dataGridViewTextBoxColumn3.HeaderText = "kantiranost";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 107;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_uloga";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_uloga";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 91;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_dio";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_dio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_proizvod";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_proizvod";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // uiActionObrišiKomponenta
            // 
            this.uiActionObrišiKomponenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionObrišiKomponenta.BackColor = System.Drawing.Color.Crimson;
            this.uiActionObrišiKomponenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionObrišiKomponenta.ForeColor = System.Drawing.Color.White;
            this.uiActionObrišiKomponenta.Location = new System.Drawing.Point(693, 443);
            this.uiActionObrišiKomponenta.Name = "uiActionObrišiKomponenta";
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
            // uiKomponenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 508);
            this.Controls.Add(this.uiActionObrišiKomponenta);
            this.Controls.Add(this.uiActionUrediKomponenta);
            this.Controls.Add(this.uiActionDodajNoviKomponenta);
            this.Controls.Add(this.uiOutputTableDataKoponenta);
            this.Controls.Add(this.komponentaBindingNavigator);
            this.Name = "uiKomponenta";
            this.Text = "uiKomponenta";
            this.Load += new System.EventHandler(this.uiKomponenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingNavigator)).EndInit();
            this.komponentaBindingNavigator.ResumeLayout(false);
            this.komponentaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataKoponenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource komponentaBindingSource;
        private Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter komponentaTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator komponentaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton komponentaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView uiOutputTableDataKoponenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button uiActionObrišiKomponenta;
        private System.Windows.Forms.Button uiActionUrediKomponenta;
        private System.Windows.Forms.Button uiActionDodajNoviKomponenta;
    }
}