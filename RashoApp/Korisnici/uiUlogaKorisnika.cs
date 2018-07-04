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
/// uiUlogaKorisnika služi za dodavanje ili izmjenu već postojećih uloga korisnika
/// Konstruktor prima jedan parametar koji označava ID uloge (default je -1; označava da korisnik nije odabrao već postojeću ulogu nego se kreira nova)
/// U slučaju da je prenesen ID konstruktoru, automatski će se popuniti polja podacima iz baze te nakon klika na gumb uiActionPrihvati, ažurirat će se uloga u bazi.
/// U slučaju da nije prenesen ID uloge, tada program prepoznaje da korisnik unosi novu ulogu i nakon prihvaćanja, dodaje se nova uloga u bazu.
/// </summary>

namespace RashoApp.Korisnici {

    public partial class uiUlogaKorisnika : Form {

        private int ulogaID;
        private Baza18043_DBDataSetTableAdapters.UlogaKorisnikaTableAdapter ulogaTableAdapter;

        public uiUlogaKorisnika(int ulogaID=-1) {
            InitializeComponent();
            ulogaTableAdapter = new Baza18043_DBDataSetTableAdapters.UlogaKorisnikaTableAdapter();
            this.ulogaID = ulogaID;
            if (ulogaID > 0) {
                uiInputID.Text = ulogaID.ToString();
                var uloga = ulogaTableAdapter.GetDataByID(ulogaID);
                uiInputNaziv.Text = uloga[0].naziv;
                uiInputOpis.Text = uloga[0].opis;
            }
        }

        private void uiActionDodaj_Click(object sender, EventArgs e) {
            if (ulogaID > 0) {
                ulogaTableAdapter.UpdateRow(uiInputNaziv.Text, uiInputOpis.Text, ulogaID);
            } else if (uiInputNaziv.Text.Length > 0) {
                try {
                    ulogaTableAdapter.InsertRow(uiInputNaziv.Text, uiInputOpis.Text);
                    Close();
                } catch (Exception) {
                    uiOznakaGreška.Text = "Greška: Promjene nisu spremljene.";
                }
            } else {
                uiOznakaGreška.Text = "Unesite naziv uloge";
            }
        }

        private void uiActionPoništi_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
