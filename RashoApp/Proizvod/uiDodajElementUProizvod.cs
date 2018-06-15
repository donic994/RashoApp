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
    public partial class uiDodajElementUProizvod : Form
    {

        private int ProizvodID;

        public uiDodajElementUProizvod(int proizvodID)
        {
            InitializeComponent();
            ProizvodID = proizvodID;
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.elementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiDodajElementUProizvod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Element' table. You can move, or remove it, as needed.
            this.elementTableAdapter.FillByIdProizvoda(this.baza18043_DBDataSet.Element, ProizvodID);

        }

        private void uiActionOdaberiElement_Click(object sender, EventArgs e)
        {
            RashoApp.Proizvod.uiDodajElementUProizvod frm = new RashoApp.Proizvod.uiDodajElementUProizvod(ProizvodID);
            frm.ShowDialog();
        }

        private void uiActionDalje_Click(object sender, EventArgs e)
        {
            int kolicina = 1;
            int.TryParse(uiInputElementKolicina.Text.ToString(), out kolicina);
            int element = int.Parse(uiInputElementElement.Text.ToString());

            Baza18043_DBDataSetTableAdapters.ElementTableAdapter noviElementTableAdapter = new Baza18043_DBDataSetTableAdapters.ElementTableAdapter();
            noviElementTableAdapter.Insert(kolicina, ProizvodID, element);

            SpremiPromjene();
        }


        public void PostaviVrijednostOdabranogElementa(string ID, string naziv)
        {
            uiInputElementElement.Text = ID;
            uiOutputNazivElement.Text = naziv;
        }

        private void uiActionSpremiElement_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}