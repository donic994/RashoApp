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

        private void uiKorisnici_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.UlogaKorisnika' table. You can move, or remove it, as needed.
            this.ulogaKorisnikaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaKorisnika);
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.baza18043_DBDataSet.Korisnik);

        }

        private void uiActionDodaj_Click(object sender, EventArgs e) {
            UIKorisnik frm = new UIKorisnik();
            frm.ShowDialog();
            this.korisnikTableAdapter.Fill(this.baza18043_DBDataSet.Korisnik);
        }

        private void uiActionUredi_Click(object sender, EventArgs e) {
            UIKorisnik frm = new UIKorisnik(int.Parse(uiOutputTableDataKorisnici.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();
            this.korisnikTableAdapter.Fill(this.baza18043_DBDataSet.Korisnik);
        }

        private void uiActionObriši_Click(object sender, EventArgs e) {
            korisnikTableAdapter.DeleteRow(int.Parse(uiOutputTableDataKorisnici.CurrentRow.Cells[0].Value.ToString()));
            this.korisnikTableAdapter.Fill(this.baza18043_DBDataSet.Korisnik);
        }
    }
}
