﻿namespace RashoApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiDjelovi));
            this.uiActionDodajNoviDio = new System.Windows.Forms.Button();
            this.uiActionUrediDio = new System.Windows.Forms.Button();
            this.uiActionObrišiDio = new System.Windows.Forms.Button();
            this.uiOutputTableDataDio = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duljinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza18043_DBDataSet = new RashoApp.Baza18043_DBDataSet();
            this.dioTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.DioTableAdapter();
            this.tableAdapterManager = new RashoApp.Baza18043_DBDataSetTableAdapters.TableAdapterManager();
            this.komponentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komponentaTableAdapter = new RashoApp.Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataDio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionDodajNoviDio
            // 
            this.uiActionDodajNoviDio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionDodajNoviDio.BackColor = System.Drawing.Color.LimeGreen;
            this.uiActionDodajNoviDio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDodajNoviDio.ForeColor = System.Drawing.Color.White;
            this.uiActionDodajNoviDio.Location = new System.Drawing.Point(327, 360);
            this.uiActionDodajNoviDio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiActionDodajNoviDio.Name = "uiActionDodajNoviDio";
            this.uiActionDodajNoviDio.Size = new System.Drawing.Size(73, 32);
            this.uiActionDodajNoviDio.TabIndex = 1;
            this.uiActionDodajNoviDio.Text = "Dodaj";
            this.uiActionDodajNoviDio.UseVisualStyleBackColor = false;
            this.uiActionDodajNoviDio.Click += new System.EventHandler(this.uiActionDodajNoviDio_Click);
            // 
            // uiActionUrediDio
            // 
            this.uiActionUrediDio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionUrediDio.BackColor = System.Drawing.Color.Gold;
            this.uiActionUrediDio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionUrediDio.ForeColor = System.Drawing.Color.White;
            this.uiActionUrediDio.Location = new System.Drawing.Point(422, 360);
            this.uiActionUrediDio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiActionUrediDio.Name = "uiActionUrediDio";
            this.uiActionUrediDio.Size = new System.Drawing.Size(73, 32);
            this.uiActionUrediDio.TabIndex = 2;
            this.uiActionUrediDio.Text = "Uredi";
            this.uiActionUrediDio.UseVisualStyleBackColor = false;
            this.uiActionUrediDio.Click += new System.EventHandler(this.uiActionUrediDio_Click);
            // 
            // uiActionObrišiDio
            // 
            this.uiActionObrišiDio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionObrišiDio.BackColor = System.Drawing.Color.Crimson;
            this.uiActionObrišiDio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionObrišiDio.ForeColor = System.Drawing.Color.White;
            this.uiActionObrišiDio.Location = new System.Drawing.Point(520, 360);
            this.uiActionObrišiDio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiActionObrišiDio.Name = "uiActionObrišiDio";
            this.uiActionObrišiDio.Size = new System.Drawing.Size(73, 32);
            this.uiActionObrišiDio.TabIndex = 3;
            this.uiActionObrišiDio.Text = "Obriši";
            this.uiActionObrišiDio.UseVisualStyleBackColor = false;
            this.uiActionObrišiDio.Click += new System.EventHandler(this.uiActionObrišiDio_Click);
            // 
            // uiOutputTableDataDio
            // 
            this.uiOutputTableDataDio.AllowUserToAddRows = false;
            this.uiOutputTableDataDio.AllowUserToDeleteRows = false;
            this.uiOutputTableDataDio.AllowUserToOrderColumns = true;
            this.uiOutputTableDataDio.AutoGenerateColumns = false;
            this.uiOutputTableDataDio.BackgroundColor = System.Drawing.Color.White;
            this.uiOutputTableDataDio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiOutputTableDataDio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.duljinaDataGridViewTextBoxColumn,
            this.sirinaDataGridViewTextBoxColumn,
            this.visinaDataGridViewTextBoxColumn,
            this.materijalDataGridViewTextBoxColumn,
            this.slikaDataGridViewTextBoxColumn});
            this.uiOutputTableDataDio.DataSource = this.dioBindingSource;
            this.uiOutputTableDataDio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiOutputTableDataDio.Location = new System.Drawing.Point(8, 0);
            this.uiOutputTableDataDio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiOutputTableDataDio.MultiSelect = false;
            this.uiOutputTableDataDio.Name = "uiOutputTableDataDio";
            this.uiOutputTableDataDio.ReadOnly = true;
            this.uiOutputTableDataDio.RowHeadersVisible = false;
            this.uiOutputTableDataDio.RowTemplate.Height = 24;
            this.uiOutputTableDataDio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiOutputTableDataDio.Size = new System.Drawing.Size(594, 413);
            this.uiOutputTableDataDio.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duljinaDataGridViewTextBoxColumn
            // 
            this.duljinaDataGridViewTextBoxColumn.DataPropertyName = "duljina";
            this.duljinaDataGridViewTextBoxColumn.HeaderText = "Dužina";
            this.duljinaDataGridViewTextBoxColumn.Name = "duljinaDataGridViewTextBoxColumn";
            this.duljinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sirinaDataGridViewTextBoxColumn
            // 
            this.sirinaDataGridViewTextBoxColumn.DataPropertyName = "sirina";
            this.sirinaDataGridViewTextBoxColumn.HeaderText = "Širina";
            this.sirinaDataGridViewTextBoxColumn.Name = "sirinaDataGridViewTextBoxColumn";
            this.sirinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visinaDataGridViewTextBoxColumn
            // 
            this.visinaDataGridViewTextBoxColumn.DataPropertyName = "visina";
            this.visinaDataGridViewTextBoxColumn.HeaderText = "Debljina";
            this.visinaDataGridViewTextBoxColumn.Name = "visinaDataGridViewTextBoxColumn";
            this.visinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materijalDataGridViewTextBoxColumn
            // 
            this.materijalDataGridViewTextBoxColumn.DataPropertyName = "materijal";
            this.materijalDataGridViewTextBoxColumn.HeaderText = "Materijal";
            this.materijalDataGridViewTextBoxColumn.Name = "materijalDataGridViewTextBoxColumn";
            this.materijalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slikaDataGridViewTextBoxColumn
            // 
            this.slikaDataGridViewTextBoxColumn.DataPropertyName = "slika";
            this.slikaDataGridViewTextBoxColumn.HeaderText = "Slika";
            this.slikaDataGridViewTextBoxColumn.Name = "slikaDataGridViewTextBoxColumn";
            this.slikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.slikaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.slikaDataGridViewTextBoxColumn.Visible = false;
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
            // komponentaBindingSource
            // 
            this.komponentaBindingSource.DataMember = "Komponenta";
            this.komponentaBindingSource.DataSource = this.baza18043_DBDataSet;
            // 
            // komponentaTableAdapter
            // 
            this.komponentaTableAdapter.ClearBeforeFill = true;
            // 
            // uiDjelovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(602, 413);
            this.Controls.Add(this.uiActionObrišiDio);
            this.Controls.Add(this.uiActionUrediDio);
            this.Controls.Add(this.uiActionDodajNoviDio);
            this.Controls.Add(this.uiOutputTableDataDio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uiDjelovi";
            this.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.Text = "Djelovi";
            this.Load += new System.EventHandler(this.uiDjelovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiOutputTableDataDio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza18043_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Baza18043_DBDataSet baza18043_DBDataSet;
        private System.Windows.Forms.BindingSource dioBindingSource;
        private System.Windows.Forms.Button uiActionDodajNoviDio;
        private System.Windows.Forms.Button uiActionUrediDio;
        private System.Windows.Forms.Button uiActionObrišiDio;
        private Baza18043_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView uiOutputTableDataDio;
        private Baza18043_DBDataSetTableAdapters.DioTableAdapter dioTableAdapter;
        private System.Windows.Forms.BindingSource komponentaBindingSource;
        private Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter komponentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duljinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikaDataGridViewTextBoxColumn;
    }
}