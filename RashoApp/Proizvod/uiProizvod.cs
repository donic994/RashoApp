﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RashoApp.Proizvod
{
    public partial class uiProizvod : Form
    {
        int idProizvoda = 0;

        public uiProizvod()
        {
            InitializeComponent();
        }

        private void uiProizvod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Proizvod' table. You can move, or remove it, as needed.
            this.proizvodTableAdapter.Fill(this.baza18043_DBDataSet.Proizvod);

        }

        private void proizvodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proizvodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }


        private void uiActionDodajNoviProizvod_Click(object sender, EventArgs e)
        {

        }

        private void uiActionUrediProizvod_Click(object sender, EventArgs e)
        {

        }

        private void uiActionObrišiProizvod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite obrisati ovaj proizvoid?", "Obrisati proizvod", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                uiOutputDataProizvod.Rows.RemoveAt(uiOutputDataProizvod.CurrentRow.Index);
            }
        }

        private void uiProizvod_SizeChanged(object sender, EventArgs e)
        {
            uiOutputDataProizvod.Height = this.Height / 3;
            uiOutputTableDataElement.Height = this.Height / 3;
            uiOutputTableDataPogledDjelovaPoProoizvodu.Height = this.Height / 3;

            uiOutputDataProizvod.Location = new Point(0, 0);
            uiOutputTableDataElement.Location = new Point(0, (this.Height / 3));
            uiOutputTableDataPogledDjelovaPoProoizvodu.Location = new Point(0, (this.Height / 3)*2);
        }

        private void uiOutputDataProizvod_SelectionChanged(object sender, EventArgs e)
        {
            idProizvoda = int.Parse(uiOutputDataProizvod.SelectedCells[0].Value.ToString());
            this.elementTableAdapter.FillByIdProizvoda(this.baza18043_DBDataSet.Element, idProizvoda);

            this.pogledDjelovaPoProoizvoduTableAdapter.FillByIDElementProizvod(this.baza18043_DBDataSet.PogledDjelovaPoProoizvodu, idProizvoda);
        }
        
        private void uiOutputTableDataElement_SelectionChanged(object sender, EventArgs e)
        {
            //this.pogledDjelovaPoProoizvoduTableAdapter.FillByIDElementProizvod(this.baza18043_DBDataSet.PogledDjelovaPoProoizvodu, idProizvoda);
        }
        
    }
}