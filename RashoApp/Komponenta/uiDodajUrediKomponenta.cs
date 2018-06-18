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
    public partial class uiDodajUrediKomponenta : Form
    {
        private int dio = 0;
        private int uloga = 0;
        private int proizvod = 0;
        private string kontrola = "";

        public uiDodajUrediKomponenta(int Dio, int Uloga , int Proizvod, string Kontrola)
        {
            InitializeComponent();

            dio = Dio;
            uloga = Uloga;
            proizvod = Proizvod;
            kontrola = Kontrola;

            if (kontrola == "dodaj")
            {
                uiActionSpremiKomponenta.BackColor = Color.LimeGreen;
                this.Text = "Dodaj komponentu";
                this.Icon = Icon.ExtractAssociatedIcon("Ikone/Dodaj.ico");
            }
            if (kontrola == "uredi")
            {
                uiActionSpremiKomponenta.BackColor = Color.Gold;
                this.Text = "Uredi komponentu";
                this.Icon = Icon.ExtractAssociatedIcon("Ikone/Uredi.ico");
            }
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.komponentaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiDodajUrediKomponenta_Load(object sender, EventArgs e)
        {
            if (kontrola == "uredi")
            {
                // TODO: This line of code loads data into the 'baza18043_DBDataSet.Komponenta' table. You can move, or remove it, as needed.
                this.komponentaTableAdapter.FillByDioUlogaProizvod(this.baza18043_DBDataSet.Komponenta, uloga, dio,proizvod);
            }

        }

        private void uiActionSpremiKomponenta_Click(object sender, EventArgs e)
        {
            if (kontrola == "uredi")
            {
                SpremiPromjene();
                this.Close();
                Application.OpenForms.OfType<uiKomponenta>().Single().PopuniPodacimaKomponenta();
            }
            if (kontrola == "dodaj")
            {
                int kolicina = 1, uloga = 0, dio = 0, proizvod = 0;
                string boja = "", kantiranost = "";
                //int.TryParse(uiInputKomponentaKolicina.Text.ToString(), out kolicina);
                //int uloga = int.Parse(uiInputKomponentaUloga.Text.ToString());
                //int dio = int.Parse(uiInputKomponentaDio.Text.ToString());
                //int proizvod = int.Parse(uiInputKomponentaProizvod.Text.ToString());


                if (String.IsNullOrWhiteSpace(uiInputKomponentaBoja.Text))
                {
                    MessageBox.Show("Unesite vrijednost u Boja!");
                    uiInputKomponentaBoja.Text = "";
                    uiInputKomponentaBoja.Focus();
                }
                else if (!int.TryParse(uiInputKomponentaKolicina.Text, out kolicina) || uiInputKomponentaKolicina.Text == null)
                {
                    MessageBox.Show("Unesite brojčanu vrijednost u Količina!");
                    uiInputKomponentaKolicina.Text = "";
                    uiInputKomponentaKolicina.Focus();
                }
                else if (!int.TryParse(uiInputKomponentaDio.Text, out dio) || uiInputKomponentaDio.Text == null)
                {
                    MessageBox.Show("Odaberite dio klikom na +!");
                    uiInputKomponentaDio.Text = "";
                    uiInputKomponentaDio.Focus();
                }
                else if (!int.TryParse(uiInputKomponentaUloga.Text, out uloga) || uiInputKomponentaUloga.Text == null)
                {
                    MessageBox.Show("Odaberite ulogu dijela klikom na +!");
                    uiInputKomponentaUloga.Text = "";
                    uiInputKomponentaUloga.Focus();
                }
                else if (!int.TryParse(uiInputKomponentaProizvod.Text, out proizvod) || uiInputKomponentaProizvod.Text == null)
                {
                    MessageBox.Show("Odaberite proizvod klikom na +!");
                    uiInputKomponentaProizvod.Text = "";
                    uiInputKomponentaProizvod.Focus();
                }
                else if (String.IsNullOrWhiteSpace(uiInputKomponentaKantoranost.Text))
                {
                    MessageBox.Show("Unesite vrijednost u Kantiranost!");
                    uiInputKomponentaKantoranost.Text = "";
                    uiInputKomponentaKantoranost.Focus();
                }
                else
                {
                    kantiranost = uiInputKomponentaKantoranost.Text;
                    boja = uiInputKomponentaBoja.Text;
                    Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter noviKomponentaTableAdapter = new Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter();
                    noviKomponentaTableAdapter.Insert(kolicina, boja, kantiranost, uloga, dio, proizvod);

                    SpremiPromjene();
                    this.Close();
                    Application.OpenForms.OfType<uiKomponenta>().Single().PopuniPodacimaKomponenta();
                }
            }


        }

        private void uiActionOdaberiUloga_Click(object sender, EventArgs e)
        {
            UlogaDijela.uiOdaberiUlogaDijela frm = new UlogaDijela.uiOdaberiUlogaDijela("komponenta");
            frm.ShowDialog();
        }

        private void uiActionOdaberiDio_Click(object sender, EventArgs e)
        {
            Djelovi.uiOdaberiDio frm = new Djelovi.uiOdaberiDio("komponenta");
            frm.ShowDialog();
        }

        private void uiActionOdaberiProizvod_Click(object sender, EventArgs e)
        {
            Proizvod.uiOdaberiProizvod frm = new Proizvod.uiOdaberiProizvod("komponenta");
            frm.ShowDialog();
        }

        //Metoda za upis vrijednosti u uiInput i uiOutput iz forme uiOdaberiProizvod
        public void PostaviVrijednostOdabranogProizvoda(string ID, string naziv)
        {
            uiInputKomponentaProizvod.Text = ID;
            uiOutputProizvod.Text = naziv;
        }

        //Metoda za upis vrijednosti u uiInput i uiOutput iz forme uiOdaberiUlogaDijela
        public void PostaviVrijednostOdabranogUlogaDijela(string ID, string naziv)
        {
            uiInputKomponentaUloga.Text = ID;
            uiOutputUloga.Text = naziv;
        }

        //Metoda za upis vrijednosti u uiInput i uiOutput iz forme uiOdaberiDio
        public void PostaviVrijednostOdabranogDjela(string ID, string naziv)
        {
            uiInputKomponentaDio.Text = ID;
            uiOutputDio.Text = naziv;
        }
    }
}
