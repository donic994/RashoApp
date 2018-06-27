using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    uiGlavniIzbornik glavnaForma = new uiGlavniIzbornik();
                    glavnaForma.Show();
                    this.Close();
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
