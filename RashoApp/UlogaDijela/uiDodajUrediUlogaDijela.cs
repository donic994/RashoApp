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
                this.Icon = Icon.ExtractAssociatedIcon("Ikone/Dodaj.ico");
            }
            if (kontrola == "uredi")
            {
                uiActionSpremiDio.BackColor = Color.Gold;
                this.Text = "Uredi ulogu";
                this.Icon = Icon.ExtractAssociatedIcon("Ikone/Uredi.ico");
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
                this.Close();
                Application.OpenForms.OfType<uiUlogaDijela>().Single().PopuniPodacimaUlogaDijela();
            }
            if (kontrola == "dodaj")
            {
                string naziv = "";

                if (String.IsNullOrWhiteSpace(uiInputNaziv.Text))
                {
                    MessageBox.Show("Unesite vrijednost u Naziv!");
                    uiInputNaziv.Text = "";
                    uiInputNaziv.Focus();
                }
                else
                {
                    string boja = "", debljina = "", duzina = "", kantiranost = "", materijal = "", sirina = "", prijedlogImena = "";
                    int kolicina = 0;
                     
                    naziv = uiInputNaziv.Text;
                    boja = uiInputBoja.Text;
                    debljina = uiInputDebljina.Text;
                    duzina = uiInputDuzina.Text;
                    sirina = uiInputŠirina.Text;
                    kantiranost = uiInputKantiranost.Text;
                    materijal = uiInputMaterijal.Text;
                    prijedlogImena = uiInputPrijedlogImenaDijela.Text;
                    int.TryParse(uiInputKoličina.Text, out kolicina);

                    Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter noviUlogaDijelaTableAdapter = new Baza18043_DBDataSetTableAdapters.UlogaDijelaTableAdapter();
                    noviUlogaDijelaTableAdapter.Insert(naziv, boja, debljina, duzina, kantiranost, kolicina, materijal, sirina,prijedlogImena);

                    SpremiPromjene();
                    this.Close();
                    Application.OpenForms.OfType<uiUlogaDijela>().Single().PopuniPodacimaUlogaDijela();
                }
            }
        }
    }
}