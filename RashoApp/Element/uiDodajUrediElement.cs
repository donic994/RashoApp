using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RashoApp.Element
{
    public partial class uiDodajUrediElement : Form
    {
        private int id = 0;
        private string kontrola = "";

        public uiDodajUrediElement(int ID, string Kontrola)
        {
            InitializeComponent();

            id = ID;
            kontrola = Kontrola;

            if (kontrola == "dodaj")
            {
                uiActionSpremiElement.BackColor = Color.LimeGreen;
                this.Text = "Dodaj element";
            }
            if (kontrola == "uredi")
            {
                uiActionSpremiElement.BackColor = Color.Gold;
                this.Text = "Uredi element";
            }
        }

        private void elementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.elementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiDodajUediElement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Element' table. You can move, or remove it, as needed.
            this.elementTableAdapter.Fill(this.baza18043_DBDataSet.Element);

        }


    }
}
