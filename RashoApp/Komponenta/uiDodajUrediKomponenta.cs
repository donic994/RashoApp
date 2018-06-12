﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RashoApp.Komponenta
{
    public partial class uiDodajUrediKomponenta : Form
    {
        private int dio = 0;
        private int uloga = 0;
        private int proizvod = 0;
        private string kontrola = "";

        public uiDodajUrediKomponenta(int Dio, int Uloga , int Proizvod, string Kontrola)
        {
            InitializeComponent();

            dio = Dio;
            uloga = Uloga;
            proizvod = Proizvod;
            kontrola = Kontrola;

            if (kontrola == "dodaj")
            {
                uiActionSpremiKomponenta.BackColor = Color.LimeGreen;
                this.Text = "Dodaj komponentu";
            }
            if (kontrola == "uredi")
            {
                uiActionSpremiKomponenta.BackColor = Color.Gold;
                this.Text = "Uredi komponentu";
            }
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.komponentaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiDodajUrediKomponenta_Load(object sender, EventArgs e)
        {
            if (kontrola == "uredi")
            {
                // TODO: This line of code loads data into the 'baza18043_DBDataSet.Komponenta' table. You can move, or remove it, as needed.
                this.komponentaTableAdapter.FillByDioUlogaProizvod(this.baza18043_DBDataSet.Komponenta, uloga, dio,proizvod);
            }

        }

        private void uiActionSpremiKomponenta_Click(object sender, EventArgs e)
        {
            if (kontrola == "uredi")
            {
                SpremiPromjene();
            }
            if (kontrola == "dodaj")
            {
                int kolicina = int.Parse(uiInputKomponentaKolicina.Text.ToString());
                string boja = uiInputKomponentaBoja.Text;
                string kantiranost = uiInputKomponentaKantoranost.Text;
                int uloga = int.Parse(uiInputKomponentaUloga.Text.ToString());
                int dio = int.Parse(uiInputKomponentaDio.Text.ToString());
                int proizvod = int.Parse(uiInputKomponentaProizvod.Text.ToString());

                Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter noviKomponentaTableAdapter = new Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter();
                noviKomponentaTableAdapter.Insert(kolicina, boja, kantiranost, uloga, dio, proizvod);

                SpremiPromjene();
            }

            this.Close();
        }
    }
}