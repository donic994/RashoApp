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
            System.Windows.Forms.Label materijalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiDodajUrediDio));
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.dioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dioTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.DioTableAdapter();
            this.uiInputDioNaziv = new System.Windows.Forms.TextBox();
            this.uiInputDioDuljina = new System.Windows.Forms.TextBox();
            this.uiInputDioŠirina = new System.Windows.Forms.TextBox();
            this.uiInputDioVisina = new System.Windows.Forms.TextBox();
            this.uiInputDioMaterijal = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.uiActionSpremiDio = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            nazivLabel = new System.Windows.Forms.Label();
            duljinaLabel = new System.Windows.Forms.Label();
            sirinaLabel = new System.Windows.Forms.Label();
            visinaLabel = new System.Windows.Forms.Label();
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
            duljinaLabel.Location = new System.Drawing.Point(33, 57);
            duljinaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            duljinaLabel.Name = "duljinaLabel";
            duljinaLabel.Size = new System.Drawing.Size(58, 18);
            duljinaLabel.TabIndex = 12;
            duljinaLabel.Text = "Dužina:";
            // 
            // sirinaLabel
            // 
            sirinaLabel.AutoSize = true;
            sirinaLabel.Location = new System.Drawing.Point(42, 89);
            sirinaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sirinaLabel.Name = "sirinaLabel";
            sirinaLabel.Size = new System.Drawing.Size(49, 18);
            sirinaLabel.TabIndex = 11;
            sirinaLabel.Text = "Širina:";
            // 
            // visinaLabel
            // 
            visinaLabel.AutoSize = true;
            visinaLabel.Location = new System.Drawing.Point(27, 120);
            visinaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            visinaLabel.Name = "visinaLabel";
            visinaLabel.Size = new System.Drawing.Size(64, 18);
            visinaLabel.TabIndex = 10;
            visinaLabel.Text = "Debljina:";
            // 
            // materijalLabel
            // 
            materijalLabel.AutoSize = true;
            materijalLabel.Location = new System.Drawing.Point(24, 152);
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
            this.helpProvider1.SetHelpString(this.uiInputDioNaziv, "Unesite naziv novog dijela");
            this.uiInputDioNaziv.Location = new System.Drawing.Point(99, 23);
            this.uiInputDioNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.uiInputDioNaziv.Name = "uiInputDioNaziv";
            this.helpProvider1.SetShowHelp(this.uiInputDioNaziv, true);
            this.uiInputDioNaziv.Size = new System.Drawing.Size(112, 24);
            this.uiInputDioNaziv.TabIndex = 1;
            // 
            // uiInputDioDuljina
            // 
            this.uiInputDioDuljina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "duljina", true));
            this.helpProvider1.SetHelpString(this.uiInputDioDuljina, "Unesite duljinu u mm");
            this.uiInputDioDuljina.Location = new System.Drawing.Point(99, 54);
            this.uiInputDioDuljina.Margin = new System.Windows.Forms.Padding(4);
            this.uiInputDioDuljina.Name = "uiInputDioDuljina";
            this.helpProvider1.SetShowHelp(this.uiInputDioDuljina, true);
            this.uiInputDioDuljina.Size = new System.Drawing.Size(112, 24);
            this.uiInputDioDuljina.TabIndex = 2;
            // 
            // uiInputDioŠirina
            // 
            this.uiInputDioŠirina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "sirina", true));
            this.helpProvider1.SetHelpString(this.uiInputDioŠirina, "Unesite širinu u mm");
            this.uiInputDioŠirina.Location = new System.Drawing.Point(99, 86);
            this.uiInputDioŠirina.Margin = new System.Windows.Forms.Padding(4);
            this.uiInputDioŠirina.Name = "uiInputDioŠirina";
            this.helpProvider1.SetShowHelp(this.uiInputDioŠirina, true);
            this.uiInputDioŠirina.Size = new System.Drawing.Size(112, 24);
            this.uiInputDioŠirina.TabIndex = 3;
            // 
            // uiInputDioVisina
            // 
            this.uiInputDioVisina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "visina", true));
            this.helpProvider1.SetHelpString(this.uiInputDioVisina, "Unesite debljinu u mm");
            this.uiInputDioVisina.Location = new System.Drawing.Point(99, 117);
            this.uiInputDioVisina.Margin = new System.Windows.Forms.Padding(4);
            this.uiInputDioVisina.Name = "uiInputDioVisina";
            this.helpProvider1.SetShowHelp(this.uiInputDioVisina, true);
            this.uiInputDioVisina.Size = new System.Drawing.Size(112, 24);
            this.uiInputDioVisina.TabIndex = 4;
            // 
            // uiInputDioMaterijal
            // 
            this.uiInputDioMaterijal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "materijal", true));
            this.helpProvider1.SetHelpString(this.uiInputDioMaterijal, "Unesite materijal");
            this.uiInputDioMaterijal.Location = new System.Drawing.Point(99, 149);
            this.uiInputDioMaterijal.Margin = new System.Windows.Forms.Padding(4);
            this.uiInputDioMaterijal.Name = "uiInputDioMaterijal";
            this.helpProvider1.SetShowHelp(this.uiInputDioMaterijal, true);
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
            this.uiActionSpremiDio.Location = new System.Drawing.Point(70, 198);
            this.uiActionSpremiDio.Name = "uiActionSpremiDio";
            this.uiActionSpremiDio.Size = new System.Drawing.Size(112, 51);
            this.uiActionSpremiDio.TabIndex = 7;
            this.uiActionSpremiDio.Text = "Spremi";
            this.uiActionSpremiDio.UseVisualStyleBackColor = false;
            this.uiActionSpremiDio.Click += new System.EventHandler(this.uiActionSpremiDio_Click);
            // 
            // uiDodajUrediDio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(243, 261);
            this.Controls.Add(this.uiActionSpremiDio);
            this.Controls.Add(materijalLabel);
            this.Controls.Add(this.uiInputDioMaterijal);
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
        private System.Windows.Forms.TextBox uiInputDioMaterijal;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button uiActionSpremiDio;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}