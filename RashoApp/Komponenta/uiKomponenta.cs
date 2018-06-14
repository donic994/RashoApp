using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RashoApp.Komponenta
{
    public partial class uiKomponenta : Form
    {
        public uiKomponenta()
        {
            InitializeComponent();
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.komponentaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiKomponenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Proizvod' table. You can move, or remove it, as needed.
            this.proizvodTableAdapter.Fill(this.baza18043_DBDataSet.Proizvod);
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Dio' table. You can move, or remove it, as needed.
            this.dioTableAdapter.Fill(this.baza18043_DBDataSet.Dio);
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.UlogaDijela' table. You can move, or remove it, as needed.
            this.ulogaDijelaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaDijela);
            PopuniPodacimaKomponenta();
        }

        public void PopuniPodacimaKomponenta()
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Komponenta' table. You can move, or remove it, as needed.
            this.komponentaTableAdapter.Fill(this.baza18043_DBDataSet.Komponenta);
        }

        private void uiActionDodajNoviKomponenta_Click(object sender, EventArgs e)
        {
            int dio = int.Parse(uiOutputTableDataKoponenta.SelectedCells[0].Value.ToString());
            int uloga = int.Parse(uiOutputTableDataKoponenta.SelectedCells[2].Value.ToString());
            int proizvod = int.Parse(uiOutputTableDataKoponenta.SelectedCells[5].Value.ToString());
            Komponenta.uiDodajUrediKomponenta frm = new Komponenta.uiDodajUrediKomponenta(dio, uloga, proizvod, "dodaj");
            frm.ShowDialog();
        }

        private void uiActionUrediKomponenta_Click(object sender, EventArgs e)
        {
            int dio = int.Parse(uiOutputTableDataKoponenta.SelectedCells[0].Value.ToString());
            int uloga = int.Parse(uiOutputTableDataKoponenta.SelectedCells[2].Value.ToString());
            int proizvod = int.Parse(uiOutputTableDataKoponenta.SelectedCells[5].Value.ToString());
            Komponenta.uiDodajUrediKomponenta frm = new Komponenta.uiDodajUrediKomponenta(dio, uloga, proizvod, "uredi");
            frm.ShowDialog();
        }

        private void uiActionObrišiKomponenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite obrisati ovu komponentu?", "Obrisati komponentu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                uiOutputTableDataKoponenta.Rows.RemoveAt(uiOutputTableDataKoponenta.CurrentRow.Index);
            }
            SpremiPromjene();
        }
    }
}
