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
    public partial class uiElement : Form
    {
        public uiElement()
        {
            InitializeComponent();
        }

        private void elementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.elementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiElement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Element' table. You can move, or remove it, as needed.
            this.elementTableAdapter.Fill(this.baza18043_DBDataSet.Element);

        }

        private void uiActionUrediDio_Click(object sender, EventArgs e)
        {

        }

        private void uiActionObrišiDio_Click(object sender, EventArgs e)
        {

        }

        private void uiActionDodajNoviDio_Click(object sender, EventArgs e)
        {

        }
    }
}
