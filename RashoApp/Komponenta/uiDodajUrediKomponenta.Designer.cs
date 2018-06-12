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
            System.Windows.Forms.Label kolicinaLabel;
            System.Windows.Forms.Label bojaLabel;
            System.Windows.Forms.Label kantiranostLabel;
            System.Windows.Forms.Label id_ulogaLabel;
            System.Windows.Forms.Label id_dioLabel;
            System.Windows.Forms.Label id_proizvodLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiDodajUrediKomponenta));
            this.uiActionSpremiKomponenta = new System.Windows.Forms.Button();
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
            this.uiInputKomponentaKolicina = new System.Windows.Forms.TextBox();
            this.uiInputKomponentaBoja = new System.Windows.Forms.TextBox();
            this.uiInputKomponentaKantoranost = new System.Windows.Forms.TextBox();
            this.uiInputKomponentaUloga = new System.Windows.Forms.TextBox();
            this.uiInputKomponentaDio = new System.Windows.Forms.TextBox();
            this.uiInputKomponentaProizvod = new System.Windows.Forms.TextBox();
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
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(55, 59);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(59, 17);
            kolicinaLabel.TabIndex = 9;
            kolicinaLabel.Text = "kolicina:";
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
            // kantiranostLabel
            // 
            kantiranostLabel.AutoSize = true;
            kantiranostLabel.Location = new System.Drawing.Point(32, 115);
            kantiranostLabel.Name = "kantiranostLabel";
            kantiranostLabel.Size = new System.Drawing.Size(82, 17);
            kantiranostLabel.TabIndex = 11;
            kantiranostLabel.Text = "kantiranost:";
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
            // id_dioLabel
            // 
            id_dioLabel.AutoSize = true;
            id_dioLabel.Location = new System.Drawing.Point(68, 171);
            id_dioLabel.Name = "id_dioLabel";
            id_dioLabel.Size = new System.Drawing.Size(46, 17);
            id_dioLabel.TabIndex = 13;
            id_dioLabel.Text = "id dio:";
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
            this.uiActionSpremiKomponenta.Click += new System.EventHandler(this.uiActionSpremiKomponenta_Click);
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
            // uiInputKomponentaKolicina
            // 
            this.uiInputKomponentaKolicina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "kolicina", true));
            this.uiInputKomponentaKolicina.Location = new System.Drawing.Point(120, 56);
            this.uiInputKomponentaKolicina.Name = "uiInputKomponentaKolicina";
            this.uiInputKomponentaKolicina.Size = new System.Drawing.Size(100, 22);
            this.uiInputKomponentaKolicina.TabIndex = 10;
            // 
            // uiInputKomponentaBoja
            // 
            this.uiInputKomponentaBoja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "boja", true));
            this.uiInputKomponentaBoja.Location = new System.Drawing.Point(120, 84);
            this.uiInputKomponentaBoja.Name = "uiInputKomponentaBoja";
            this.uiInputKomponentaBoja.Size = new System.Drawing.Size(100, 22);
            this.uiInputKomponentaBoja.TabIndex = 11;
            // 
            // uiInputKomponentaKantoranost
            // 
            this.uiInputKomponentaKantoranost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "kantiranost", true));
            this.uiInputKomponentaKantoranost.Location = new System.Drawing.Point(120, 112);
            this.uiInputKomponentaKantoranost.Name = "uiInputKomponentaKantoranost";
            this.uiInputKomponentaKantoranost.Size = new System.Drawing.Size(100, 22);
            this.uiInputKomponentaKantoranost.TabIndex = 12;
            // 
            // uiInputKomponentaUloga
            // 
            this.uiInputKomponentaUloga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "id_uloga", true));
            this.uiInputKomponentaUloga.Location = new System.Drawing.Point(120, 140);
            this.uiInputKomponentaUloga.Name = "uiInputKomponentaUloga";
            this.uiInputKomponentaUloga.Size = new System.Drawing.Size(100, 22);
            this.uiInputKomponentaUloga.TabIndex = 13;
            // 
            // uiInputKomponentaDio
            // 
            this.uiInputKomponentaDio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "id_dio", true));
            this.uiInputKomponentaDio.Location = new System.Drawing.Point(120, 168);
            this.uiInputKomponentaDio.Name = "uiInputKomponentaDio";
            this.uiInputKomponentaDio.Size = new System.Drawing.Size(100, 22);
            this.uiInputKomponentaDio.TabIndex = 14;
            // 
            // uiInputKomponentaProizvod
            // 
            this.uiInputKomponentaProizvod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komponentaBindingSource, "id_proizvod", true));
            this.uiInputKomponentaProizvod.Location = new System.Drawing.Point(120, 196);
            this.uiInputKomponentaProizvod.Name = "uiInputKomponentaProizvod";
            this.uiInputKomponentaProizvod.Size = new System.Drawing.Size(100, 22);
            this.uiInputKomponentaProizvod.TabIndex = 15;
            // 
            // uiDodajUrediKomponenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 325);
            this.Controls.Add(id_proizvodLabel);
            this.Controls.Add(this.uiInputKomponentaProizvod);
            this.Controls.Add(id_dioLabel);
            this.Controls.Add(this.uiInputKomponentaDio);
            this.Controls.Add(id_ulogaLabel);
            this.Controls.Add(this.uiInputKomponentaUloga);
            this.Controls.Add(kantiranostLabel);
            this.Controls.Add(this.uiInputKomponentaKantoranost);
            this.Controls.Add(bojaLabel);
            this.Controls.Add(this.uiInputKomponentaBoja);
            this.Controls.Add(kolicinaLabel);
            this.Controls.Add(this.uiInputKomponentaKolicina);
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
        private System.Windows.Forms.TextBox uiInputKomponentaKolicina;
        private System.Windows.Forms.TextBox uiInputKomponentaBoja;
        private System.Windows.Forms.TextBox uiInputKomponentaKantoranost;
        private System.Windows.Forms.TextBox uiInputKomponentaUloga;
        private System.Windows.Forms.TextBox uiInputKomponentaDio;
        private System.Windows.Forms.TextBox uiInputKomponentaProizvod;
    }
}