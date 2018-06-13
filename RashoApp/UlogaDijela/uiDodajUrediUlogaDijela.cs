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
    public partial class uiDodajUrediUlogaDijela : Form
    {

        private int id = 0;
        private string kontrola = "";

        public uiDodajUrediUlogaDijela(int ID, string Kontrola)
        {
            InitializeComponent();

            id = ID;
            kontrola = Kontrola;

            if (kontrola == "dodaj")
            {
                uiActionSpremiDio.BackColor = Color.LimeGreen;
                this.Text = "Dodaj ulogu";
            }
            if (kontrola == "uredi")
            {
                uiActionSpremiDio.BackColor = Color.Gold;
                this.Text = "Uredi ulogu";
            }
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.ulogaDijelaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiDodajUrediUlogaDijela_Load(object sender, EventArgs e)
        {
            if (kontrola == "uredi")
            {
                // TODO: This line of code loads data into the 'baza18043_DBDataSet.UlogaDijela' table. You can move, or remove it, as needed.
                this.ulogaDijelaTableAdapter.FillByUlogaID(baza18043_DBDataSet.UlogaDijela, id);
            }
        }

        private void uiActionSpremiDio_Click(object sender, EventArgs e)
        {
            if (kontrola == "uredi")
            {
                SpremiPromjene();
            }
            if (kontrola == "dodaj")
            {
                string naziv = nazivTextBox.Text;


                Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter noviUlogaDijelaTableAdapter = new Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter();
                noviUlogaDijelaTableAdapter.Insert(naziv);

                SpremiPromjene();
            }

            this.Close();
        }
    }
}
