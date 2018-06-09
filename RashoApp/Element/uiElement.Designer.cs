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
            this.elementBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.elementBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.elementDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiActionObrišiDio = new System.Windows.Forms.Button();
            this.uiActionUrediDio = new System.Windows.Forms.Button();
            this.uiActionDodajNoviDio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingNavigator)).BeginInit();
            this.elementBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementDataGridView)).BeginInit();
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
            // elementBindingNavigator
            // 
            this.elementBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.elementBindingNavigator.BindingSource = this.elementBindingSource;
            this.elementBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.elementBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.elementBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.elementBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.elementBindingNavigatorSaveItem});
            this.elementBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.elementBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.elementBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.elementBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.elementBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.elementBindingNavigator.Name = "elementBindingNavigator";
            this.elementBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.elementBindingNavigator.Size = new System.Drawing.Size(802, 27);
            this.elementBindingNavigator.TabIndex = 0;
            this.elementBindingNavigator.Text = "bindingNavigator1";
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
            // elementBindingNavigatorSaveItem
            // 
            this.elementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.elementBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("elementBindingNavigatorSaveItem.Image")));
            this.elementBindingNavigatorSaveItem.Name = "elementBindingNavigatorSaveItem";
            this.elementBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.elementBindingNavigatorSaveItem.Text = "Save Data";
            this.elementBindingNavigatorSaveItem.Click += new System.EventHandler(this.elementBindingNavigatorSaveItem_Click);
            // 
            // elementDataGridView
            // 
            this.elementDataGridView.AutoGenerateColumns = false;
            this.elementDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.elementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.elementDataGridView.DataSource = this.elementBindingSource;
            this.elementDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementDataGridView.Location = new System.Drawing.Point(0, 27);
            this.elementDataGridView.Name = "elementDataGridView";
            this.elementDataGridView.RowTemplate.Height = 24;
            this.elementDataGridView.Size = new System.Drawing.Size(802, 481);
            this.elementDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kolicina";
            this.dataGridViewTextBoxColumn1.HeaderText = "kolicina";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_proizvod";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_proizvod";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_element";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_element";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            this.uiActionObrišiDio.TabIndex = 6;
            this.uiActionObrišiDio.Text = "Obriši";
            this.uiActionObrišiDio.UseVisualStyleBackColor = false;
            this.uiActionObrišiDio.Click += new System.EventHandler(this.uiActionObrišiDio_Click);
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
            this.uiActionUrediDio.TabIndex = 5;
            this.uiActionUrediDio.Text = "Uredi";
            this.uiActionUrediDio.UseVisualStyleBackColor = false;
            this.uiActionUrediDio.Click += new System.EventHandler(this.uiActionUrediDio_Click);
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
            this.uiActionDodajNoviDio.TabIndex = 4;
            this.uiActionDodajNoviDio.Text = "Dodaj";
            this.uiActionDodajNoviDio.UseVisualStyleBackColor = false;
            this.uiActionDodajNoviDio.Click += new System.EventHandler(this.uiActionDodajNoviDio_Click);
            // 
            // uiElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 508);
            this.Controls.Add(this.uiActionObrišiDio);
            this.Controls.Add(this.uiActionUrediDio);
            this.Controls.Add(this.uiActionDodajNoviDio);
            this.Controls.Add(this.elementDataGridView);
            this.Controls.Add(this.elementBindingNavigator);
            this.Name = "uiElement";
            this.Text = "uiElement";
            this.Load += new System.EventHandler(this.uiElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingNavigator)).EndInit();
            this.elementBindingNavigator.ResumeLayout(false);
            this.elementBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource elementBindingSource;
        private Baza18043_DBDataSetTableAdapters.ElementTableAdapter elementTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator elementBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton elementBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView elementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button uiActionObrišiDio;
        private System.Windows.Forms.Button uiActionUrediDio;
        private System.Windows.Forms.Button uiActionDodajNoviDio;
    }
}