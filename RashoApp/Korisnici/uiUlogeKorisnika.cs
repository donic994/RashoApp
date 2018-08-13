using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

/// <summary>
/// U formi UIUlogeKorisnika korisnik ima pregled svih korisnika u bazi te mogućnost dodavanja, brisanja i ažuriranja istih.
/// Prilikom klika na gumb uiActionDodaj ili uiActionUredi, otvara se forma UIUlogaKorisnika gdje korisnik napravi promjene.
/// Klikom na gumb uiActionObriši, korisnik se briše iz baze.
/// Pregled korisnika se ažurira nakon bilo koje promjene.
/// </summary>

namespace RashoApp.Korisnici {
    public partial class UIUlogeKorisnika : Form {

        private Baza18043_DBDataSetTableAdapters.VidiElementTableAdapter vidiElementTableAdapter;

        public UIUlogeKorisnika() {
            InitializeComponent();
            vidiElementTableAdapter = new Baza18043_DBDataSetTableAdapters.VidiElementTableAdapter();
        }

        private void ulogaKorisnikaBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.ulogaKorisnikaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);
        }

        // Učitava podatke iz baze u tablicu pri pokretanju
        private void uiUlogeKorisnika_Load(object sender, EventArgs e) {
            this.ulogaKorisnikaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaKorisnika);
        }

        // Otvori formu za dodavanje/izmjenu uloge
        private void uiActionDodaj_Click(object sender, EventArgs e) {
            uiOznakaGreška.Text = "";

            UIUlogaKorisnika frm = new UIUlogaKorisnika();
            frm.ShowDialog();
            this.ulogaKorisnikaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaKorisnika);
        }

        // Otvori formu za dodavanje/izmjenu uloge
        private void uiActionUredi_Click(object sender, EventArgs e) {
            uiOznakaGreška.Text = "";

            if (uiOutputTableDataUlogaKorisnika.SelectedCells[0].Value.ToString() == LoginInfo.Role.ToString()) {
                uiOznakaGreška.Text = "Nije moguće izmijeniti ulogu prijavljenog korisnika.";
                return;
            }

            int id = int.Parse(uiOutputTableDataUlogaKorisnika.CurrentRow.Cells[0].Value.ToString());
            UIUlogaKorisnika frm = new UIUlogaKorisnika(id);
            frm.ShowDialog();
            this.ulogaKorisnikaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaKorisnika);
        }
        
        // Briše ulogu iz baze
        private void uiActionObriši_Click(object sender, EventArgs e) {
            uiOznakaGreška.Text = "";

            int id = int.Parse(uiOutputTableDataUlogaKorisnika.CurrentRow.Cells[0].Value.ToString());
            try {
                // Obriši ulogu
                ulogaKorisnikaTableAdapter.DeleteRowByID(id);
                this.ulogaKorisnikaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaKorisnika);
            // Zbog ograničenja vanjskog ključa
            } catch (Exception) {
                uiOznakaGreška.Text = "Uloga ne može biti obrisana.";
            }

        }
    }
}
