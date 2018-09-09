using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
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

        }

        // Ispunjava formu podacima iz baze radi lakše izmjene podataka o korisniku
        private void IspuniPodatkeOKorisniku() {
            uiInputID.Text = korisnikID.ToString();
            var korisnik = korisnikTableAdapter.GetDataByID(korisnikID)[0];
            uiInputIme.Text = korisnik.ime;
            uiInputPrezime.Text = korisnik.prezime;
            uiInputEmail.Text = korisnik.email;
            uiInputAdresa.Text = korisnik.adresa;
            uiInputKorisničkoIme.Text = korisnik.korisnickoIme;
            uiInputKontaktBroj.Text = korisnik.kontaktBroj;
            uiInputOdabirUloga.SelectedValue = korisnik.id_uloga;
        }

        // Popunjava combobox podacima pri učitavanju forme
        private void uiKorisnik_Load(object sender, EventArgs e) {
            this.ulogaKorisnikaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaKorisnika);

            // Ako je ID korisnika prenesen ovoj formi (ako se radi o izmjeni korisnika)
            if (korisnikID >= 0) {
                IspuniPodatkeOKorisniku();
            }
        }

        // Sprema promjene pri kliku na gumb
        private void uiActionPrihvati_Click(object sender, EventArgs e) {
            uiOznakaGreška.Text = "";
            if (!JeUnosValjan()) {
                return;
            }

            PasswordHash phObj = new PasswordHash();
            string newPassword = phObj.Hash(uiInputLozinka.Text, phObj.GenerateSalt());

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

        // Provjerava valjanost unesenih podataka
        private bool JeUnosValjan() {

            bool isValid = true;
            
            // Jesu li polja popunita valjanim podacima
            Regex imePattern = new Regex(@"^([A-ZŠĐŽĆČ][a-zšđžćč]+)(-[A-ZŠĐŽĆČ])?[a-zšđžćč]+$");
            Regex prezimePattern = new Regex(@"^([A-ZŠĐŽĆČ][a-zšđžćč]+)(-[A-ZŠĐŽĆČ])?[a-zšđžćč]+$");
            Regex adresaPattern = new Regex(@"^([A-ZŠĐŽĆČ\.][a-zšđžćč\.]+)([\ \-]([A-ZŠĐŽĆČ\.]?[a-zšđžćč\.]+)?(\d+[A-Za-z]{0,2})?)*$");
            Regex emailPattern = new Regex(@"\A([a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)?\z");
            Regex korisnickoImePattern = new Regex(@"^[a-z][a-z0-9]{3,}$");
            Regex lozinkaPattern = new Regex(@"^([a-zA-Z0-9@*#šđžćčŠĐŽĆČ ]{4,20})$");
            Regex kontaktPattern = new Regex(@"^((\d+)([\ \-\\\/]\d+)*)?$");

            
            if (!imePattern.IsMatch(uiInputIme.Text)) {
                uiInputIme.BackColor = Color.Red;
                isValid = false;
            } else { uiInputIme.BackColor = Color.White; }

            if (!prezimePattern.IsMatch(uiInputPrezime.Text)) {
                uiInputPrezime.BackColor = Color.Red;
                isValid = false;
            } else { uiInputPrezime.BackColor = Color.White; }

            if (!adresaPattern.IsMatch(uiInputAdresa.Text)) {
                uiInputAdresa.BackColor = Color.Red;
                isValid = false;
            } else { uiInputAdresa.BackColor = Color.White; }

            if (!emailPattern.IsMatch(uiInputEmail.Text)) {
                uiInputEmail.BackColor = Color.Red;
                isValid = false;
            } else { uiInputEmail.BackColor = Color.White; }

            if (!korisnickoImePattern.IsMatch(uiInputKorisničkoIme.Text)) {
                uiInputKorisničkoIme.BackColor = Color.Red;
                isValid = false;
            } else { uiInputKorisničkoIme.BackColor = Color.White; }

            if (!lozinkaPattern.IsMatch(uiInputLozinka.Text)) {
                uiInputLozinka.BackColor = Color.Red;
                isValid = false;
            } else { uiInputLozinka.BackColor = Color.White; }

            if (!kontaktPattern.IsMatch(uiInputKontaktBroj.Text)) {
                uiInputKontaktBroj.BackColor = Color.Red;
                isValid = false;
            } else { uiInputKontaktBroj.BackColor = Color.White; }

            return isValid;
        }
        
        // Zatvara formu ne spremajući promjene
        private void uiActionPoništi_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
