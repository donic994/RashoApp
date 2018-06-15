using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RashoApp.UlogaDijela
{
    public partial class uiUlogaDijela : Form
    {
        public uiUlogaDijela()
        {
            InitializeComponent();
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.ulogaDijelaBindingSource.EndEdit();
            this.komponentaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiUlogaDijela_Load(object sender, EventArgs e)
        {
            PopuniPodacimaUlogaDijela();
        }

        private void uiActionDodajNoviUlogaDijela_Click(object sender, EventArgs e)
        {
            int id = int.Parse(uiOutputTableDataUlogaDijela.SelectedCells[0].Value.ToString());
            UlogaDijela.uiDodajUrediUlogaDijela frm = new UlogaDijela.uiDodajUrediUlogaDijela(id, "dodaj");
            frm.ShowDialog();
        }

        private void uiActionUrediUlogaDijela_Click(object sender, EventArgs e)
        {
            int id = int.Parse(uiOutputTableDataUlogaDijela.SelectedCells[0].Value.ToString());
            UlogaDijela.uiDodajUrediUlogaDijela frm = new UlogaDijela.uiDodajUrediUlogaDijela(id, "uredi");
            frm.ShowDialog();
        }

        private void uiActionObrišiUlogaDijela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite obrisati ovu ulogu?", "Obrisati ulogu dijela", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = int.Parse(uiOutputTableDataUlogaDijela.SelectedCells[0].Value.ToString());

                uiOutputTableDataUlogaDijela.Rows.RemoveAt(uiOutputTableDataUlogaDijela.CurrentRow.Index);

                this.ulogaDijelaTableAdapter.DeleteUlogaByID(id);
                this.komponentaTableAdapter.DeleteByUlogaDijela(id);

                SpremiPromjene();
            }
        }

        public void PopuniPodacimaUlogaDijela()
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.UlogaDijela' table. You can move, or remove it, as needed.
            this.ulogaDijelaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaDijela);
        }
    }
}
