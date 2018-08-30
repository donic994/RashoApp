namespace RashoApp.UlogaDijela
{
    partial class uiDodajUrediUlogaDijela
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
            System.Windows.Forms.Label duzinaLabel;
            System.Windows.Forms.Label sirinaLabel;
            System.Windows.Forms.Label debljinaLabel;
            System.Windows.Forms.Label materijalLabel;
            System.Windows.Forms.Label kolicinaLabel;
            System.Windows.Forms.Label bojaLabel;
            System.Windows.Forms.Label kantiranostLabel;
            System.Windows.Forms.Label prijedlogImeLabel;
            this.uiInputNaziv = new System.Windows.Forms.TextBox();
            this.uiActionSpremiDio = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.uiInputDuzina = new System.Windows.Forms.TextBox();
            this.uiInputŠirina = new System.Windows.Forms.TextBox();
            this.uiInputDebljina = new System.Windows.Forms.TextBox();
            this.uiInputMaterijal = new System.Windows.Forms.TextBox();
            this.uiInputKoličina = new System.Windows.Forms.TextBox();
            this.uiInputBoja = new System.Windows.Forms.TextBox();
            this.uiInputKantiranost = new System.Windows.Forms.TextBox();
            this.ulogaDijelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.ulogaDijelaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.uiInputPrijedlogImenaDijela = new System.Windows.Forms.TextBox();
            nazivLabel = new System.Windows.Forms.Label();
            duzinaLabel = new System.Windows.Forms.Label();
            sirinaLabel = new System.Windows.Forms.Label();
            debljinaLabel = new System.Windows.Forms.Label();
            materijalLabel = new System.Windows.Forms.Label();
            kolicinaLabel = new System.Windows.Forms.Label();
            bojaLabel = new System.Windows.Forms.Label();
            kantiranostLabel = new System.Windows.Forms.Label();
            prijedlogImeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(114, 22);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(47, 17);
            nazivLabel.TabIndex = 3;
            nazivLabel.Text = "Naziv:";
            // 
            // duzinaLabel
            // 
            duzinaLabel.AutoSize = true;
            duzinaLabel.Location = new System.Drawing.Point(105, 50);
            duzinaLabel.Name = "duzinaLabel";
            duzinaLabel.Size = new System.Drawing.Size(56, 17);
            duzinaLabel.TabIndex = 9;
            duzinaLabel.Text = "Dužina:";
            // 
            // sirinaLabel
            // 
            sirinaLabel.AutoSize = true;
            sirinaLabel.Location = new System.Drawing.Point(113, 78);
            sirinaLabel.Name = "sirinaLabel";
            sirinaLabel.Size = new System.Drawing.Size(48, 17);
            sirinaLabel.TabIndex = 10;
            sirinaLabel.Text = "Širina:";
            // 
            // debljinaLabel
            // 
            debljinaLabel.AutoSize = true;
            debljinaLabel.Location = new System.Drawing.Point(98, 106);
            debljinaLabel.Name = "debljinaLabel";
            debljinaLabel.Size = new System.Drawing.Size(63, 17);
            debljinaLabel.TabIndex = 11;
            debljinaLabel.Text = "Debljina:";
            // 
            // materijalLabel
            // 
            materijalLabel.AutoSize = true;
            materijalLabel.Location = new System.Drawing.Point(94, 134);
            materijalLabel.Name = "materijalLabel";
            materijalLabel.Size = new System.Drawing.Size(65, 17);
            materijalLabel.TabIndex = 12;
            materijalLabel.Text = "Materijal:";
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(100, 162);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(61, 17);
            kolicinaLabel.TabIndex = 13;
            kolicinaLabel.Text = "Količina:";
            // 
            // bojaLabel
            // 
            bojaLabel.AutoSize = true;
            bojaLabel.Location = new System.Drawing.Point(120, 190);
            bojaLabel.Name = "bojaLabel";
            bojaLabel.Size = new System.Drawing.Size(40, 17);
            bojaLabel.TabIndex = 14;
            bojaLabel.Text = "Boja:";
            // 
            // kantiranostLabel
            // 
            kantiranostLabel.AutoSize = true;
            kantiranostLabel.Location = new System.Drawing.Point(77, 218);
            kantiranostLabel.Name = "kantiranostLabel";
            kantiranostLabel.Size = new System.Drawing.Size(84, 17);
            kantiranostLabel.TabIndex = 15;
            kantiranostLabel.Text = "Kantiranost:";
            // 
            // uiInputNaziv
            // 
            this.uiInputNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ulogaDijelaBindingSource, "naziv", true));
            this.helpProvider1.SetHelpString(this.uiInputNaziv, "Unesite naziv uloge dijela");
            this.uiInputNaziv.Location = new System.Drawing.Point(165, 19);
            this.uiInputNaziv.Name = "uiInputNaziv";
            this.helpProvider1.SetShowHelp(this.uiInputNaziv, true);
            this.uiInputNaziv.Size = new System.Drawing.Size(100, 22);
            this.uiInputNaziv.TabIndex = 1;
            // 
            // uiActionSpremiDio
            // 
            this.uiActionSpremiDio.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionSpremiDio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionSpremiDio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionSpremiDio.ForeColor = System.Drawing.Color.White;
            this.uiActionSpremiDio.Location = new System.Drawing.Point(139, 295);
            this.uiActionSpremiDio.Name = "uiActionSpremiDio";
            this.uiActionSpremiDio.Size = new System.Drawing.Size(112, 51);
            this.uiActionSpremiDio.TabIndex = 9;
            this.uiActionSpremiDio.Text = "Spremi";
            this.uiActionSpremiDio.UseVisualStyleBackColor = false;
            this.uiActionSpremiDio.Click += new System.EventHandler(this.uiActionSpremiDio_Click);
            // 
            // uiInputDuzina
            // 
            this.uiInputDuzina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ulogaDijelaBindingSource, "duzina", true));
            this.uiInputDuzina.Location = new System.Drawing.Point(165, 47);
            this.uiInputDuzina.Name = "uiInputDuzina";
            this.uiInputDuzina.Size = new System.Drawing.Size(100, 22);
            this.uiInputDuzina.TabIndex = 2;
            // 
            // uiInputŠirina
            // 
            this.uiInputŠirina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ulogaDijelaBindingSource, "sirina", true));
            this.uiInputŠirina.Location = new System.Drawing.Point(165, 75);
            this.uiInputŠirina.Name = "uiInputŠirina";
            this.uiInputŠirina.Size = new System.Drawing.Size(100, 22);
            this.uiInputŠirina.TabIndex = 3;
            // 
            // uiInputDebljina
            // 
            this.uiInputDebljina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ulogaDijelaBindingSource, "debljina", true));
            this.uiInputDebljina.Location = new System.Drawing.Point(165, 103);
            this.uiInputDebljina.Name = "uiInputDebljina";
            this.uiInputDebljina.Size = new System.Drawing.Size(100, 22);
            this.uiInputDebljina.TabIndex = 4;
            // 
            // uiInputMaterijal
            // 
            this.uiInputMaterijal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ulogaDijelaBindingSource, "materijal", true));
            this.uiInputMaterijal.Location = new System.Drawing.Point(165, 131);
            this.uiInputMaterijal.Name = "uiInputMaterijal";
            this.uiInputMaterijal.Size = new System.Drawing.Size(100, 22);
            this.uiInputMaterijal.TabIndex = 5;
            // 
            // uiInputKoličina
            // 
            this.uiInputKoličina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ulogaDijelaBindingSource, "kolicina", true));
            this.uiInputKoličina.Location = new System.Drawing.Point(165, 159);
            this.uiInputKoličina.Name = "uiInputKoličina";
            this.uiInputKoličina.Size = new System.Drawing.Size(100, 22);
            this.uiInputKoličina.TabIndex = 6;
            // 
            // uiInputBoja
            // 
            this.uiInputBoja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ulogaDijelaBindingSource, "boja", true));
            this.uiInputBoja.Location = new System.Drawing.Point(165, 187);
            this.uiInputBoja.Name = "uiInputBoja";
            this.uiInputBoja.Size = new System.Drawing.Size(100, 22);
            this.uiInputBoja.TabIndex = 7;
            // 
            // uiInputKantiranost
            // 
            this.uiInputKantiranost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ulogaDijelaBindingSource, "kantiranost", true));
            this.uiInputKantiranost.Location = new System.Drawing.Point(165, 215);
            this.uiInputKantiranost.Name = "uiInputKantiranost";
            this.uiInputKantiranost.Size = new System.Drawing.Size(100, 22);
            this.uiInputKantiranost.TabIndex = 8;
            // 
            // ulogaDijelaBindingSource
            // 
            this.ulogaDijelaBindingSource.DataMember = "UlogaDijela";
            this.ulogaDijelaBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ulogaDijelaTableAdapter
            // 
            this.ulogaDijelaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ProizvodTableAdapter = null;
            this.tableAdapterManager.StavkaNarudzbeTableAdapter = null;
            this.tableAdapterManager.UIElementiTableAdapter = null;
            this.tableAdapterManager.UlogaDijelaTableAdapter = this.ulogaDijelaTableAdapter;
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VidiElementTableAdapter = null;
            // 
            // prijedlogImeLabel
            // 
            prijedlogImeLabel.AutoSize = true;
            prijedlogImeLabel.Location = new System.Drawing.Point(15, 246);
            prijedlogImeLabel.Name = "prijedlogImeLabel";
            prijedlogImeLabel.Size = new System.Drawing.Size(146, 17);
            prijedlogImeLabel.TabIndex = 17;
            prijedlogImeLabel.Text = "Prijedlog imena dijela:";
            // 
            // uiInputPrijedlogImenaDijela
            // 
            this.uiInputPrijedlogImenaDijela.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ulogaDijelaBindingSource, "prijedlogIme", true));
            this.uiInputPrijedlogImenaDijela.Location = new System.Drawing.Point(165, 243);
            this.uiInputPrijedlogImenaDijela.Name = "uiInputPrijedlogImenaDijela";
            this.uiInputPrijedlogImenaDijela.Size = new System.Drawing.Size(100, 22);
            this.uiInputPrijedlogImenaDijela.TabIndex = 18;
            // 
            // uiDodajUrediUlogaDijela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 358);
            this.Controls.Add(prijedlogImeLabel);
            this.Controls.Add(this.uiInputPrijedlogImenaDijela);
            this.Controls.Add(kantiranostLabel);
            this.Controls.Add(this.uiInputKantiranost);
            this.Controls.Add(bojaLabel);
            this.Controls.Add(this.uiInputBoja);
            this.Controls.Add(kolicinaLabel);
            this.Controls.Add(this.uiInputKoličina);
            this.Controls.Add(materijalLabel);
            this.Controls.Add(this.uiInputMaterijal);
            this.Controls.Add(debljinaLabel);
            this.Controls.Add(this.uiInputDebljina);
            this.Controls.Add(sirinaLabel);
            this.Controls.Add(this.uiInputŠirina);
            this.Controls.Add(duzinaLabel);
            this.Controls.Add(this.uiInputDuzina);
            this.Controls.Add(this.uiActionSpremiDio);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.uiInputNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "uiDodajUrediUlogaDijela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uiDodajUrediUlogaDijela";
            this.Load += new System.EventHandler(this.uiDodajUrediUlogaDijela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource ulogaDijelaBindingSource;
        private Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter ulogaDijelaTableAdapter;
        private System.Windows.Forms.TextBox uiInputNaziv;
        private System.Windows.Forms.Button uiActionSpremiDio;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox uiInputDuzina;
        private System.Windows.Forms.TextBox uiInputŠirina;
        private System.Windows.Forms.TextBox uiInputDebljina;
        private System.Windows.Forms.TextBox uiInputMaterijal;
        private System.Windows.Forms.TextBox uiInputKoličina;
        private System.Windows.Forms.TextBox uiInputBoja;
        private System.Windows.Forms.TextBox uiInputKantiranost;
        private System.Windows.Forms.TextBox uiInputPrijedlogImenaDijela;
    }
}