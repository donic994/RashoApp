namespace RashoApp.Element
{
    partial class uiDodajUrediElement
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
            System.Windows.Forms.Label kolicinaLabel;
            System.Windows.Forms.Label id_proizvodLabel;
            System.Windows.Forms.Label id_elementLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiDodajUrediElement));
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
            this.kolicinaTextBox = new System.Windows.Forms.TextBox();
            this.id_proizvodComboBox = new System.Windows.Forms.ComboBox();
            this.id_elementTextBox = new System.Windows.Forms.TextBox();
            this.uiActionSpremiElement = new System.Windows.Forms.Button();
            kolicinaLabel = new System.Windows.Forms.Label();
            id_proizvodLabel = new System.Windows.Forms.Label();
            id_elementLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingNavigator)).BeginInit();
            this.elementBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(67, 65);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(61, 17);
            kolicinaLabel.TabIndex = 1;
            kolicinaLabel.Text = "Količina:";
            // 
            // id_proizvodLabel
            // 
            id_proizvodLabel.AutoSize = true;
            id_proizvodLabel.Location = new System.Drawing.Point(61, 93);
            id_proizvodLabel.Name = "id_proizvodLabel";
            id_proizvodLabel.Size = new System.Drawing.Size(67, 17);
            id_proizvodLabel.TabIndex = 3;
            id_proizvodLabel.Text = "Proizvod:";
            // 
            // id_elementLabel
            // 
            id_elementLabel.AutoSize = true;
            id_elementLabel.Location = new System.Drawing.Point(49, 123);
            id_elementLabel.Name = "id_elementLabel";
            id_elementLabel.Size = new System.Drawing.Size(79, 17);
            id_elementLabel.TabIndex = 5;
            id_elementLabel.Text = "ID element:";
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
            this.elementBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
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
            this.elementBindingNavigator.Size = new System.Drawing.Size(317, 27);
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
            // kolicinaTextBox
            // 
            this.kolicinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.elementBindingSource, "kolicina", true));
            this.kolicinaTextBox.Location = new System.Drawing.Point(134, 62);
            this.kolicinaTextBox.Name = "kolicinaTextBox";
            this.kolicinaTextBox.Size = new System.Drawing.Size(100, 22);
            this.kolicinaTextBox.TabIndex = 2;
            // 
            // id_proizvodComboBox
            // 
            this.id_proizvodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.elementBindingSource, "id_proizvod", true));
            this.id_proizvodComboBox.DataSource = this.elementBindingSource;
            this.id_proizvodComboBox.DisplayMember = "id_proizvod";
            this.id_proizvodComboBox.FormattingEnabled = true;
            this.id_proizvodComboBox.Location = new System.Drawing.Point(134, 90);
            this.id_proizvodComboBox.Name = "id_proizvodComboBox";
            this.id_proizvodComboBox.Size = new System.Drawing.Size(100, 24);
            this.id_proizvodComboBox.TabIndex = 4;
            this.id_proizvodComboBox.ValueMember = "id_proizvod";
            // 
            // id_elementTextBox
            // 
            this.id_elementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.elementBindingSource, "id_element", true));
            this.id_elementTextBox.Location = new System.Drawing.Point(134, 120);
            this.id_elementTextBox.Name = "id_elementTextBox";
            this.id_elementTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_elementTextBox.TabIndex = 6;
            // 
            // uiActionSpremiElement
            // 
            this.uiActionSpremiElement.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionSpremiElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionSpremiElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionSpremiElement.ForeColor = System.Drawing.Color.White;
            this.uiActionSpremiElement.Location = new System.Drawing.Point(100, 172);
            this.uiActionSpremiElement.Name = "uiActionSpremiElement";
            this.uiActionSpremiElement.Size = new System.Drawing.Size(112, 51);
            this.uiActionSpremiElement.TabIndex = 8;
            this.uiActionSpremiElement.Text = "Spremi";
            this.uiActionSpremiElement.UseVisualStyleBackColor = false;
            // 
            // uiDodajUrediElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 235);
            this.Controls.Add(this.uiActionSpremiElement);
            this.Controls.Add(id_elementLabel);
            this.Controls.Add(this.id_elementTextBox);
            this.Controls.Add(id_proizvodLabel);
            this.Controls.Add(this.id_proizvodComboBox);
            this.Controls.Add(kolicinaLabel);
            this.Controls.Add(this.kolicinaTextBox);
            this.Controls.Add(this.elementBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "uiDodajUrediElement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uiDodajUediElement";
            this.Load += new System.EventHandler(this.uiDodajUediElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingNavigator)).EndInit();
            this.elementBindingNavigator.ResumeLayout(false);
            this.elementBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox kolicinaTextBox;
        private System.Windows.Forms.ComboBox id_proizvodComboBox;
        private System.Windows.Forms.TextBox id_elementTextBox;
        private System.Windows.Forms.Button uiActionSpremiElement;
    }
}