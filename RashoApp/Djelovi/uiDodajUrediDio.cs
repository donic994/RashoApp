using System;
using System.Drawing;
using System.Linq;
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

                this.Close();
                Application.OpenForms.OfType<uiDjelovi>().Single().PopuniPodacimaDio();
            }
            if (kontrola == "dodaj")
            {
                int duljina = 0, sirina = 0, visina = 0;
                string naziv = null, slika = null, materijal = null;

                if (uiInputDioNaziv.Text == null)
                {
                    MessageBox.Show("Unesite vrijednost u Naziv!");
                    uiInputDioNaziv.Text = "";
                    uiInputDioNaziv.Focus();
                }
                else if (!int.TryParse(uiInputDioDuljina.Text, out duljina) || uiInputDioDuljina.Text == null)
                {
                    MessageBox.Show("Unesite brojčanu vrijednost u Dužina!");
                    uiInputDioDuljina.Text = "";
                    uiInputDioDuljina.Focus();
                }
                else if (!int.TryParse(uiInputDioŠirina.Text, out sirina) || uiInputDioŠirina.Text == null)
                {
                    MessageBox.Show("Unesite brojčanu vrijednost u Širina!");
                    uiInputDioŠirina.Text = "";
                    uiInputDioŠirina.Focus();
                }
                else if (!int.TryParse(uiInputDioVisina.Text, out visina) || uiInputDioVisina.Text == null)
                {
                    MessageBox.Show("Unesite brojčanu vrijednost u Dubina!");
                    uiInputDioVisina.Text = "";
                    uiInputDioVisina.Focus();
                }
                else if (uiInputDioMaterijal.Text == null)
                {
                    MessageBox.Show("Unesite vrijednost u Materijal!");
                    uiInputDioMaterijal.Text = "";
                    uiInputDioMaterijal.Focus();
                }
                else
                { 

                    Baza18043_DBDataSetTableAdapters.DioTableAdapter noviDioTableAdapter = new Baza18043_DBDataSetTableAdapters.DioTableAdapter();
                    noviDioTableAdapter.Insert(naziv, duljina, sirina, visina, slika, materijal);

                    SpremiPromjene();

                    this.Close();
                    Application.OpenForms.OfType<uiDjelovi>().Single().PopuniPodacimaDio();
                }
            }     
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.dioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);
        }
    }
}
