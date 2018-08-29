using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordHashDLL;

/// <summary>
/// Klasa uiPrijava otvara se pri pokretanju aplikacije. Sadrži dva tekstualna polja u koja se redom unose korisničko ime i lozinka.
/// Nakon što korisnik klikne na gumb uiAkcijaPrijaviSe, kreira se objekt klase PasswordHash preko kojega se provjeravaju podaci o korisniku
/// te ako su ispravni, korisniku se otvara glavni izbornik, a u suprotnom se ispisuje poruka greške.
/// Nakon što korisnik završi s radom u aplikaciji, ponovno se otvara ova forma da bi se mogao prijaviti drugi korisnik.
/// </summary>

namespace RashoApp
{
    public partial class UIPrijava : Form
    {
        Baza18043_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;

        public UIPrijava() {
            InitializeComponent();
            
            korisnikTableAdapter = new Baza18043_DBDataSetTableAdapters.KorisnikTableAdapter();
        }

        private void uiAkcijaPrijaviSe_Click(object sender, EventArgs e) {
            uiOznakaGreškaUPrijavi.Text = "";
            Baza18043_DBDataSet.KorisnikRow korisnik;

            // Dohvati korisnika iz baze
            try {
                korisnik = korisnikTableAdapter.GetDataByKorisnickoIme(uiInputKorisničkoIme.Text)[0];
            } catch (IndexOutOfRangeException) {
                uiOznakaGreškaUPrijavi.Text = "Uneseni korisnik ne postoji.";
                return;
            }

            bool lozinkaIspravna = false;
            PasswordHash phObj = new PasswordHash();

            lozinkaIspravna = phObj.Verify(uiInputLozinka.Text, korisnik.lozinka);
            if (lozinkaIspravna) {
                LoginInfo.OtvoriSesiju(korisnik);
                PrikaziGlavnuFormu();

                // Nakon zatvaranja glavne forme
                LoginInfo.ZatvoriSesiju();
                uiInputKorisničkoIme.Focus();
            } else {
                uiOznakaGreškaUPrijavi.Text = "Pogrešna lozinka";
            }

        }

        private void PrikaziGlavnuFormu() {
            this.Hide();
            uiGlavniIzbornik glavnaForma = new uiGlavniIzbornik();
            glavnaForma.ShowDialog();

            uiInputKorisničkoIme.Text = "";
            uiInputLozinka.Text = "";
            this.Show();
        }
    }
}
