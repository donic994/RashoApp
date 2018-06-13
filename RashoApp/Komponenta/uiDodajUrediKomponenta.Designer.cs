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
            this.uiActionSpremiKomponenta = new System.Windows.Forms.Button();
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.komponentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komponentaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
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
            this.SuspendLayout();
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(53, 61);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(61, 17);
            kolicinaLabel.TabIndex = 9;
            kolicinaLabel.Text = "Količina:";
            // 
            // bojaLabel
            // 
            bojaLabel.AutoSize = true;
            bojaLabel.Location = new System.Drawing.Point(74, 89);
            bojaLabel.Name = "bojaLabel";
            bojaLabel.Size = new System.Drawing.Size(40, 17);
            bojaLabel.TabIndex = 10;
            bojaLabel.Text = "Boja:";
            // 
            // kantiranostLabel
            // 
            kantiranostLabel.AutoSize = true;
            kantiranostLabel.Location = new System.Drawing.Point(30, 117);
            kantiranostLabel.Name = "kantiranostLabel";
            kantiranostLabel.Size = new System.Drawing.Size(84, 17);
            kantiranostLabel.TabIndex = 11;
            kantiranostLabel.Text = "Kantiranost:";
            // 
            // id_ulogaLabel
            // 
            id_ulogaLabel.AutoSize = true;
            id_ulogaLabel.Location = new System.Drawing.Point(65, 145);
            id_ulogaLabel.Name = "id_ulogaLabel";
            id_ulogaLabel.Size = new System.Drawing.Size(49, 17);
            id_ulogaLabel.TabIndex = 12;
            id_ulogaLabel.Text = "Uloga:";
            // 
            // id_dioLabel
            // 
            id_dioLabel.AutoSize = true;
            id_dioLabel.Location = new System.Drawing.Point(81, 171);
            id_dioLabel.Name = "id_dioLabel";
            id_dioLabel.Size = new System.Drawing.Size(33, 17);
            id_dioLabel.TabIndex = 13;
            id_dioLabel.Text = "Dio:";
            // 
            // id_proizvodLabel
            // 
            id_proizvodLabel.AutoSize = true;
            id_proizvodLabel.Location = new System.Drawing.Point(47, 199);
            id_proizvodLabel.Name = "id_proizvodLabel";
            id_proizvodLabel.Size = new System.Drawing.Size(67, 17);
            id_proizvodLabel.TabIndex = 14;
            id_proizvodLabel.Text = "Proizvod:";
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
            this.Controls.Add(this.uiActionSpremiKomponenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "uiDodajUrediKomponenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.uiDodajUrediKomponenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionSpremiKomponenta;
        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource komponentaBindingSource;
        private Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter komponentaTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox uiInputKomponentaKolicina;
        private System.Windows.Forms.TextBox uiInputKomponentaBoja;
        private System.Windows.Forms.TextBox uiInputKomponentaKantoranost;
        private System.Windows.Forms.TextBox uiInputKomponentaUloga;
        private System.Windows.Forms.TextBox uiInputKomponentaDio;
        private System.Windows.Forms.TextBox uiInputKomponentaProizvod;
    }
}