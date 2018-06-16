using RashoApp.Properties;
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
                this.Icon = Icon.ExtractAssociatedIcon("Ikone/Dodaj.ico");
            }

            if (kontrola == "uredi")
            {
                uiActionSpremiDio.BackColor = Color.Gold;
                this.Text = "Uredi dio";
                this.Icon = Icon.ExtractAssociatedIcon("Ikone/Uredi.ico");
            }

        }

        private void uiDodajDio_Load(object sender, EventArgs e)
        {
            if (kontrola == "uredi")
            {
                // TODO: This line of code loads data into the 'baza18043_DBDataSet.Dio' table. You can move, or remove it, as needed.
                this.dioTableAdapter.FillByID(this.baza18043_DBDataSet.Dio, id);
            }
        }

        private void uiActionSpremiDio_Click(object sender, EventArgs e)
        {
            if(kontrola == "uredi")
            {
                SpremiPromjene();
            }
            if(kontrola == "dodaj")
            {
                int duljina=0, sirina=0, visina=0;

                string naziv = uiInputDioNaziv.Text;
                int.TryParse(uiInputDioDuljina.Text.ToString(), out duljina);
                int.TryParse(uiInputDioŠirina.Text.ToString(), out sirina);
                int.TryParse(uiInputDioVisina.Text.ToString(), out visina);
                string slika = uiInputDioSlika.Text;
                string materijal = uiInputDioMaterijal.Text;

                Baza18043_DBDataSetTableAdapters.DioTableAdapter noviDioTableAdapter = new Baza18043_DBDataSetTableAdapters.DioTableAdapter();
                noviDioTableAdapter.Insert(naziv, duljina, sirina, visina, slika, materijal);

                SpremiPromjene();
            }     
                        
            this.Close();
            Application.OpenForms.OfType<uiDjelovi>().Single().PopuniPodacimaDio();
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.dioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);
        }
    }
}
