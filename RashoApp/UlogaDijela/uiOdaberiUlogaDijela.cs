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
    public partial class uiOdaberiUlogaDijela : Form
    {
        string Kontrola;
        public uiOdaberiUlogaDijela(string kontrola)
        {
            InitializeComponent();
            Kontrola = kontrola;
        }

        private void ulogaDijelaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ulogaDijelaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiOdaberiUlogaDijela_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.UlogaDijela' table. You can move, or remove it, as needed.
            this.ulogaDijelaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaDijela);

        }

        private void uiActionOdaberiUlogaDijela_Click(object sender, EventArgs e)
        {
            string id = uiOutputDataTableUlogaDijela.SelectedCells[0].Value.ToString();
            string naziv = uiOutputDataTableUlogaDijela.SelectedCells[1].Value.ToString();

            if (Kontrola == "komponenta")
            {
                Application.OpenForms.OfType<Komponenta.uiDodajUrediKomponenta>().Single().PostaviVrijednostOdabranogUlogaDijela(id, naziv);
            }
            if(Kontrola == "proizvod")
            {

                Application.OpenForms.OfType<Proizvod.uiDodajDjeloveUProizvod>().Single().PostaviVrijednostiOdabraneUlogeDijelova(id, naziv);

            }
            this.Close();
        }
    }
}
