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
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.ulogaDijelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ulogaDijelaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.uiActionSpremiDio = new System.Windows.Forms.Button();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            nazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(64, 55);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(47, 17);
            nazivLabel.TabIndex = 3;
            nazivLabel.Text = "Naziv:";
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
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ulogaDijelaBindingSource, "naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(115, 52);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(100, 22);
            this.nazivTextBox.TabIndex = 4;
            // 
            // uiActionSpremiDio
            // 
            this.uiActionSpremiDio.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionSpremiDio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionSpremiDio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionSpremiDio.ForeColor = System.Drawing.Color.White;
            this.uiActionSpremiDio.Location = new System.Drawing.Point(103, 126);
            this.uiActionSpremiDio.Name = "uiActionSpremiDio";
            this.uiActionSpremiDio.Size = new System.Drawing.Size(112, 51);
            this.uiActionSpremiDio.TabIndex = 8;
            this.uiActionSpremiDio.Text = "Spremi";
            this.uiActionSpremiDio.UseVisualStyleBackColor = false;
            this.uiActionSpremiDio.Click += new System.EventHandler(this.uiActionSpremiDio_Click);
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
            this.tableAdapterManager.UlogaDijelaTableAdapter = this.ulogaDijelaTableAdapter;
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uiDodajUrediUlogaDijela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(306, 199);
            this.Controls.Add(this.uiActionSpremiDio);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "uiDodajUrediUlogaDijela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uiDodajUrediUlogaDijela";
            this.Load += new System.EventHandler(this.uiDodajUrediUlogaDijela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaDijelaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource ulogaDijelaBindingSource;
        private Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter ulogaDijelaTableAdapter;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.Button uiActionSpremiDio;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}