using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RashoApp.Djelovi
{
    public partial class uiOdaberiDio : Form
    {
        public uiOdaberiDio()
        {
            InitializeComponent();
        }

        private void dioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiOdaberiDio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Dio' table. You can move, or remove it, as needed.
            this.dioTableAdapter.Fill(this.baza18043_DBDataSet.Dio);

        }

        private void uiActionOdaberiDio_Click(object sender, EventArgs e)
        {
            string id = uiOutputDataTableDio.SelectedCells[0].Value.ToString();
            string naziv = uiOutputDataTableDio.SelectedCells[1].Value.ToString();

            Application.OpenForms.OfType<Komponenta.uiDodajUrediKomponenta>().Single().PostaviVrijednostOdabranogDjela(id, naziv);
            this.Close();
        }
    }
}
