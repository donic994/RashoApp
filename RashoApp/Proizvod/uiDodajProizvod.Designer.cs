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
            // duljinaLabel
            // 
            duljinaLabel.AutoSize = true;
            duljinaLabel.Location = new System.Drawing.Point(119, 87);
            duljinaLabel.Name = "duljinaLabel";
            duljinaLabel.Size = new System.Drawing.Size(56, 17);
            duljinaLabel.TabIndex = 1;
            duljinaLabel.Text = "Dužina:";
            // 
            // uiInputDužina
            // 
            this.uiInputDužina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "duljina", true));
            this.uiInputDužina.Location = new System.Drawing.Point(181, 84);
            this.uiInputDužina.Name = "uiInputDužina";
            this.uiInputDužina.Size = new System.Drawing.Size(100, 22);
            this.uiInputDužina.TabIndex = 2;
            // 
            // sirinaLabel
            // 
            sirinaLabel.AutoSize = true;
            sirinaLabel.Location = new System.Drawing.Point(127, 115);
            sirinaLabel.Name = "sirinaLabel";
            sirinaLabel.Size = new System.Drawing.Size(48, 17);
            sirinaLabel.TabIndex = 3;
            sirinaLabel.Text = "Širina:";
            // 
            // uiInputŠirina
            // 
            this.uiInputŠirina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "sirina", true));
            this.uiInputŠirina.Location = new System.Drawing.Point(181, 112);
            this.uiInputŠirina.Name = "uiInputŠirina";
            this.uiInputŠirina.Size = new System.Drawing.Size(100, 22);
            this.uiInputŠirina.TabIndex = 4;
            // 
            // visinaLabel
            // 
            visinaLabel.AutoSize = true;
            visinaLabel.Location = new System.Drawing.Point(118, 143);
            visinaLabel.Name = "visinaLabel";
            visinaLabel.Size = new System.Drawing.Size(57, 17);
            visinaLabel.TabIndex = 5;
            visinaLabel.Text = "Dubina:";
            // 
            // uiInputDubina
            // 
            this.uiInputDubina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "visina", true));
            this.uiInputDubina.Location = new System.Drawing.Point(181, 140);
            this.uiInputDubina.Name = "uiInputDubina";
            this.uiInputDubina.Size = new System.Drawing.Size(100, 22);
            this.uiInputDubina.TabIndex = 6;
            // 
            // slikaLabel
            // 
            slikaLabel.AutoSize = true;
            slikaLabel.Location = new System.Drawing.Point(133, 171);
            slikaLabel.Name = "slikaLabel";
            slikaLabel.Size = new System.Drawing.Size(42, 17);
            slikaLabel.TabIndex = 7;
            slikaLabel.Text = "Slika:";
            // 
            // uiInputSlika
            // 
            this.uiInputSlika.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "slika", true));
            this.uiInputSlika.Location = new System.Drawing.Point(181, 168);
            this.uiInputSlika.Name = "uiInputSlika";
            this.uiInputSlika.Size = new System.Drawing.Size(100, 22);
            this.uiInputSlika.TabIndex = 8;
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(128, 59);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(47, 17);
            nazivLabel.TabIndex = 9;
            nazivLabel.Text = "Naziv:";
            // 
            // uiInputNaziv
            // 
            this.uiInputNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "naziv", true));
            this.uiInputNaziv.Location = new System.Drawing.Point(181, 56);
            this.uiInputNaziv.Name = "uiInputNaziv";
            this.uiInputNaziv.Size = new System.Drawing.Size(100, 22);
            this.uiInputNaziv.TabIndex = 10;
            // 
            // uiActionDalje
            // 
            this.uiActionDalje.BackColor = System.Drawing.Color.DarkTurquoise;
            this.uiActionDalje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDalje.ForeColor = System.Drawing.Color.White;
            this.uiActionDalje.Location = new System.Drawing.Point(392, 317);
            this.uiActionDalje.Name = "uiActionDalje";
            this.uiActionDalje.Size = new System.Drawing.Size(120, 45);
            this.uiActionDalje.TabIndex = 11;
            this.uiActionDalje.Text = "DALJE";
            this.uiActionDalje.UseVisualStyleBackColor = false;
            // 
            // uiDodajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 373);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "uiDodajProizvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uiDodajProizvod";
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