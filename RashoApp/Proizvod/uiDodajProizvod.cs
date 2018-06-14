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
    public partial class uiDodajProizvod : Form
    {
        public uiDodajProizvod()
        {
            InitializeComponent();
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.proizvodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiDodajProizvod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Proizvod' table. You can move, or remove it, as needed.
            //this.proizvodTableAdapter.Fill(this.baza18043_DBDataSet.Proizvod);

        }

        private void uiActionDalje_Click(object sender, EventArgs e)
        {
            string naziv = uiInputNaziv.Text;
            int duzina = int.Parse(uiInputDužina.Text.ToString());
            int sirina = int.Parse(uiInputŠirina.Text.ToString());
            int dubina = int.Parse(uiInputDubina.Text.ToString());
            string slika = uiInputSlika.Text;

            Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter noviDioTableAdapter = new Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter();
            noviDioTableAdapter.Insert(duzina, sirina, dubina, slika, naziv);

            SpremiPromjene();

            int proizvodID = 1;

            this.Close();
            Proizvod.uiDodajDjeloveUProizvod frm = new uiDodajDjeloveUProizvod(proizvodID);
            frm.ShowDialog();
        }
    }
}
