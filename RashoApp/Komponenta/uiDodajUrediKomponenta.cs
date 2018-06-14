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
            }
            if (kontrola == "dodaj")
            {
                int kolicina = 1;
                int.TryParse(uiInputKomponentaKolicina.Text.ToString(), out kolicina);
                string boja = uiInputKomponentaBoja.Text;
                string kantiranost = uiInputKomponentaKantoranost.Text;
                int uloga = int.Parse(uiInputKomponentaUloga.Text.ToString());
                int dio = int.Parse(uiInputKomponentaDio.Text.ToString());
                int proizvod = int.Parse(uiInputKomponentaProizvod.Text.ToString());

                Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter noviKomponentaTableAdapter = new Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter();
                noviKomponentaTableAdapter.Insert(kolicina, boja, kantiranost, uloga, dio, proizvod);

                SpremiPromjene();
            }

            this.Close();
            Application.OpenForms.OfType<uiKomponenta>().Single().PopuniPodacimaKomponenta();
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
