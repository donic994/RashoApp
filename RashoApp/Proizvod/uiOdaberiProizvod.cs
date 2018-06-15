using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RashoApp.Proizvod
{
    public partial class uiOdaberiProizvod : Form
    {

        private string naredba;

        public uiOdaberiProizvod(string Naredba)
        {
            InitializeComponent();

            naredba = Naredba;
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.proizvodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiOdaberiProizvod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Proizvod' table. You can move, or remove it, as needed.
            this.proizvodTableAdapter.Fill(this.baza18043_DBDataSet.Proizvod);

        }

        private void uiActionOdaberiProizvod_Click(object sender, EventArgs e)
        {
            string id = uiOutputDataTableProizvod.SelectedCells[0].Value.ToString();
            string naziv = uiOutputDataTableProizvod.SelectedCells[1].Value.ToString();

            if (naredba == "proizvod")
            {
                Application.OpenForms.OfType<Element.uiDodajUrediElement>().Single().PostaviVrijednostOdabranogProizvoda(id, naziv);
            }
            if(naredba == "element")
            {
                Application.OpenForms.OfType<Element.uiDodajUrediElement>().Single().PostaviVrijednostOdabranogElementa(id, naziv);
            }
            if(naredba == "komponenta")
            {
                Application.OpenForms.OfType<Komponenta.uiDodajUrediKomponenta>().Single().PostaviVrijednostOdabranogProizvoda(id, naziv);
            }
            if(naredba == "proizvodElement")
            {
                Application.OpenForms.OfType<Proizvod.uiDodajElementUProizvod>().Single().PostaviVrijednostOdabranogElementa(id, naziv);
            }
            this.Close();
        }
    }
}
