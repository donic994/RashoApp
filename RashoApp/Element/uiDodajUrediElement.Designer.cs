namespace RashoApp.Element
{
    partial class uiDodajUrediElement
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
            System.Windows.Forms.Label id_proizvodLabel;
            System.Windows.Forms.Label id_elementLabel;
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.elementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.ElementTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.uiInputElementKolicina = new System.Windows.Forms.TextBox();
            this.uiInputElementProizvod = new System.Windows.Forms.ComboBox();
            this.uiInputElementElement = new System.Windows.Forms.TextBox();
            this.uiActionSpremiElement = new System.Windows.Forms.Button();
            kolicinaLabel = new System.Windows.Forms.Label();
            id_proizvodLabel = new System.Windows.Forms.Label();
            id_elementLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(67, 65);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(61, 17);
            kolicinaLabel.TabIndex = 1;
            kolicinaLabel.Text = "Količina:";
            // 
            // id_proizvodLabel
            // 
            id_proizvodLabel.AutoSize = true;
            id_proizvodLabel.Location = new System.Drawing.Point(61, 93);
            id_proizvodLabel.Name = "id_proizvodLabel";
            id_proizvodLabel.Size = new System.Drawing.Size(67, 17);
            id_proizvodLabel.TabIndex = 3;
            id_proizvodLabel.Text = "Proizvod:";
            // 
            // id_elementLabel
            // 
            id_elementLabel.AutoSize = true;
            id_elementLabel.Location = new System.Drawing.Point(65, 123);
            id_elementLabel.Name = "id_elementLabel";
            id_elementLabel.Size = new System.Drawing.Size(63, 17);
            id_elementLabel.TabIndex = 5;
            id_elementLabel.Text = "Element:";
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elementBindingSource
            // 
            this.elementBindingSource.DataMember = "Element";
            this.elementBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // elementTableAdapter
            // 
            this.elementTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DioTableAdapter = null;
            this.tableAdapterManager.DobavljacTableAdapter = null;
            this.tableAdapterManager.ElementTableAdapter = this.elementTableAdapter;
            this.tableAdapterManager.KomponentaTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.ProizvodTableAdapter = null;
            this.tableAdapterManager.StavkaNarudzbeTableAdapter = null;
            this.tableAdapterManager.UlogaDijelaTableAdapter = null;
            this.tableAdapterManager.UlogaKorisnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uiInputElementKolicina
            // 
            this.uiInputElementKolicina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.elementBindingSource, "kolicina", true));
            this.uiInputElementKolicina.Location = new System.Drawing.Point(134, 62);
            this.uiInputElementKolicina.Name = "uiInputElementKolicina";
            this.uiInputElementKolicina.Size = new System.Drawing.Size(100, 22);
            this.uiInputElementKolicina.TabIndex = 2;
            // 
            // uiInputElementProizvod
            // 
            this.uiInputElementProizvod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.elementBindingSource, "id_proizvod", true));
            this.uiInputElementProizvod.DisplayMember = "ID";
            this.uiInputElementProizvod.FormattingEnabled = true;
            this.uiInputElementProizvod.Location = new System.Drawing.Point(134, 90);
            this.uiInputElementProizvod.Name = "uiInputElementProizvod";
            this.uiInputElementProizvod.Size = new System.Drawing.Size(100, 24);
            this.uiInputElementProizvod.TabIndex = 4;
            this.uiInputElementProizvod.ValueMember = "ID";
            // 
            // uiInputElementElement
            // 
            this.uiInputElementElement.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.elementBindingSource, "id_element", true));
            this.uiInputElementElement.Location = new System.Drawing.Point(134, 120);
            this.uiInputElementElement.Name = "uiInputElementElement";
            this.uiInputElementElement.Size = new System.Drawing.Size(100, 22);
            this.uiInputElementElement.TabIndex = 6;
            // 
            // uiActionSpremiElement
            // 
            this.uiActionSpremiElement.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionSpremiElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionSpremiElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionSpremiElement.ForeColor = System.Drawing.Color.White;
            this.uiActionSpremiElement.Location = new System.Drawing.Point(100, 172);
            this.uiActionSpremiElement.Name = "uiActionSpremiElement";
            this.uiActionSpremiElement.Size = new System.Drawing.Size(112, 51);
            this.uiActionSpremiElement.TabIndex = 8;
            this.uiActionSpremiElement.Text = "Spremi";
            this.uiActionSpremiElement.UseVisualStyleBackColor = false;
            this.uiActionSpremiElement.Click += new System.EventHandler(this.uiActionSpremiElement_Click);
            // 
            // uiDodajUrediElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 243);
            this.Controls.Add(this.uiActionSpremiElement);
            this.Controls.Add(id_elementLabel);
            this.Controls.Add(this.uiInputElementElement);
            this.Controls.Add(id_proizvodLabel);
            this.Controls.Add(this.uiInputElementProizvod);
            this.Controls.Add(kolicinaLabel);
            this.Controls.Add(this.uiInputElementKolicina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "uiDodajUrediElement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uiDodajUediElement";
            this.Load += new System.EventHandler(this.uiDodajUediElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource elementBindingSource;
        private Baza18043_DBDataSetTableAdapters.ElementTableAdapter elementTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox uiInputElementKolicina;
        private System.Windows.Forms.ComboBox uiInputElementProizvod;
        private System.Windows.Forms.TextBox uiInputElementElement;
        private System.Windows.Forms.Button uiActionSpremiElement;
    }
}