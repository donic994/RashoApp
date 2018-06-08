namespace RashoApp
{
    partial class uiDjelovi
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
            this.uiOutputTableDataDio = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duljinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.dioTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.DioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataDio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOutputTableDataDio
            // 
            this.uiOutputTableDataDio.AllowUserToAddRows = false;
            this.uiOutputTableDataDio.AllowUserToDeleteRows = false;
            this.uiOutputTableDataDio.AutoGenerateColumns = false;
            this.uiOutputTableDataDio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiOutputTableDataDio.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.uiOutputTableDataDio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputTableDataDio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.duljinaDataGridViewTextBoxColumn,
            this.sirinaDataGridViewTextBoxColumn,
            this.visinaDataGridViewTextBoxColumn,
            this.slikaDataGridViewTextBoxColumn,
            this.materijalDataGridViewTextBoxColumn});
            this.uiOutputTableDataDio.DataSource = this.dioBindingSource;
            this.uiOutputTableDataDio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiOutputTableDataDio.Location = new System.Drawing.Point(0, 0);
            this.uiOutputTableDataDio.Name = "uiOutputTableDataDio";
            this.uiOutputTableDataDio.RowTemplate.Height = 24;
            this.uiOutputTableDataDio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputTableDataDio.Size = new System.Drawing.Size(796, 500);
            this.uiOutputTableDataDio.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // duljinaDataGridViewTextBoxColumn
            // 
            this.duljinaDataGridViewTextBoxColumn.DataPropertyName = "duljina";
            this.duljinaDataGridViewTextBoxColumn.HeaderText = "Duljina(mm)";
            this.duljinaDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.duljinaDataGridViewTextBoxColumn.Name = "duljinaDataGridViewTextBoxColumn";
            // 
            // sirinaDataGridViewTextBoxColumn
            // 
            this.sirinaDataGridViewTextBoxColumn.DataPropertyName = "sirina";
            this.sirinaDataGridViewTextBoxColumn.HeaderText = "Širina(mm)";
            this.sirinaDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.sirinaDataGridViewTextBoxColumn.Name = "sirinaDataGridViewTextBoxColumn";
            // 
            // visinaDataGridViewTextBoxColumn
            // 
            this.visinaDataGridViewTextBoxColumn.DataPropertyName = "visina";
            this.visinaDataGridViewTextBoxColumn.HeaderText = "Visina(mm)";
            this.visinaDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.visinaDataGridViewTextBoxColumn.Name = "visinaDataGridViewTextBoxColumn";
            // 
            // slikaDataGridViewTextBoxColumn
            // 
            this.slikaDataGridViewTextBoxColumn.DataPropertyName = "slika";
            this.slikaDataGridViewTextBoxColumn.HeaderText = "Slika";
            this.slikaDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.slikaDataGridViewTextBoxColumn.Name = "slikaDataGridViewTextBoxColumn";
            // 
            // materijalDataGridViewTextBoxColumn
            // 
            this.materijalDataGridViewTextBoxColumn.DataPropertyName = "materijal";
            this.materijalDataGridViewTextBoxColumn.HeaderText = "Materijal";
            this.materijalDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.materijalDataGridViewTextBoxColumn.Name = "materijalDataGridViewTextBoxColumn";
            // 
            // dioBindingSource
            // 
            this.dioBindingSource.DataMember = "Dio";
            this.dioBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // baza18043_DBDataSet
            // 
            this.baza18043_DBDataSet.DataSetName = "Baza18043_DBDataSet";
            this.baza18043_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dioTableAdapter
            // 
            this.dioTableAdapter.ClearBeforeFill = true;
            // 
            // uiDjelovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(796, 500);
            this.Controls.Add(this.uiOutputTableDataDio);
            this.Name = "uiDjelovi";
            this.Text = "uiDjelovi";
            this.Load += new System.EventHandler(this.uiDjelovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataDio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uiOutputTableDataDio;
        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource dioBindingSource;
        private Baza18043_DBDataSetTableAdapters.DioTableAdapter dioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duljinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalDataGridViewTextBoxColumn;
    }
}