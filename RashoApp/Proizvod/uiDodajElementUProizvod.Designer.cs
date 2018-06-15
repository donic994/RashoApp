namespace RashoApp.Proizvod
{
    partial class uiDodajElementUProizvod
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
            System.Windows.Forms.Label id_elementLabel;
            System.Windows.Forms.Label kolicinaLabel;
            this.uiOutputNazivElement = new System.Windows.Forms.TextBox();
            this.uiActionOdaberiElement = new System.Windows.Forms.Button();
            this.uiActionSpremiElement = new System.Windows.Forms.Button();
            this.uiInputElementElement = new System.Windows.Forms.TextBox();
            this.uiInputElementKolicina = new System.Windows.Forms.TextBox();
            this.uiActionDalje = new System.Windows.Forms.Button();
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.elementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.ElementTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.uiOutputDataTableElement = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_elementLabel = new System.Windows.Forms.Label();
            kolicinaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDataTableElement)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputNazivElement
            // 
            this.uiOutputNazivElement.Location = new System.Drawing.Point(86, 55);
            this.uiOutputNazivElement.Name = "uiOutputNazivElement";
            this.uiOutputNazivElement.ReadOnly = true;
            this.uiOutputNazivElement.Size = new System.Drawing.Size(161, 22);
            this.uiOutputNazivElement.TabIndex = 24;
            // 
            // uiActionOdaberiElement
            // 
            this.uiActionOdaberiElement.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionOdaberiElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionOdaberiElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdaberiElement.ForeColor = System.Drawing.Color.White;
            this.uiActionOdaberiElement.Location = new System.Drawing.Point(251, 55);
            this.uiActionOdaberiElement.Margin = new System.Windows.Forms.Padding(0);
            this.uiActionOdaberiElement.Name = "uiActionOdaberiElement";
            this.uiActionOdaberiElement.Size = new System.Drawing.Size(30, 24);
            this.uiActionOdaberiElement.TabIndex = 21;
            this.uiActionOdaberiElement.Text = "+";
            this.uiActionOdaberiElement.UseVisualStyleBackColor = false;
            this.uiActionOdaberiElement.Click += new System.EventHandler(this.uiActionOdaberiElement_Click);
            // 
            // uiActionSpremiElement
            // 
            this.uiActionSpremiElement.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionSpremiElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionSpremiElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionSpremiElement.ForeColor = System.Drawing.Color.White;
            this.uiActionSpremiElement.Location = new System.Drawing.Point(346, 121);
            this.uiActionSpremiElement.Name = "uiActionSpremiElement";
            this.uiActionSpremiElement.Size = new System.Drawing.Size(112, 51);
            this.uiActionSpremiElement.TabIndex = 18;
            this.uiActionSpremiElement.Text = "Spremi";
            this.uiActionSpremiElement.UseVisualStyleBackColor = false;
            this.uiActionSpremiElement.Click += new System.EventHandler(this.uiActionSpremiElement_Click);
            // 
            // id_elementLabel
            // 
            id_elementLabel.AutoSize = true;
            id_elementLabel.Location = new System.Drawing.Point(17, 55);
            id_elementLabel.Name = "id_elementLabel";
            id_elementLabel.Size = new System.Drawing.Size(63, 17);
            id_elementLabel.TabIndex = 16;
            id_elementLabel.Text = "Element:";
            // 
            // uiInputElementElement
            // 
            this.uiInputElementElement.Location = new System.Drawing.Point(284, 56);
            this.uiInputElementElement.Name = "uiInputElementElement";
            this.uiInputElementElement.ReadOnly = true;
            this.uiInputElementElement.Size = new System.Drawing.Size(22, 22);
            this.uiInputElementElement.TabIndex = 17;
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(19, 30);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(61, 17);
            kolicinaLabel.TabIndex = 14;
            kolicinaLabel.Text = "Količina:";
            // 
            // uiInputElementKolicina
            // 
            this.uiInputElementKolicina.Location = new System.Drawing.Point(86, 27);
            this.uiInputElementKolicina.Name = "uiInputElementKolicina";
            this.uiInputElementKolicina.Size = new System.Drawing.Size(100, 22);
            this.uiInputElementKolicina.TabIndex = 15;
            // 
            // uiActionDalje
            // 
            this.uiActionDalje.BackColor = System.Drawing.Color.DarkTurquoise;
            this.uiActionDalje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDalje.ForeColor = System.Drawing.Color.White;
            this.uiActionDalje.Location = new System.Drawing.Point(346, 30);
            this.uiActionDalje.Name = "uiActionDalje";
            this.uiActionDalje.Size = new System.Drawing.Size(112, 51);
            this.uiActionDalje.TabIndex = 25;
            this.uiActionDalje.Text = "DODAJ";
            this.uiActionDalje.UseVisualStyleBackColor = false;
            this.uiActionDalje.Click += new System.EventHandler(this.uiActionDalje_Click);
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
            // uiOutputDataTableElement
            // 
            this.uiOutputDataTableElement.AllowUserToAddRows = false;
            this.uiOutputDataTableElement.AllowUserToDeleteRows = false;
            this.uiOutputDataTableElement.AutoGenerateColumns = false;
            this.uiOutputDataTableElement.BackgroundColor = System.Drawing.Color.White;
            this.uiOutputDataTableElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputDataTableElement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.uiOutputDataTableElement.DataSource = this.elementBindingSource;
            this.uiOutputDataTableElement.Location = new System.Drawing.Point(0, 121);
            this.uiOutputDataTableElement.Name = "uiOutputDataTableElement";
            this.uiOutputDataTableElement.ReadOnly = true;
            this.uiOutputDataTableElement.RowHeadersVisible = false;
            this.uiOutputDataTableElement.RowTemplate.Height = 24;
            this.uiOutputDataTableElement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputDataTableElement.Size = new System.Drawing.Size(318, 220);
            this.uiOutputDataTableElement.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kolicina";
            this.dataGridViewTextBoxColumn1.HeaderText = "kolicina";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_proizvod";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_proizvod";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_element";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_element";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // uiDodajElementUProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 342);
            this.Controls.Add(this.uiOutputDataTableElement);
            this.Controls.Add(this.uiActionDalje);
            this.Controls.Add(this.uiOutputNazivElement);
            this.Controls.Add(this.uiActionOdaberiElement);
            this.Controls.Add(this.uiActionSpremiElement);
            this.Controls.Add(id_elementLabel);
            this.Controls.Add(this.uiInputElementElement);
            this.Controls.Add(kolicinaLabel);
            this.Controls.Add(this.uiInputElementKolicina);
            this.Name = "uiDodajElementUProizvod";
            this.Text = "uiDodajElementUProizvod";
            this.Load += new System.EventHandler(this.uiDodajElementUProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputDataTableElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiOutputNazivElement;
        private System.Windows.Forms.Button uiActionOdaberiElement;
        private System.Windows.Forms.Button uiActionSpremiElement;
        private System.Windows.Forms.TextBox uiInputElementElement;
        private System.Windows.Forms.TextBox uiInputElementKolicina;
        private System.Windows.Forms.Button uiActionDalje;
        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource elementBindingSource;
        private Baza18043_DBDataSetTableAdapters.ElementTableAdapter elementTableAdapter;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView uiOutputDataTableElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}