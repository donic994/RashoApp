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
        public uiOdaberiProizvod()
        {
            InitializeComponent();
        }

        private void proizvodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
    }
}
