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
/// U formi uiKorisnik moguća je izmjena postojećih korisnika (prosljeđen ID korisnika) i kreiranje novih (nije prosljeđen ID korisnika).
/// Konstruktor prima jedan parametar, ID korisnika. Korisnik se dohvati iz baze i podaci se automatski popune za njega. Nakon promjene podataka
/// klikom na gumb uiActionPrihvati, promjene se spremaju u bazu i forma se zatvara.
/// U slučaju da parametar nije prosljeđen, aplikacija prepoznaje da je riječ o kreiranju novog korisnika te klikom na gumb uiActionPrihvati,
/// novi korisnik se unosi u bazu.
/// </summary>

namespace RashoApp.Korisnici {

    public partial class UIKorisnik : Form {

        private int korisnikID;

        public UIKorisnik(int korisnikID=-1) {
            InitializeComponent();

            this.korisnikID = korisnikID;

            // Ako je ID korisnika prenesen ovoj formi (ako se radi o izmjeni korisnika)
            if (korisnikID >= 0) {
                IspuniPodatkeOKorisniku();
            }
        }

        // Ispunjava formu podacima iz baze radi lakše izmjene podataka o korisniku
        private void IspuniPodatkeOKorisniku() {
            uiInputID.Text = korisnikID.ToString();
            var korisnik = korisnikTableAdapter.GetDataByID(korisnikID)[0];
            uiInputIme.Text = korisnik.ime;
            uiInputPrezime.Text = korisnik.prezime;
            uiInputEmail.Text = korisnik.adresa;
            uiInputAdresa.Text = korisnik.adresa;
            uiInputKorisničkoIme.Text = korisnik.korisnickoIme;
            uiInputKontaktBroj.Text = korisnik.kontaktBroj;
            uiInputOdabirUloga.SelectedValue = korisnik.id_uloga;
        }

        private void uiKorisnik_Load(object sender, EventArgs e) {
            this.ulogaKorisnikaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaKorisnika);
        }

        private void uiActionPrihvati_Click(object sender, EventArgs e) {

            if (!IsInputValid()) {
                return;
            }

            PasswordHash phObj = new PasswordHash();
            string newPassword = phObj.Hash(uiInputLozinka.Text, phObj.GenerateSalt());

            int kontakt = int.Parse(uiInputKontaktBroj.Text); // TODO popravit
            int ulogaID = int.Parse(uiInputOdabirUloga.SelectedValue.ToString());

            try {
                // Ako se radi o izmjeni korisnika
                if (korisnikID >= 0) {
                    int id = int.Parse(uiInputID.Text);
                    // Izmijeni podatke označenog korisnika u bazi novim podacima
                    korisnikTableAdapter.UpdateRow(uiInputIme.Text, uiInputPrezime.Text, uiInputEmail.Text,
                        uiInputAdresa.Text, uiInputKorisničkoIme.Text, newPassword,
                        uiInputKontaktBroj.Text, ulogaID, id);
                // Ako se radi o unosu korisnika
                } else {
                    // Unesi novog korisnika u bazu
                    korisnikTableAdapter.InsertRow(uiInputIme.Text, uiInputPrezime.Text, uiInputEmail.Text,
                        uiInputAdresa.Text, uiInputKorisničkoIme.Text, newPassword,
                        uiInputKontaktBroj.Text, ulogaID);
                }
                Close();
            } catch (Exception) {
                uiOznakaGreška.Text = "Promjene nisu spremljene.";
            }
        }

        private bool IsInputValid() {

            // Jesu li popunita obvezna polja
            if (uiInputIme.Text.Length < 1 
                || uiInputPrezime.Text.Length < 1 
                || uiInputAdresa.Text.Length < 1
                || uiInputKorisničkoIme.Text.Length < 1 
                || uiInputLozinka.Text.Length < 1) {

                uiOznakaGreška.Text = "Nisu popunita obvezna polja.";
                return false;
            }

            // TODO Jesu li polja popunita valjanim podacima


            return true;
        }

        private void uiActionPoništi_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
