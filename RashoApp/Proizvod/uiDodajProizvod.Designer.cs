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
            System.Windows.Forms.Label duljinaLabel;
            System.Windows.Forms.Label sirinaLabel;
            System.Windows.Forms.Label visinaLabel;
            System.Windows.Forms.Label slikaLabel;
            System.Windows.Forms.Label nazivLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiDodajProizvod));
            this.uiInputDužina = new System.Windows.Forms.TextBox();
            this.uiInputŠirina = new System.Windows.Forms.TextBox();
            this.uiInputDubina = new System.Windows.Forms.TextBox();
            this.uiInputSlika = new System.Windows.Forms.TextBox();
            this.uiInputNaziv = new System.Windows.Forms.TextBox();
            this.uiActionDalje = new System.Windows.Forms.Button();
            this.uiActionOdaberiSliku = new System.Windows.Forms.Button();
            this.openFileDialogOdaberiSliku = new System.Windows.Forms.OpenFileDialog();
            this.proizvodTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter();
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            duljinaLabel = new System.Windows.Forms.Label();
            sirinaLabel = new System.Windows.Forms.Label();
            visinaLabel = new System.Windows.Forms.Label();
            slikaLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // duljinaLabel
            // 
            duljinaLabel.AutoSize = true;
            duljinaLabel.Location = new System.Drawing.Point(32, 58);
            duljinaLabel.Name = "duljinaLabel";
            duljinaLabel.Size = new System.Drawing.Size(58, 18);
            duljinaLabel.TabIndex = 1;
            duljinaLabel.Text = "Dužina:";
            // 
            // sirinaLabel
            // 
            sirinaLabel.AutoSize = true;
            sirinaLabel.Location = new System.Drawing.Point(41, 89);
            sirinaLabel.Name = "sirinaLabel";
            sirinaLabel.Size = new System.Drawing.Size(49, 18);
            sirinaLabel.TabIndex = 3;
            sirinaLabel.Text = "Širina:";
            // 
            // visinaLabel
            // 
            visinaLabel.AutoSize = true;
            visinaLabel.Location = new System.Drawing.Point(31, 121);
            visinaLabel.Name = "visinaLabel";
            visinaLabel.Size = new System.Drawing.Size(58, 18);
            visinaLabel.TabIndex = 5;
            visinaLabel.Text = "Dubina:";
            // 
            // slikaLabel
            // 
            slikaLabel.AutoSize = true;
            slikaLabel.Location = new System.Drawing.Point(48, 152);
            slikaLabel.Name = "slikaLabel";
            slikaLabel.Size = new System.Drawing.Size(44, 18);
            slikaLabel.TabIndex = 7;
            slikaLabel.Text = "Slika:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(42, 26);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(49, 18);
            nazivLabel.TabIndex = 9;
            nazivLabel.Text = "Naziv:";
            // 
            // uiInputDužina
            // 
            this.uiInputDužina.Location = new System.Drawing.Point(102, 54);
            this.uiInputDužina.Name = "uiInputDužina";
            this.uiInputDužina.Size = new System.Drawing.Size(112, 24);
            this.uiInputDužina.TabIndex = 3;
            // 
            // uiInputŠirina
            // 
            this.uiInputŠirina.Location = new System.Drawing.Point(102, 86);
            this.uiInputŠirina.Name = "uiInputŠirina";
            this.uiInputŠirina.Size = new System.Drawing.Size(112, 24);
            this.uiInputŠirina.TabIndex = 4;
            // 
            // uiInputDubina
            // 
            this.uiInputDubina.Location = new System.Drawing.Point(102, 118);
            this.uiInputDubina.Name = "uiInputDubina";
            this.uiInputDubina.Size = new System.Drawing.Size(112, 24);
            this.uiInputDubina.TabIndex = 6;
            // 
            // uiInputSlika
            // 
            this.uiInputSlika.Location = new System.Drawing.Point(102, 149);
            this.uiInputSlika.Name = "uiInputSlika";
            this.uiInputSlika.Size = new System.Drawing.Size(112, 24);
            this.uiInputSlika.TabIndex = 8;
            // 
            // uiInputNaziv
            // 
            this.uiInputNaziv.Location = new System.Drawing.Point(102, 23);
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
            this.uiActionDalje.Location = new System.Drawing.Point(79, 224);
            this.uiActionDalje.Name = "uiActionDalje";
            this.uiActionDalje.Size = new System.Drawing.Size(135, 51);
            this.uiActionDalje.TabIndex = 11;
            this.uiActionDalje.Text = "DALJE";
            this.uiActionDalje.UseVisualStyleBackColor = false;
            this.uiActionDalje.Click += new System.EventHandler(this.uiActionDalje_Click);
            // 
            // uiActionOdaberiSliku
            // 
            this.uiActionOdaberiSliku.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionOdaberiSliku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionOdaberiSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdaberiSliku.ForeColor = System.Drawing.Color.White;
            this.uiActionOdaberiSliku.Location = new System.Drawing.Point(217, 149);
            this.uiActionOdaberiSliku.Margin = new System.Windows.Forms.Padding(0);
            this.uiActionOdaberiSliku.Name = "uiActionOdaberiSliku";
            this.uiActionOdaberiSliku.Size = new System.Drawing.Size(30, 24);
            this.uiActionOdaberiSliku.TabIndex = 22;
            this.uiActionOdaberiSliku.Text = "+";
            this.uiActionOdaberiSliku.UseVisualStyleBackColor = false;
            this.uiActionOdaberiSliku.Click += new System.EventHandler(this.uiActionOdaberiSliku_Click);
            // 
            // openFileDialogOdaberiSliku
            // 
            this.openFileDialogOdaberiSliku.FileName = "openFileDialogOdaberiSliku";
            // 
            // proizvodTableAdapter
            // 
            this.proizvodTableAdapter.ClearBeforeFill = true;
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // uiDodajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 316);
            this.Controls.Add(this.uiActionOdaberiSliku);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uiInputDužina;
        private System.Windows.Forms.TextBox uiInputŠirina;
        private System.Windows.Forms.TextBox uiInputDubina;
        private System.Windows.Forms.TextBox uiInputSlika;
        private System.Windows.Forms.TextBox uiInputNaziv;
        private System.Windows.Forms.Button uiActionDalje;
        private System.Windows.Forms.Button uiActionOdaberiSliku;
        private System.Windows.Forms.OpenFileDialog openFileDialogOdaberiSliku;
        private Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter proizvodTableAdapter;
        private Baza18043_DBDataSet baza18043_DBDataSet;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}