namespace RashoApp.Komponenta
{
    partial class uiDodajUrediKomponenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiDodajUrediKomponenta));
            System.Windows.Forms.Label kolicinaLabel;
            System.Windows.Forms.Label bojaLabel;
            System.Windows.Forms.Label kantiranostLabel;
            System.Windows.Forms.Label id_ulogaLabel;
            System.Windows.Forms.Label id_dioLabel;
            System.Windows.Forms.Label id_proizvodLabel;
            this.uiActionSpremiKomponenta = new System.Windows.Forms.Button();
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.komponentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komponentaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.komponentaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.komponentaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kolicinaTextBox = new System.Windows.Forms.TextBox();
            this.bojaTextBox = new System.Windows.Forms.TextBox();
            this.kantiranostTextBox = new System.Windows.Forms.TextBox();
            this.id_ulogaTextBox = new System.Windows.Forms.TextBox();
            this.id_dioTextBox = new System.Windows.Forms.TextBox();
            this.id_proizvodTextBox = new System.Windows.Forms.TextBox();
            kolicinaLabel = new System.Windows.Forms.Label();
            bojaLabel = new System.Windows.Forms.Label();
            kantiranostLabel = new System.Windows.Forms.Label();
            id_ulogaLabel = new System.Windows.Forms.Label();
            id_dioLabel = new System.Windows.Forms.Label();
            id_proizvodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingNavigator)).BeginInit();
            this.komponentaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiActionSpremiKomponenta
            // 
            this.uiActionSpremiKomponenta.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionSpremiKomponenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionSpremiKomponenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionSpremiKomponenta.ForeColor = System.Drawing.Color.White;
            this.uiActionSpremiKomponenta.Location = new System.Drawing.Point(94, 249);
            this.uiActionSpremiKomponenta.Name = "uiActionSpremiKomponenta";
            this.uiActionSpremiKomponenta.Size = new System.Drawing.Size(112, 51);
            this.uiActionSpremiKomponenta.TabIndex = 8;
            this.uiActionSpremiKomponenta.Text = "Spremi";
            this.uiActionSpremiKomponenta.UseVisualStyleBackColor = false;
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
            this.komponentaBindingNavigator.Size = new System.Drawing.Size(297, 27);
            this.komponentaBindingNavigator.TabIndex = 9;
            this.komponentaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // komponentaBindingNavigatorSaveItem
            // 
            this.komponentaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.komponentaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("komponentaBindingNavigatorSaveItem.Image")));
            this.komponentaBindingNavigatorSaveItem.Name = "komponentaBindingNavigatorSaveItem";
            this.komponentaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.komponentaBindingNavigatorSaveItem.Text = "Save Data";
            this.komponentaBindingNavigatorSaveItem.Click += new System.EventHandler(this.komponentaBindingNavigatorSaveItem_Click);
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(55, 59);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(59, 17);
            kolicinaLabel.TabIndex = 9;
            kolicinaLabel.Text = "kolicina:";
            // 
            // kolicinaTextBox
            // 
            this.kolicinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "kolicina", true));
            this.kolicinaTextBox.Location = new System.Drawing.Point(120, 56);
            this.kolicinaTextBox.Name = "kolicinaTextBox";
            this.kolicinaTextBox.Size = new System.Drawing.Size(100, 22);
            this.kolicinaTextBox.TabIndex = 10;
            // 
            // bojaLabel
            // 
            bojaLabel.AutoSize = true;
            bojaLabel.Location = new System.Drawing.Point(75, 87);
            bojaLabel.Name = "bojaLabel";
            bojaLabel.Size = new System.Drawing.Size(39, 17);
            bojaLabel.TabIndex = 10;
            bojaLabel.Text = "boja:";
            // 
            // bojaTextBox
            // 
            this.bojaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "boja", true));
            this.bojaTextBox.Location = new System.Drawing.Point(120, 84);
            this.bojaTextBox.Name = "bojaTextBox";
            this.bojaTextBox.Size = new System.Drawing.Size(100, 22);
            this.bojaTextBox.TabIndex = 11;
            // 
            // kantiranostLabel
            // 
            kantiranostLabel.AutoSize = true;
            kantiranostLabel.Location = new System.Drawing.Point(32, 115);
            kantiranostLabel.Name = "kantiranostLabel";
            kantiranostLabel.Size = new System.Drawing.Size(82, 17);
            kantiranostLabel.TabIndex = 11;
            kantiranostLabel.Text = "kantiranost:";
            // 
            // kantiranostTextBox
            // 
            this.kantiranostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "kantiranost", true));
            this.kantiranostTextBox.Location = new System.Drawing.Point(120, 112);
            this.kantiranostTextBox.Name = "kantiranostTextBox";
            this.kantiranostTextBox.Size = new System.Drawing.Size(100, 22);
            this.kantiranostTextBox.TabIndex = 12;
            // 
            // id_ulogaLabel
            // 
            id_ulogaLabel.AutoSize = true;
            id_ulogaLabel.Location = new System.Drawing.Point(52, 143);
            id_ulogaLabel.Name = "id_ulogaLabel";
            id_ulogaLabel.Size = new System.Drawing.Size(62, 17);
            id_ulogaLabel.TabIndex = 12;
            id_ulogaLabel.Text = "id uloga:";
            // 
            // id_ulogaTextBox
            // 
            this.id_ulogaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "id_uloga", true));
            this.id_ulogaTextBox.Location = new System.Drawing.Point(120, 140);
            this.id_ulogaTextBox.Name = "id_ulogaTextBox";
            this.id_ulogaTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_ulogaTextBox.TabIndex = 13;
            // 
            // id_dioLabel
            // 
            id_dioLabel.AutoSize = true;
            id_dioLabel.Location = new System.Drawing.Point(68, 171);
            id_dioLabel.Name = "id_dioLabel";
            id_dioLabel.Size = new System.Drawing.Size(46, 17);
            id_dioLabel.TabIndex = 13;
            id_dioLabel.Text = "id dio:";
            // 
            // id_dioTextBox
            // 
            this.id_dioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "id_dio", true));
            this.id_dioTextBox.Location = new System.Drawing.Point(120, 168);
            this.id_dioTextBox.Name = "id_dioTextBox";
            this.id_dioTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_dioTextBox.TabIndex = 14;
            // 
            // id_proizvodLabel
            // 
            id_proizvodLabel.AutoSize = true;
            id_proizvodLabel.Location = new System.Drawing.Point(33, 199);
            id_proizvodLabel.Name = "id_proizvodLabel";
            id_proizvodLabel.Size = new System.Drawing.Size(81, 17);
            id_proizvodLabel.TabIndex = 14;
            id_proizvodLabel.Text = "id proizvod:";
            // 
            // id_proizvodTextBox
            // 
            this.id_proizvodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "id_proizvod", true));
            this.id_proizvodTextBox.Location = new System.Drawing.Point(120, 196);
            this.id_proizvodTextBox.Name = "id_proizvodTextBox";
            this.id_proizvodTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_proizvodTextBox.TabIndex = 15;
            // 
            // uiDodajUrediKomponenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 325);
            this.Controls.Add(id_proizvodLabel);
            this.Controls.Add(this.id_proizvodTextBox);
            this.Controls.Add(id_dioLabel);
            this.Controls.Add(this.id_dioTextBox);
            this.Controls.Add(id_ulogaLabel);
            this.Controls.Add(this.id_ulogaTextBox);
            this.Controls.Add(kantiranostLabel);
            this.Controls.Add(this.kantiranostTextBox);
            this.Controls.Add(bojaLabel);
            this.Controls.Add(this.bojaTextBox);
            this.Controls.Add(kolicinaLabel);
            this.Controls.Add(this.kolicinaTextBox);
            this.Controls.Add(this.komponentaBindingNavigator);
            this.Controls.Add(this.uiActionSpremiKomponenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "uiDodajUrediKomponenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.uiDodajUrediKomponenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingNavigator)).EndInit();
            this.komponentaBindingNavigator.ResumeLayout(false);
            this.komponentaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionSpremiKomponenta;
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
        private System.Windows.Forms.TextBox kolicinaTextBox;
        private System.Windows.Forms.TextBox bojaTextBox;
        private System.Windows.Forms.TextBox kantiranostTextBox;
        private System.Windows.Forms.TextBox id_ulogaTextBox;
        private System.Windows.Forms.TextBox id_dioTextBox;
        private System.Windows.Forms.TextBox id_proizvodTextBox;
    }
}