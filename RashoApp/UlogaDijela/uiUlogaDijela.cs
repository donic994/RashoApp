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

        private void ulogaDijelaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ulogaDijelaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiUlogaDijela_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.UlogaDijela' table. You can move, or remove it, as needed.
            this.ulogaDijelaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaDijela);

        }

        private void uiActionDodajNoviUlogaDijela_Click(object sender, EventArgs e)
        {

        }

        private void uiActionUrediUlogaDijela_Click(object sender, EventArgs e)
        {

        }

        private void uiActionObrišiUlogaDijela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite obrisati ovu ulogu?", "Obrisati ulogu dijela", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                uiOutputDataUlogaDijela.Rows.RemoveAt(uiOutputDataUlogaDijela.CurrentRow.Index);
            }
        }
    }
}
