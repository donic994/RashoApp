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
        private int Proizvod = 0;
        private int Element = 0;
        private string kontrola = "";

        public uiDodajUrediElement(int proizvod, int element, string Kontrola)
        {
            InitializeComponent();

            Proizvod = proizvod;
            Element = element;
            kontrola = Kontrola;

            if (kontrola == "dodaj")
            {
                uiActionSpremiElement.BackColor = Color.LimeGreen;
                this.Text = "Dodaj element";
                this.Icon = Icon.ExtractAssociatedIcon("Ikone/Dodaj.ico");
            }
            if (kontrola == "uredi")
            {
                uiActionSpremiElement.BackColor = Color.Gold;
                this.Text = "Uredi element";
                this.Icon = Icon.ExtractAssociatedIcon("Ikone/Uredi.ico");
            }
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.elementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiDodajUediElement_Load(object sender, EventArgs e)
        {
            if (kontrola == "uredi")
            {
                // TODO: This line of code loads data into the 'baza18043_DBDataSet.Element' table. You can move, or remove it, as needed.
                this.elementTableAdapter.FillByProizvodElement(this.baza18043_DBDataSet.Element, Proizvod, Element);
            }
        }

        private void uiActionOdaberiProizvod_Click(object sender, EventArgs e)
        {
            RashoApp.Proizvod.uiOdaberiProizvod frm = new RashoApp.Proizvod.uiOdaberiProizvod("proizvod");
            frm.ShowDialog();
        }

        private void uiActionOdaberiElement_Click(object sender, EventArgs e)
        {
            RashoApp.Proizvod.uiOdaberiProizvod frm = new RashoApp.Proizvod.uiOdaberiProizvod("element");
            frm.ShowDialog();
        }

        private void uiActionSpremiElement_Click(object sender, EventArgs e)
        {
            if (kontrola == "uredi")
            {
                SpremiPromjene();

                this.Close();
                Application.OpenForms.OfType<uiElement>().Single().PopuniPodacimaElement();
            }
            if (kontrola == "dodaj")
            {
                int kolicina = 1, proizvod = 0, element= 0;
                //int.TryParse(uiInputElementKolicina.Text.ToString(), out kolicina);
                //int proizvod = int.Parse(uiInputElementProizvod.Text.ToString());
                //int element = int.Parse(uiInputElementElement.Text.ToString());

                if (!int.TryParse(uiInputElementKolicina.Text, out kolicina) || uiInputElementKolicina.Text == null)
                {
                    MessageBox.Show("Unesite brojčanu vrijednost u Količina!");
                    uiInputElementKolicina.Text = "";
                    uiInputElementKolicina.Focus();
                }
                else if (!int.TryParse(uiInputElementProizvod.Text, out proizvod) || uiInputElementProizvod.Text == null)
                {
                    MessageBox.Show("Odaberite proizvod klikom na gumb +!");
                    uiInputElementProizvod.Text = "";
                    uiInputElementProizvod.Focus();
                }
                else if (!int.TryParse(uiInputElementElement.Text, out element) || uiInputElementElement.Text == null)
                {
                    MessageBox.Show("Odaberite element klikom na gumb +!");
                    uiInputElementElement.Text = "";
                    uiInputElementElement.Focus();
                }
                else
                {
                    Baza18043_DBDataSetTableAdapters.ElementTableAdapter noviElementTableAdapter = new Baza18043_DBDataSetTableAdapters.ElementTableAdapter();
                    noviElementTableAdapter.Insert(kolicina, proizvod, element);

                    SpremiPromjene();

                    this.Close();
                    Application.OpenForms.OfType<uiElement>().Single().PopuniPodacimaElement();
                }
            }
        }

        //Metode za unos vrijednosti odabranog proizvoda iz forme uiOdaberiProizvod
        public void PostaviVrijednostOdabranogProizvoda(string ID, string naziv)
        {
            uiInputElementProizvod.Text = ID;
            uiOutputNazivProizvod.Text = naziv;
        }

        public void PostaviVrijednostOdabranogElementa(string ID, string naziv)
        {
            uiInputElementElement.Text = ID;
            uiOutputNazivElement.Text = naziv;
        }
    }
}
