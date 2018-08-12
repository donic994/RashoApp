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
/// Na formi uiKorisnici vidimo popis svih korisnika u bazi i njihove podatke. Odabirom na korisnika i pritiskom na jedan od gumbova
/// (uiActionDodaj, uiActionUredi, uiActionObriši) možemo upravljati odabranim korisnikom.
/// Klikom na gumb Dodaj, otvara se forma uiKorisnik u kojoj upisujemo podatke. Klikom na gumb Uredi, otvara se ista forma sa već popunitim podacima iz baze.
/// Klikom na gumb Obriši, briše se korisnik iz baze. Nakon svake od navedenih akcija, tablica se ažurira.
/// </summary>

namespace RashoApp.Korisnici {
    public partial class UIKorisnici : Form {
        public UIKorisnici() {
            InitializeComponent();
        }

        private void korisnikBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.korisnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);
        }

        // Učitava korisnike u tablicu pri pokretanju
        private void uiKorisnici_Load(object sender, EventArgs e) {
            this.ulogaKorisnikaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaKorisnika);
            this.korisnikTableAdapter.Fill(this.baza18043_DBDataSet.Korisnik);
        }

        // Otvara formu za unos/izmjenu korisnika klikom na gumb
        private void uiActionDodaj_Click(object sender, EventArgs e) {
            UIKorisnik frm = new UIKorisnik();
            frm.ShowDialog();
            this.korisnikTableAdapter.Fill(this.baza18043_DBDataSet.Korisnik);
        }

        // Otvara formu za unos/izmjenu korisnika klikom na gumb
        private void uiActionUredi_Click(object sender, EventArgs e) {
            int idKorisnika = int.Parse(uiOutputTableDataKorisnici.CurrentRow.Cells[0].Value.ToString());
            UIKorisnik frm = new UIKorisnik(idKorisnika);
            frm.ShowDialog();
            this.korisnikTableAdapter.Fill(this.baza18043_DBDataSet.Korisnik);
        }

        // Briše označenog korisnika iz baze
        private void uiActionObriši_Click(object sender, EventArgs e) {

            int idKorisnika = int.Parse(uiOutputTableDataKorisnici.CurrentRow.Cells[0].Value.ToString());

            if (idKorisnika != LoginInfo.UserID) {
                try {
                    korisnikTableAdapter.DeleteRow(idKorisnika);
                    this.korisnikTableAdapter.Fill(this.baza18043_DBDataSet.Korisnik);
                } catch(Exception) {
                    uiOznakaGreška.Text = "Korisnik ne može biti obrisan.";
                }
            } else {
                uiOznakaGreška.Text = "Nemoguće obrisati trenutno prijavljenog korisnika.";
            }

        }
    }
}
