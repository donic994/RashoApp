﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RashoApp.Element
{
    public partial class uiElement : Form
    {
        public uiElement()
        {
            InitializeComponent();
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.elementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiElement_Load(object sender, EventArgs e)
        {
            PopuniPodacimaElement();
        }

        public void PopuniPodacimaElement()
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Proizvod' table. You can move, or remove it, as needed.
            this.proizvodTableAdapter.Fill(this.baza18043_DBDataSet.Proizvod);
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Element' table. You can move, or remove it, as needed.
            this.elementTableAdapter.Fill(this.baza18043_DBDataSet.Element);
        }

        private void uiActionDodajNoviDio_Click(object sender, EventArgs e)
        {
            int proizvod = int.Parse(uiOutputTableDataElement.SelectedCells[1].Value.ToString());
            int element = int.Parse(uiOutputTableDataElement.SelectedCells[2].Value.ToString());
            Element.uiDodajUrediElement frm = new Element.uiDodajUrediElement(proizvod, element, "dodaj");
            frm.ShowDialog();
        }

        private void uiActionUrediDio_Click(object sender, EventArgs e)
        {
            if(uiOutputTableDataElement.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite element koji želite urediti!");
            }
            else
            {
                int proizvod = int.Parse(uiOutputTableDataElement.SelectedCells[1].Value.ToString());
                int element = int.Parse(uiOutputTableDataElement.SelectedCells[2].Value.ToString());
                Element.uiDodajUrediElement frm = new Element.uiDodajUrediElement(proizvod, element, "uredi");
                frm.ShowDialog();
            }
        }

        private void uiActionObrišiDio_Click(object sender, EventArgs e)
        {
            if (uiOutputTableDataElement.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite element koji želite obrisati!");
            }
            else if (MessageBox.Show("Jeste li sigurni da želite obrisati ovaj element?", "Obrisati element", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                uiOutputTableDataElement.Rows.RemoveAt(uiOutputTableDataElement.CurrentRow.Index);
            }
            SpremiPromjene();
        }

    }
}
