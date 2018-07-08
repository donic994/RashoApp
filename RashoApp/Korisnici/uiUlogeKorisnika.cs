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
/// U formi uiUlogeKorisnika korisnik ima pregled svih korisnika u bazi te mogućnost dodavanja, brisanja i ažuriranja istih.
/// Prilikom klika na gumb uiActionDodaj ili uiActionUredi, otvara se forma UIUlogaKorisnika gdje korisnik napravi promjene.
/// Klikom na gumb uiActionObriši, korisnik se briše iz baze.
/// Pregled korisnika se ažurira nakon bilo koje promjene.
/// </summary>

namespace RashoApp.Korisnici {
    public partial class uiUlogeKorisnika : Form {

        public uiUlogeKorisnika() {
            InitializeComponent();
        }

        private void ulogaKorisnikaBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.ulogaKorisnikaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiUlogeKorisnika_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.UlogaKorisnika' table. You can move, or remove it, as needed.
            this.ulogaKorisnikaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaKorisnika);

        }

        private void uiActionDodaj_Click(object sender, EventArgs e) {
            UIUlogaKorisnika frm = new UIUlogaKorisnika();
            frm.ShowDialog();
            this.ulogaKorisnikaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaKorisnika);
        }

        private void uiActionUredi_Click(object sender, EventArgs e) {
            int id = int.Parse(uiOutputTableDataUlogaKorisnika.CurrentRow.Cells[0].Value.ToString());
            UIUlogaKorisnika frm = new UIUlogaKorisnika(id);
            frm.ShowDialog();
            this.ulogaKorisnikaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaKorisnika);
        }

        private void uiActionObriši_Click(object sender, EventArgs e) {
            int id = int.Parse(uiOutputTableDataUlogaKorisnika.CurrentRow.Cells[0].Value.ToString());
            ulogaKorisnikaTableAdapter.DeleteRowByID(id);
            this.ulogaKorisnikaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaKorisnika);
        }
    }
}
