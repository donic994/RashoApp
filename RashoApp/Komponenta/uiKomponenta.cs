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
    public partial class uiKomponenta : Form
    {
        public uiKomponenta()
        {
            InitializeComponent();
        }

        private void komponentaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.komponentaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiKomponenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Komponenta' table. You can move, or remove it, as needed.
            this.komponentaTableAdapter.Fill(this.baza18043_DBDataSet.Komponenta);

        }

        private void uiActionObrišiElement_Click(object sender, EventArgs e)
        {

        }

        private void uiActionUrediElement_Click(object sender, EventArgs e)
        {

        }

        private void uiActionDodajNoviElement_Click(object sender, EventArgs e)
        {

        }
    }
}
