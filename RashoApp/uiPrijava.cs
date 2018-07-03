using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Klasa uiPrijava otvara se pri pokretanju aplikacije. Sadrži dva tekstualna polja u koja se redom unose korisničko ime i lozinka.
/// Nakon što korisnik klikne na gumb uiAkcijaPrijaviSe, kreira se objekt klase PasswordHash preko kojega se provjeravaju podaci o korisniku
/// te ako su ispravni, korisniku se otvara glavni izbornik, a u suprotnom se ispisuje poruka greške.
/// Nakon što korisnik završi s radom u aplikaciji, ponovno se otvara ova forma da bi se mogao prijaviti drugi korisnik.
/// </summary>

namespace RashoApp
{
    public partial class uiPrijava : Form
    {
        Baza18043_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;

        public uiPrijava() {
            InitializeComponent();
            korisnikTableAdapter = new Baza18043_DBDataSetTableAdapters.KorisnikTableAdapter();
        }

        private void uiAkcijaPrijaviSe_Click(object sender, EventArgs e) {
            var korisnik = korisnikTableAdapter.GetDataByKorisnickoIme(uiInputKorisničkoIme.Text);
            bool isValid = false;
            PasswordHash phObj = new PasswordHash();

            try {
                isValid = phObj.Verify(uiInputLozinka.Text, korisnik[0].lozinka);
                if (isValid) {
                    this.Hide();
                    uiGlavniIzbornik glavnaForma = new uiGlavniIzbornik();
                    glavnaForma.ShowDialog();

                    uiInputKorisničkoIme.Text = "";
                    uiInputLozinka.Text = "";
                    this.Show();
                }
                else {
                    uiOznakaGreškaUPrijavi.Text = "Pogrešna lozinka";
                }
            } catch (IndexOutOfRangeException) {
                uiOznakaGreškaUPrijavi.Text = "Uneseni korisnik ne postoji.";
            }
        }
    }
}
