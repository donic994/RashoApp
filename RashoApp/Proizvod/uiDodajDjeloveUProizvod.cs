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
    public partial class uiDodajDjeloveUProizvod : Form
    {
        private int ProizvodID;

        public uiDodajDjeloveUProizvod(int proizvodID)
        {
            InitializeComponent();

            ProizvodID = proizvodID;

            uiOutputUlogaNaziv.Text = ProizvodID.ToString();
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.ulogaDijelaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiDodajDjeloveUProizvod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Dio' table. You can move, or remove it, as needed.
            //this.dioTableAdapter.Fill(this.baza18043_DBDataSet.Dio);
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.UlogaDijela' table. You can move, or remove it, as needed.
            //this.ulogaDijelaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaDijela);

        }

        private void uiActionOdaberiUloga_Click(object sender, EventArgs e)
        {
            UlogaDijela.uiOdaberiUlogaDijela frm = new UlogaDijela.uiOdaberiUlogaDijela("proizvod");
            frm.ShowDialog();
        }

        public void PostaviVrijednostiOdabraneUlogeDijelova(string id, string naziv)
        {
            uiInputUlogaID.Text = id;
            uiOutputUlogaNaziv.Text = naziv;
        }
    }
}
