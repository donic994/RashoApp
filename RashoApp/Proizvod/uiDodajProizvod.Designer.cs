namespace RashoApp.Proizvod
{
    partial class uiDodajProizvod
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
            System.Windows.Forms.Label duljinaLabel;
            System.Windows.Forms.Label sirinaLabel;
            System.Windows.Forms.Label visinaLabel;
            System.Windows.Forms.Label slikaLabel;
            System.Windows.Forms.Label nazivLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiDodajProizvod));
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.uiInputDužina = new System.Windows.Forms.TextBox();
            this.uiInputŠirina = new System.Windows.Forms.TextBox();
            this.uiInputDubina = new System.Windows.Forms.TextBox();
            this.uiInputSlika = new System.Windows.Forms.TextBox();
            this.uiInputNaziv = new System.Windows.Forms.TextBox();
            this.uiActionDalje = new System.Windows.Forms.Button();
            duljinaLabel = new System.Windows.Forms.Label();
            sirinaLabel = new System.Windows.Forms.Label();
            visinaLabel = new System.Windows.Forms.Label();
            slikaLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // duljinaLabel
            // 
            duljinaLabel.AutoSize = true;
            duljinaLabel.Location = new System.Drawing.Point(134, 98);
            duljinaLabel.Name = "duljinaLabel";
            duljinaLabel.Size = new System.Drawing.Size(58, 18);
            duljinaLabel.TabIndex = 1;
            duljinaLabel.Text = "Dužina:";
            // 
            // sirinaLabel
            // 
            sirinaLabel.AutoSize = true;
            sirinaLabel.Location = new System.Drawing.Point(143, 129);
            sirinaLabel.Name = "sirinaLabel";
            sirinaLabel.Size = new System.Drawing.Size(49, 18);
            sirinaLabel.TabIndex = 3;
            sirinaLabel.Text = "Širina:";
            // 
            // visinaLabel
            // 
            visinaLabel.AutoSize = true;
            visinaLabel.Location = new System.Drawing.Point(133, 161);
            visinaLabel.Name = "visinaLabel";
            visinaLabel.Size = new System.Drawing.Size(58, 18);
            visinaLabel.TabIndex = 5;
            visinaLabel.Text = "Dubina:";
            // 
            // slikaLabel
            // 
            slikaLabel.AutoSize = true;
            slikaLabel.Location = new System.Drawing.Point(150, 192);
            slikaLabel.Name = "slikaLabel";
            slikaLabel.Size = new System.Drawing.Size(44, 18);
            slikaLabel.TabIndex = 7;
            slikaLabel.Text = "Slika:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(144, 66);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(49, 18);
            nazivLabel.TabIndex = 9;
            nazivLabel.Text = "Naziv:";
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
            // uiInputDužina
            // 
            this.uiInputDužina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "duljina", true));
            this.uiInputDužina.Location = new System.Drawing.Point(204, 94);
            this.uiInputDužina.Name = "uiInputDužina";
            this.uiInputDužina.Size = new System.Drawing.Size(112, 24);
            this.uiInputDužina.TabIndex = 3;
            // 
            // uiInputŠirina
            // 
            this.uiInputŠirina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "sirina", true));
            this.uiInputŠirina.Location = new System.Drawing.Point(204, 126);
            this.uiInputŠirina.Name = "uiInputŠirina";
            this.uiInputŠirina.Size = new System.Drawing.Size(112, 24);
            this.uiInputŠirina.TabIndex = 4;
            // 
            // uiInputDubina
            // 
            this.uiInputDubina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "visina", true));
            this.uiInputDubina.Location = new System.Drawing.Point(204, 158);
            this.uiInputDubina.Name = "uiInputDubina";
            this.uiInputDubina.Size = new System.Drawing.Size(112, 24);
            this.uiInputDubina.TabIndex = 6;
            // 
            // uiInputSlika
            // 
            this.uiInputSlika.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "slika", true));
            this.uiInputSlika.Location = new System.Drawing.Point(204, 189);
            this.uiInputSlika.Name = "uiInputSlika";
            this.uiInputSlika.Size = new System.Drawing.Size(112, 24);
            this.uiInputSlika.TabIndex = 8;
            // 
            // uiInputNaziv
            // 
            this.uiInputNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "naziv", true));
            this.uiInputNaziv.Location = new System.Drawing.Point(204, 63);
            this.uiInputNaziv.Name = "uiInputNaziv";
            this.uiInputNaziv.Size = new System.Drawing.Size(112, 24);
            this.uiInputNaziv.TabIndex = 2;
            // 
            // uiActionDalje
            // 
            this.uiActionDalje.BackColor = System.Drawing.Color.DarkTurquoise;
            this.uiActionDalje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDalje.ForeColor = System.Drawing.Color.White;
            this.uiActionDalje.Location = new System.Drawing.Point(385, 310);
            this.uiActionDalje.Name = "uiActionDalje";
            this.uiActionDalje.Size = new System.Drawing.Size(135, 51);
            this.uiActionDalje.TabIndex = 11;
            this.uiActionDalje.Text = "DALJE";
            this.uiActionDalje.UseVisualStyleBackColor = false;
            this.uiActionDalje.Click += new System.EventHandler(this.uiActionDalje_Click);
            // 
            // uiDodajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 373);
            this.Controls.Add(this.uiActionDalje);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.uiInputNaziv);
            this.Controls.Add(slikaLabel);
            this.Controls.Add(this.uiInputSlika);
            this.Controls.Add(visinaLabel);
            this.Controls.Add(this.uiInputDubina);
            this.Controls.Add(sirinaLabel);
            this.Controls.Add(this.uiInputŠirina);
            this.Controls.Add(duljinaLabel);
            this.Controls.Add(this.uiInputDužina);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uiDodajProizvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj novi proizvod";
            this.Load += new System.EventHandler(this.uiDodajProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource proizvodBindingSource;
        private Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter proizvodTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox uiInputDužina;
        private System.Windows.Forms.TextBox uiInputŠirina;
        private System.Windows.Forms.TextBox uiInputDubina;
        private System.Windows.Forms.TextBox uiInputSlika;
        private System.Windows.Forms.TextBox uiInputNaziv;
        private System.Windows.Forms.Button uiActionDalje;
    }
}