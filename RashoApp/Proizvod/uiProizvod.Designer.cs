namespace RashoApp.Proizvod
{
    partial class uiProizvod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiProizvod));
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.proizvodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.proizvodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.uiOutputDataProizvod = new System.Windows.Forms.DataGridView();
            this.uiActionObrišiProizvod = new System.Windows.Forms.Button();
            this.uiActionUrediProizvod = new System.Windows.Forms.Button();
            this.uiActionDodajNoviProizvod = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingNavigator)).BeginInit();
            this.proizvodBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDataProizvod)).BeginInit();
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
            // proizvodBindingNavigator
            // 
            this.proizvodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.proizvodBindingNavigator.BindingSource = this.proizvodBindingSource;
            this.proizvodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.proizvodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.proizvodBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.proizvodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.proizvodBindingNavigatorSaveItem});
            this.proizvodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proizvodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.proizvodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.proizvodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.proizvodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.proizvodBindingNavigator.Name = "proizvodBindingNavigator";
            this.proizvodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.proizvodBindingNavigator.Size = new System.Drawing.Size(802, 27);
            this.proizvodBindingNavigator.TabIndex = 0;
            this.proizvodBindingNavigator.Text = "bindingNavigator1";
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
            // proizvodBindingNavigatorSaveItem
            // 
            this.proizvodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proizvodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proizvodBindingNavigatorSaveItem.Image")));
            this.proizvodBindingNavigatorSaveItem.Name = "proizvodBindingNavigatorSaveItem";
            this.proizvodBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.proizvodBindingNavigatorSaveItem.Text = "Save Data";
            this.proizvodBindingNavigatorSaveItem.Click += new System.EventHandler(this.proizvodBindingNavigatorSaveItem_Click);
            // 
            // uiOutputDataProizvod
            // 
            this.uiOutputDataProizvod.AllowUserToAddRows = false;
            this.uiOutputDataProizvod.AllowUserToDeleteRows = false;
            this.uiOutputDataProizvod.AutoGenerateColumns = false;
            this.uiOutputDataProizvod.BackgroundColor = System.Drawing.Color.White;
            this.uiOutputDataProizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputDataProizvod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.uiOutputDataProizvod.DataSource = this.proizvodBindingSource;
            this.uiOutputDataProizvod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiOutputDataProizvod.Location = new System.Drawing.Point(0, 27);
            this.uiOutputDataProizvod.MultiSelect = false;
            this.uiOutputDataProizvod.Name = "uiOutputDataProizvod";
            this.uiOutputDataProizvod.ReadOnly = true;
            this.uiOutputDataProizvod.RowTemplate.Height = 24;
            this.uiOutputDataProizvod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputDataProizvod.Size = new System.Drawing.Size(802, 481);
            this.uiOutputDataProizvod.TabIndex = 1;
            // 
            // uiActionObrišiProizvod
            // 
            this.uiActionObrišiProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionObrišiProizvod.BackColor = System.Drawing.Color.Crimson;
            this.uiActionObrišiProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionObrišiProizvod.ForeColor = System.Drawing.Color.White;
            this.uiActionObrišiProizvod.Location = new System.Drawing.Point(693, 443);
            this.uiActionObrišiProizvod.Name = "uiActionObrišiProizvod";
            this.uiActionObrišiProizvod.Size = new System.Drawing.Size(97, 39);
            this.uiActionObrišiProizvod.TabIndex = 12;
            this.uiActionObrišiProizvod.Text = "Obriši";
            this.uiActionObrišiProizvod.UseVisualStyleBackColor = false;
            this.uiActionObrišiProizvod.Click += new System.EventHandler(this.uiActionObrišiProizvod_Click);
            // 
            // uiActionUrediProizvod
            // 
            this.uiActionUrediProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionUrediProizvod.BackColor = System.Drawing.Color.Gold;
            this.uiActionUrediProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionUrediProizvod.ForeColor = System.Drawing.Color.White;
            this.uiActionUrediProizvod.Location = new System.Drawing.Point(563, 443);
            this.uiActionUrediProizvod.Name = "uiActionUrediProizvod";
            this.uiActionUrediProizvod.Size = new System.Drawing.Size(97, 39);
            this.uiActionUrediProizvod.TabIndex = 11;
            this.uiActionUrediProizvod.Text = "Uredi";
            this.uiActionUrediProizvod.UseVisualStyleBackColor = false;
            this.uiActionUrediProizvod.Click += new System.EventHandler(this.uiActionUrediProizvod_Click);
            // 
            // uiActionDodajNoviProizvod
            // 
            this.uiActionDodajNoviProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionDodajNoviProizvod.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionDodajNoviProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDodajNoviProizvod.ForeColor = System.Drawing.Color.White;
            this.uiActionDodajNoviProizvod.Location = new System.Drawing.Point(436, 443);
            this.uiActionDodajNoviProizvod.Name = "uiActionDodajNoviProizvod";
            this.uiActionDodajNoviProizvod.Size = new System.Drawing.Size(97, 39);
            this.uiActionDodajNoviProizvod.TabIndex = 10;
            this.uiActionDodajNoviProizvod.Text = "Dodaj";
            this.uiActionDodajNoviProizvod.UseVisualStyleBackColor = false;
            this.uiActionDodajNoviProizvod.Click += new System.EventHandler(this.uiActionDodajNoviProizvod_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "naziv";
            this.dataGridViewTextBoxColumn6.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "duljina";
            this.dataGridViewTextBoxColumn2.HeaderText = "Duljina";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sirina";
            this.dataGridViewTextBoxColumn3.HeaderText = "Širina";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "visina";
            this.dataGridViewTextBoxColumn4.HeaderText = "Visina";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "slika";
            this.dataGridViewTextBoxColumn5.HeaderText = "Slika";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // uiProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 508);
            this.Controls.Add(this.uiActionObrišiProizvod);
            this.Controls.Add(this.uiActionUrediProizvod);
            this.Controls.Add(this.uiActionDodajNoviProizvod);
            this.Controls.Add(this.uiOutputDataProizvod);
            this.Controls.Add(this.proizvodBindingNavigator);
            this.Name = "uiProizvod";
            this.Text = "uiProizvod";
            this.Load += new System.EventHandler(this.uiProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingNavigator)).EndInit();
            this.proizvodBindingNavigator.ResumeLayout(false);
            this.proizvodBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDataProizvod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource proizvodBindingSource;
        private Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter proizvodTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator proizvodBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton proizvodBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView uiOutputDataProizvod;
        private System.Windows.Forms.Button uiActionObrišiProizvod;
        private System.Windows.Forms.Button uiActionUrediProizvod;
        private System.Windows.Forms.Button uiActionDodajNoviProizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}