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
    public partial class uiDjelovi : Form
    {
        public uiDjelovi()
        {
            InitializeComponent();
        }

        private void uiDjelovi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Dio' table. You can move, or remove it, as needed.
            this.dioTableAdapter.Fill(this.baza18043_DBDataSet.Dio);
        }

        private void uiActionDodajNoviDio_Click(object sender, EventArgs e)
        {
            int id = int.Parse(uiOutputTableDataDio.SelectedCells[0].Value.ToString());
            Djelovi.uiDodajUrediDio frm = new Djelovi.uiDodajUrediDio(id, "dodaj");
            frm.ShowDialog();
        }

        private void uiActionUrediDio_Click(object sender, EventArgs e)
        {
            int id = int.Parse(uiOutputTableDataDio.SelectedCells[0].Value.ToString());
            Djelovi.uiDodajUrediDio frm = new Djelovi.uiDodajUrediDio(id, "uredi");
            frm.ShowDialog();
        }

        private void uiActionObrišiDio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite obrisati ovaj dio?", "Obrisati dio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                uiOutputTableDataDio.Rows.RemoveAt(uiOutputTableDataDio.CurrentRow.Index);
            }
        }


        private void SpremiTrenutnoStanje()
        {
            this.Validate();
            this.dioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);
        }



    }
}
