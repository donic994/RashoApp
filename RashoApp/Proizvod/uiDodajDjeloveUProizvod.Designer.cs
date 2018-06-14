namespace RashoApp.Proizvod
{
    partial class uiDodajDjeloveUProizvod
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label nazivLabel1;
            System.Windows.Forms.Label duljinaLabel;
            System.Windows.Forms.Label sirinaLabel;
            System.Windows.Forms.Label visinaLabel;
            System.Windows.Forms.Label slikaLabel;
            System.Windows.Forms.Label materijalLabel;
            this.uiActionDalje = new System.Windows.Forms.Button();
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.ulogaDijelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ulogaDijelaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.dioTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.DioTableAdapter();
            this.uiInputUlogaID = new System.Windows.Forms.TextBox();
            this.uiOutputUlogaNaziv = new System.Windows.Forms.TextBox();
            this.dioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiInputDioNaziv = new System.Windows.Forms.TextBox();
            this.uiInputDioDužina = new System.Windows.Forms.TextBox();
            this.uiInputDioŠirina = new System.Windows.Forms.TextBox();
            this.uiInputDioVisina = new System.Windows.Forms.TextBox();
            this.uiInputDioSlika = new System.Windows.Forms.TextBox();
            this.uiInputDioMaterijal = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uiActionOdaberiUloga = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            nazivLabel1 = new System.Windows.Forms.Label();
            duljinaLabel = new System.Windows.Forms.Label();
            sirinaLabel = new System.Windows.Forms.Label();
            visinaLabel = new System.Windows.Forms.Label();
            slikaLabel = new System.Windows.Forms.Label();
            materijalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(62, 30);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(26, 18);
            iDLabel.TabIndex = 13;
            iDLabel.Text = "ID:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(37, 59);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(51, 18);
            nazivLabel.TabIndex = 14;
            nazivLabel.Text = "Uloga:";
            // 
            // nazivLabel1
            // 
            nazivLabel1.AutoSize = true;
            nazivLabel1.Location = new System.Drawing.Point(42, 165);
            nazivLabel1.Name = "nazivLabel1";
            nazivLabel1.Size = new System.Drawing.Size(46, 18);
            nazivLabel1.TabIndex = 15;
            nazivLabel1.Text = "naziv:";
            // 
            // duljinaLabel
            // 
            duljinaLabel.AutoSize = true;
            duljinaLabel.Location = new System.Drawing.Point(35, 195);
            duljinaLabel.Name = "duljinaLabel";
            duljinaLabel.Size = new System.Drawing.Size(53, 18);
            duljinaLabel.TabIndex = 16;
            duljinaLabel.Text = "duljina:";
            // 
            // sirinaLabel
            // 
            sirinaLabel.AutoSize = true;
            sirinaLabel.Location = new System.Drawing.Point(41, 225);
            sirinaLabel.Name = "sirinaLabel";
            sirinaLabel.Size = new System.Drawing.Size(47, 18);
            sirinaLabel.TabIndex = 17;
            sirinaLabel.Text = "sirina:";
            // 
            // visinaLabel
            // 
            visinaLabel.AutoSize = true;
            visinaLabel.Location = new System.Drawing.Point(39, 255);
            visinaLabel.Name = "visinaLabel";
            visinaLabel.Size = new System.Drawing.Size(49, 18);
            visinaLabel.TabIndex = 18;
            visinaLabel.Text = "visina:";
            // 
            // slikaLabel
            // 
            slikaLabel.AutoSize = true;
            slikaLabel.Location = new System.Drawing.Point(46, 285);
            slikaLabel.Name = "slikaLabel";
            slikaLabel.Size = new System.Drawing.Size(42, 18);
            slikaLabel.TabIndex = 19;
            slikaLabel.Text = "slika:";
            // 
            // materijalLabel
            // 
            materijalLabel.AutoSize = true;
            materijalLabel.Location = new System.Drawing.Point(21, 315);
            materijalLabel.Name = "materijalLabel";
            materijalLabel.Size = new System.Drawing.Size(67, 18);
            materijalLabel.TabIndex = 20;
            materijalLabel.Text = "materijal:";
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
            this.uiActionDalje.TabIndex = 12;
            this.uiActionDalje.Text = "DALJE";
            this.uiActionDalje.UseVisualStyleBackColor = false;
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ulogaDijelaBindingSource
            // 
            this.ulogaDijelaBindingSource.DataMember = "UlogaDijela";
            this.ulogaDijelaBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // ulogaDijelaTableAdapter
            // 
            this.ulogaDijelaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.UlogaDijelaTableAdapter = this.ulogaDijelaTableAdapter;
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dioTableAdapter
            // 
            this.dioTableAdapter.ClearBeforeFill = true;
            // 
            // uiInputUlogaID
            // 
            this.uiInputUlogaID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ulogaDijelaBindingSource, "ID", true));
            this.uiInputUlogaID.Location = new System.Drawing.Point(94, 27);
            this.uiInputUlogaID.Name = "uiInputUlogaID";
            this.uiInputUlogaID.ReadOnly = true;
            this.uiInputUlogaID.Size = new System.Drawing.Size(100, 24);
            this.uiInputUlogaID.TabIndex = 14;
            // 
            // uiOutputUlogaNaziv
            // 
            this.uiOutputUlogaNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ulogaDijelaBindingSource, "naziv", true));
            this.uiOutputUlogaNaziv.Location = new System.Drawing.Point(94, 57);
            this.uiOutputUlogaNaziv.Name = "uiOutputUlogaNaziv";
            this.uiOutputUlogaNaziv.ReadOnly = true;
            this.uiOutputUlogaNaziv.Size = new System.Drawing.Size(100, 24);
            this.uiOutputUlogaNaziv.TabIndex = 15;
            // 
            // dioBindingSource
            // 
            this.dioBindingSource.DataMember = "Dio";
            this.dioBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // uiInputDioNaziv
            // 
            this.uiInputDioNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "naziv", true));
            this.uiInputDioNaziv.Location = new System.Drawing.Point(94, 162);
            this.uiInputDioNaziv.Name = "uiInputDioNaziv";
            this.uiInputDioNaziv.Size = new System.Drawing.Size(100, 24);
            this.uiInputDioNaziv.TabIndex = 16;
            // 
            // uiInputDioDužina
            // 
            this.uiInputDioDužina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "duljina", true));
            this.uiInputDioDužina.Location = new System.Drawing.Point(94, 192);
            this.uiInputDioDužina.Name = "uiInputDioDužina";
            this.uiInputDioDužina.Size = new System.Drawing.Size(100, 24);
            this.uiInputDioDužina.TabIndex = 17;
            // 
            // uiInputDioŠirina
            // 
            this.uiInputDioŠirina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "sirina", true));
            this.uiInputDioŠirina.Location = new System.Drawing.Point(94, 222);
            this.uiInputDioŠirina.Name = "uiInputDioŠirina";
            this.uiInputDioŠirina.Size = new System.Drawing.Size(100, 24);
            this.uiInputDioŠirina.TabIndex = 18;
            // 
            // uiInputDioVisina
            // 
            this.uiInputDioVisina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "visina", true));
            this.uiInputDioVisina.Location = new System.Drawing.Point(94, 252);
            this.uiInputDioVisina.Name = "uiInputDioVisina";
            this.uiInputDioVisina.Size = new System.Drawing.Size(100, 24);
            this.uiInputDioVisina.TabIndex = 19;
            // 
            // uiInputDioSlika
            // 
            this.uiInputDioSlika.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "slika", true));
            this.uiInputDioSlika.Location = new System.Drawing.Point(94, 282);
            this.uiInputDioSlika.Name = "uiInputDioSlika";
            this.uiInputDioSlika.Size = new System.Drawing.Size(100, 24);
            this.uiInputDioSlika.TabIndex = 20;
            // 
            // uiInputDioMaterijal
            // 
            this.uiInputDioMaterijal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dioBindingSource, "materijal", true));
            this.uiInputDioMaterijal.Location = new System.Drawing.Point(94, 312);
            this.uiInputDioMaterijal.Name = "uiInputDioMaterijal";
            this.uiInputDioMaterijal.Size = new System.Drawing.Size(100, 24);
            this.uiInputDioMaterijal.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kreiraj novi dio",
            "Odaberi postojeći dio"});
            this.comboBox1.Location = new System.Drawing.Point(45, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 26);
            this.comboBox1.TabIndex = 22;
            // 
            // uiActionOdaberiUloga
            // 
            this.uiActionOdaberiUloga.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionOdaberiUloga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionOdaberiUloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdaberiUloga.ForeColor = System.Drawing.Color.White;
            this.uiActionOdaberiUloga.Location = new System.Drawing.Point(197, 57);
            this.uiActionOdaberiUloga.Margin = new System.Windows.Forms.Padding(0);
            this.uiActionOdaberiUloga.Name = "uiActionOdaberiUloga";
            this.uiActionOdaberiUloga.Size = new System.Drawing.Size(30, 24);
            this.uiActionOdaberiUloga.TabIndex = 23;
            this.uiActionOdaberiUloga.Text = "+";
            this.uiActionOdaberiUloga.UseVisualStyleBackColor = false;
            this.uiActionOdaberiUloga.Click += new System.EventHandler(this.uiActionOdaberiUloga_Click);
            // 
            // uiDodajDjeloveUProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 373);
            this.Controls.Add(this.uiActionOdaberiUloga);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(materijalLabel);
            this.Controls.Add(this.uiInputDioMaterijal);
            this.Controls.Add(slikaLabel);
            this.Controls.Add(this.uiInputDioSlika);
            this.Controls.Add(visinaLabel);
            this.Controls.Add(this.uiInputDioVisina);
            this.Controls.Add(sirinaLabel);
            this.Controls.Add(this.uiInputDioŠirina);
            this.Controls.Add(duljinaLabel);
            this.Controls.Add(this.uiInputDioDužina);
            this.Controls.Add(nazivLabel1);
            this.Controls.Add(this.uiInputDioNaziv);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.uiOutputUlogaNaziv);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.uiInputUlogaID);
            this.Controls.Add(this.uiActionDalje);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "uiDodajDjeloveUProizvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uiDodajDjeloveUProizvod";
            this.Load += new System.EventHandler(this.uiDodajDjeloveUProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionDalje;
        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource ulogaDijelaBindingSource;
        private Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter ulogaDijelaTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Baza18043_DBDataSetTableAdapters.DioTableAdapter dioTableAdapter;
        private System.Windows.Forms.TextBox uiInputUlogaID;
        private System.Windows.Forms.TextBox uiOutputUlogaNaziv;
        private System.Windows.Forms.BindingSource dioBindingSource;
        private System.Windows.Forms.TextBox uiInputDioNaziv;
        private System.Windows.Forms.TextBox uiInputDioDužina;
        private System.Windows.Forms.TextBox uiInputDioŠirina;
        private System.Windows.Forms.TextBox uiInputDioVisina;
        private System.Windows.Forms.TextBox uiInputDioSlika;
        private System.Windows.Forms.TextBox uiInputDioMaterijal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button uiActionOdaberiUloga;
    }
}