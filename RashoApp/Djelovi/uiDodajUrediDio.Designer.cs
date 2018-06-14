namespace RashoApp.Djelovi
{
    partial class uiDodajUrediDio
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label duljinaLabel;
            System.Windows.Forms.Label sirinaLabel;
            System.Windows.Forms.Label visinaLabel;
            System.Windows.Forms.Label slikaLabel;
            System.Windows.Forms.Label materijalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiDodajUrediDio));
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.dioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dioTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.DioTableAdapter();
            this.uiInputDioNaziv = new System.Windows.Forms.TextBox();
            this.uiInputDioDuljina = new System.Windows.Forms.TextBox();
            this.uiInputDioŠirina = new System.Windows.Forms.TextBox();
            this.uiInputDioVisina = new System.Windows.Forms.TextBox();
            this.uiInputDioSlika = new System.Windows.Forms.TextBox();
            this.uiInputDioMaterijal = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.uiActionSpremiDio = new System.Windows.Forms.Button();
            this.uiLabelUpozorenje = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            duljinaLabel = new System.Windows.Forms.Label();
            sirinaLabel = new System.Windows.Forms.Label();
            visinaLabel = new System.Windows.Forms.Label();
            slikaLabel = new System.Windows.Forms.Label();
            materijalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(42, 26);
            nazivLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(49, 18);
            nazivLabel.TabIndex = 13;
            nazivLabel.Text = "Naziv:";
            // 
            // duljinaLabel
            // 
            duljinaLabel.AutoSize = true;
            duljinaLabel.Location = new System.Drawing.Point(33, 58);
            duljinaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            duljinaLabel.Name = "duljinaLabel";
            duljinaLabel.Size = new System.Drawing.Size(56, 18);
            duljinaLabel.TabIndex = 12;
            duljinaLabel.Text = "Duljina:";
            // 
            // sirinaLabel
            // 
            sirinaLabel.AutoSize = true;
            sirinaLabel.Location = new System.Drawing.Point(41, 89);
            sirinaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sirinaLabel.Name = "sirinaLabel";
            sirinaLabel.Size = new System.Drawing.Size(49, 18);
            sirinaLabel.TabIndex = 11;
            sirinaLabel.Text = "Širina:";
            // 
            // visinaLabel
            // 
            visinaLabel.AutoSize = true;
            visinaLabel.Location = new System.Drawing.Point(39, 121);
            visinaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            visinaLabel.Name = "visinaLabel";
            visinaLabel.Size = new System.Drawing.Size(51, 18);
            visinaLabel.TabIndex = 10;
            visinaLabel.Text = "Visina:";
            // 
            // slikaLabel
            // 
            slikaLabel.AutoSize = true;
            slikaLabel.Location = new System.Drawing.Point(48, 152);
            slikaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            slikaLabel.Name = "slikaLabel";
            slikaLabel.Size = new System.Drawing.Size(44, 18);
            slikaLabel.TabIndex = 9;
            slikaLabel.Text = "Slika:";
            // 
            // materijalLabel
            // 
            materijalLabel.AutoSize = true;
            materijalLabel.Location = new System.Drawing.Point(20, 184);
            materijalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materijalLabel.Name = "materijalLabel";
            materijalLabel.Size = new System.Drawing.Size(67, 18);
            materijalLabel.TabIndex = 8;
            materijalLabel.Text = "Materijal:";
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dioBindingSource
            // 
            this.dioBindingSource.DataMember = "Dio";
            this.dioBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // dioTableAdapter
            // 
            this.dioTableAdapter.ClearBeforeFill = true;
            // 
            // uiInputDioNaziv
            // 
            this.uiInputDioNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "naziv", true));
            this.uiInputDioNaziv.Location = new System.Drawing.Point(99, 23);
            this.uiInputDioNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.uiInputDioNaziv.Name = "uiInputDioNaziv";
            this.uiInputDioNaziv.Size = new System.Drawing.Size(112, 24);
            this.uiInputDioNaziv.TabIndex = 1;
            // 
            // uiInputDioDuljina
            // 
            this.uiInputDioDuljina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "duljina", true));
            this.uiInputDioDuljina.Location = new System.Drawing.Point(99, 54);
            this.uiInputDioDuljina.Margin = new System.Windows.Forms.Padding(4);
            this.uiInputDioDuljina.Name = "uiInputDioDuljina";
            this.uiInputDioDuljina.Size = new System.Drawing.Size(112, 24);
            this.uiInputDioDuljina.TabIndex = 2;
            // 
            // uiInputDioŠirina
            // 
            this.uiInputDioŠirina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "sirina", true));
            this.uiInputDioŠirina.Location = new System.Drawing.Point(99, 86);
            this.uiInputDioŠirina.Margin = new System.Windows.Forms.Padding(4);
            this.uiInputDioŠirina.Name = "uiInputDioŠirina";
            this.uiInputDioŠirina.Size = new System.Drawing.Size(112, 24);
            this.uiInputDioŠirina.TabIndex = 3;
            // 
            // uiInputDioVisina
            // 
            this.uiInputDioVisina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "visina", true));
            this.uiInputDioVisina.Location = new System.Drawing.Point(99, 117);
            this.uiInputDioVisina.Margin = new System.Windows.Forms.Padding(4);
            this.uiInputDioVisina.Name = "uiInputDioVisina";
            this.uiInputDioVisina.Size = new System.Drawing.Size(112, 24);
            this.uiInputDioVisina.TabIndex = 4;
            // 
            // uiInputDioSlika
            // 
            this.uiInputDioSlika.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "slika", true));
            this.uiInputDioSlika.Location = new System.Drawing.Point(99, 149);
            this.uiInputDioSlika.Margin = new System.Windows.Forms.Padding(4);
            this.uiInputDioSlika.Name = "uiInputDioSlika";
            this.uiInputDioSlika.Size = new System.Drawing.Size(112, 24);
            this.uiInputDioSlika.TabIndex = 5;
            // 
            // uiInputDioMaterijal
            // 
            this.uiInputDioMaterijal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "materijal", true));
            this.uiInputDioMaterijal.Location = new System.Drawing.Point(99, 180);
            this.uiInputDioMaterijal.Margin = new System.Windows.Forms.Padding(4);
            this.uiInputDioMaterijal.Name = "uiInputDioMaterijal";
            this.uiInputDioMaterijal.Size = new System.Drawing.Size(112, 24);
            this.uiInputDioMaterijal.TabIndex = 6;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DioTableAdapter = this.dioTableAdapter;
            this.tableAdapterManager.DobavljacTableAdapter = null;
            this.tableAdapterManager.ElementTableAdapter = null;
            this.tableAdapterManager.KomponentaTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.ProizvodTableAdapter = null;
            this.tableAdapterManager.StavkaNarudzbeTableAdapter = null;
            this.tableAdapterManager.UlogaDijelaTableAdapter = null;
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uiActionSpremiDio
            // 
            this.uiActionSpremiDio.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionSpremiDio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionSpremiDio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionSpremiDio.ForeColor = System.Drawing.Color.White;
            this.uiActionSpremiDio.Location = new System.Drawing.Point(64, 224);
            this.uiActionSpremiDio.Name = "uiActionSpremiDio";
            this.uiActionSpremiDio.Size = new System.Drawing.Size(112, 51);
            this.uiActionSpremiDio.TabIndex = 7;
            this.uiActionSpremiDio.Text = "Spremi";
            this.uiActionSpremiDio.UseVisualStyleBackColor = false;
            this.uiActionSpremiDio.Click += new System.EventHandler(this.uiActionSpremiDio_Click);
            // 
            // uiLabelUpozorenje
            // 
            this.uiLabelUpozorenje.AutoSize = true;
            this.uiLabelUpozorenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLabelUpozorenje.ForeColor = System.Drawing.Color.Red;
            this.uiLabelUpozorenje.Location = new System.Drawing.Point(12, 286);
            this.uiLabelUpozorenje.Name = "uiLabelUpozorenje";
            this.uiLabelUpozorenje.Size = new System.Drawing.Size(0, 18);
            this.uiLabelUpozorenje.TabIndex = 14;
            // 
            // uiDodajUrediDio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(243, 322);
            this.Controls.Add(this.uiLabelUpozorenje);
            this.Controls.Add(this.uiActionSpremiDio);
            this.Controls.Add(materijalLabel);
            this.Controls.Add(this.uiInputDioMaterijal);
            this.Controls.Add(slikaLabel);
            this.Controls.Add(this.uiInputDioSlika);
            this.Controls.Add(visinaLabel);
            this.Controls.Add(this.uiInputDioVisina);
            this.Controls.Add(sirinaLabel);
            this.Controls.Add(this.uiInputDioŠirina);
            this.Controls.Add(duljinaLabel);
            this.Controls.Add(this.uiInputDioDuljina);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.uiInputDioNaziv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uiDodajUrediDio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.uiDodajDio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource dioBindingSource;
        private Baza18043_DBDataSetTableAdapters.DioTableAdapter dioTableAdapter;
        private System.Windows.Forms.TextBox uiInputDioNaziv;
        private System.Windows.Forms.TextBox uiInputDioDuljina;
        private System.Windows.Forms.TextBox uiInputDioŠirina;
        private System.Windows.Forms.TextBox uiInputDioVisina;
        private System.Windows.Forms.TextBox uiInputDioSlika;
        private System.Windows.Forms.TextBox uiInputDioMaterijal;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button uiActionSpremiDio;
        private System.Windows.Forms.Label uiLabelUpozorenje;
    }
}