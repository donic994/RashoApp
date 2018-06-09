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
    public partial class uiDodajUrediDio : Form
    {
        private int id = 0;
        private string kontrola = "";

        public uiDodajUrediDio(int ID, string Kontrola)
        {
            InitializeComponent();
            id = ID;
            kontrola = Kontrola;

            if(kontrola == "dodaj")
            {
                uiActionSpremiDio.BackColor = Color.LimeGreen;
                this.Text = "Dodaj dio";
            }
            if(kontrola == "uredi")
            {
                uiActionSpremiDio.BackColor = Color.Gold;
                this.Text = "Uredi dio";
            }

        }

        private void dioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiDodajDio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Dio' table. You can move, or remove it, as needed.
            this.dioTableAdapter.FillByID(this.baza18043_DBDataSet.Dio, id);

        }

    }
}
