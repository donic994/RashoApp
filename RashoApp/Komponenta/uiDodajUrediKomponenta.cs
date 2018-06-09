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
    public partial class uiDodajUrediKomponenta : Form
    {
        private int id = 0;
        private string kontrola = "";

        public uiDodajUrediKomponenta(int ID, string Kontrola)
        {
            InitializeComponent();

            id = ID;
            kontrola = Kontrola;

            if (kontrola == "dodaj")
            {
                uiActionSpremiKomponenta.BackColor = Color.LimeGreen;
                this.Text = "Dodaj komponentu";
            }
            if (kontrola == "uredi")
            {
                uiActionSpremiKomponenta.BackColor = Color.Gold;
                this.Text = "Uredi komponentu";
            }
        }

        private void komponentaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.komponentaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiDodajUrediKomponenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Komponenta' table. You can move, or remove it, as needed.
            this.komponentaTableAdapter.Fill(this.baza18043_DBDataSet.Komponenta);

        }
    }
}
