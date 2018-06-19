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
        private int Duzina;
        private int Sirina;
        private int Dubina;

        private int standardnaDebljinaDaske = 18;
        private int standardnaDebljinaPoledine = 3;
        private string prijedlogZaNazivDaska = "Daska";
        private string prijeglodZaMaterijalDaska = "Iver";

        public uiDodajDjeloveUProizvod(int proizvodID, int duzina, int sirina, int dubina)
        {
            InitializeComponent();

            ProizvodID = proizvodID;
            Duzina = duzina;
            Sirina = sirina;
            Dubina = dubina;
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.ulogaDijelaBindingSource.EndEdit();
            this.komponentaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiDodajDjeloveUProizvod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.PogledDjelovaPoProoizvodu' table. You can move, or remove it, as needed.
            this.pogledDjelovaPoProoizvoduTableAdapter.FillByProizvodID(this.baza18043_DBDataSet.PogledDjelovaPoProoizvodu, ProizvodID);
          
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Komponenta' table. You can move, or remove it, as needed.
            //this.komponentaTableAdapter.Fill(this.baza18043_DBDataSet.Komponenta);
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.Dio' table. You can move, or remove it, as needed.
            //this.dioTableAdapter.Fill(this.baza18043_DBDataSet.Dio);
            // TODO: This line of code loads data into the 'baza18043_DBDataSet.UlogaDijela' table. You can move, or remove it, as needed.
            //this.ulogaDijelaTableAdapter.Fill(this.baza18043_DBDataSet.UlogaDijela);

        }

        private void uiActionOdaberiUloga_Click(object sender, EventArgs e)
        {
            UlogaDijela.uiOdaberiUlogaDijela frm = new UlogaDijela.uiOdaberiUlogaDijela("proizvod");
            frm.ShowDialog();
            DajPrijedlogDimenzija();
            uiInputOdabirTipaUnosaDijela.Visible = true;
        }

        private void uiActionOdaberiPostojećiDio_Click(object sender, EventArgs e)
        {
            Djelovi.uiOdaberiDio frm = new Djelovi.uiOdaberiDio("proizvod");
            frm.ShowDialog();
        }

        public void PostaviVrijednostiOdabraneUlogeDijelova(string id, string naziv)
        {
            uiInputUlogaID.Text = id;
            uiOutputUlogaNaziv.Text = naziv;
        }

        public void PostaviVrijednostiOdabranogDijela(string id, string naziv)
        {
            uiInputDioID.Text = id;
            uiOutputDioNaziv.Text = naziv;
        }

        private void uiInputOdabirTipaUnosaDijela_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(uiInputOdabirTipaUnosaDijela.SelectedIndex == 0)
            {
                uiInputDioNaziv.Visible = true;
                uiInputDioDužina.Visible = true;
                uiInputDioŠirina.Visible = true;
                uiInputDioDebljina.Visible = true;
                uiInputDioMaterijal.Visible = true;

                uiLabelDioNaziv.Visible = true;
                uiLabelDioDuzina.Visible = true;
                uiLabelDioSirina.Visible = true;
                uiLabelDioDebljina.Visible = true;
                uiLabelDioMaterijal.Visible = true;

                uiInputDioID.Visible = false;
                uiOutputDioNaziv.Visible = false;
                uiActionOdaberiPostojećiDio.Visible = false;
                uiLabelOdabraniDioID.Visible = false;
                uiLabelOdabraniDioNaziv.Visible = false;          
            }

            else if (uiInputOdabirTipaUnosaDijela.SelectedIndex == 1)
            {
                uiInputDioNaziv.Visible = false;
                uiInputDioDužina.Visible = false;
                uiInputDioŠirina.Visible = false;
                uiInputDioDebljina.Visible = false;
                uiInputDioMaterijal.Visible = false;

                uiLabelDioNaziv.Visible = false;
                uiLabelDioDuzina.Visible = false;
                uiLabelDioSirina.Visible = false;
                uiLabelDioDebljina.Visible = false;
                uiLabelDioMaterijal.Visible = false;


                uiInputDioID.Visible = true;
                uiOutputDioNaziv.Visible = true;
                uiActionOdaberiPostojećiDio.Visible = true;
                uiLabelOdabraniDioID.Visible = true;
                uiLabelOdabraniDioNaziv.Visible = true;
            }
            else
            {
                uiActionDalje.Visible = false;
            }
        } 

        private void DajPrijedlogDimenzija()
        {
            switch (uiOutputUlogaNaziv.Text)
            {
                case "Vrata":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = (Duzina - 10).ToString();
                        uiInputDioŠirina.Text = (Sirina - 3).ToString();
                        uiInputDioDebljina.Text = standardnaDebljinaDaske.ToString();
                        uiInputDioMaterijal.Text = prijeglodZaMaterijalDaska;
                        uiInputKomponentaKolicina.Text = "1";
                        uiInputKomponentaBoja.Text = "Bijela";
                        uiInputKomponentaKantiranost.Text = "2D 2K";
                        break;
                    }
                case "Vrata x2":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = (Duzina - 10).ToString();
                        uiInputDioŠirina.Text = (Sirina - 6).ToString();
                        uiInputDioDebljina.Text = standardnaDebljinaDaske.ToString();
                        uiInputDioMaterijal.Text = prijeglodZaMaterijalDaska;
                        uiInputKomponentaKolicina.Text = "2";
                        uiInputKomponentaBoja.Text = "Bijela";
                        uiInputKomponentaKantiranost.Text = "2D 2K";
                        break;
                    }
                case "Bocna stranica":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = Duzina.ToString();
                        uiInputDioŠirina.Text = Dubina.ToString();
                        uiInputDioDebljina.Text = standardnaDebljinaDaske.ToString();
                        uiInputDioMaterijal.Text = prijeglodZaMaterijalDaska;
                        uiInputKomponentaKolicina.Text = "2";
                        uiInputKomponentaBoja.Text = "Bijela";
                        uiInputKomponentaKantiranost.Text = "1D 1K";
                        break;
                    }
                case "Poledina":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = Duzina.ToString();
                        uiInputDioŠirina.Text = Sirina.ToString();
                        uiInputDioDebljina.Text = standardnaDebljinaPoledine.ToString();
                        uiInputDioMaterijal.Text = prijeglodZaMaterijalDaska;
                        uiInputKomponentaKolicina.Text = "1";
                        uiInputKomponentaBoja.Text = "Bijela";
                        uiInputKomponentaKantiranost.Text = " ";
                        break;
                    }
                case "Polica":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = (Dubina - 20).ToString();
                        uiInputDioŠirina.Text = (Sirina - (standardnaDebljinaDaske * 2) - 1).ToString();
                        uiInputDioDebljina.Text = standardnaDebljinaDaske.ToString();
                        uiInputDioMaterijal.Text = prijeglodZaMaterijalDaska;
                        uiInputKomponentaKolicina.Text = "1";
                        uiInputKomponentaBoja.Text = "Bijela";
                        uiInputKomponentaKantiranost.Text = "1D";
                        break;
                    }
                case "Gornja/donja stranica":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = Dubina.ToString();
                        uiInputDioŠirina.Text = (Sirina - (standardnaDebljinaDaske * 2)).ToString();
                        uiInputDioDebljina.Text = standardnaDebljinaDaske.ToString();
                        uiInputDioMaterijal.Text = prijeglodZaMaterijalDaska;
                        uiInputKomponentaKolicina.Text = "2";
                        uiInputKomponentaBoja.Text = "Bijela";
                        uiInputKomponentaKantiranost.Text = "1D";
                        break;
                    }
                case "Prednja/zadnja stranica":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = Duzina.ToString();
                        uiInputDioŠirina.Text = Sirina.ToString();
                        uiInputDioDebljina.Text = standardnaDebljinaDaske.ToString();
                        uiInputDioMaterijal.Text = prijeglodZaMaterijalDaska;
                        uiInputKomponentaKolicina.Text = "2";
                        uiInputKomponentaBoja.Text = "Bijela";
                        uiInputKomponentaKantiranost.Text = "Po širini i dužini";
                        break;
                    }
                case "Nogice":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = "100";
                        uiInputDioŠirina.Text = "0";
                        uiInputDioDebljina.Text = "0";
                        uiInputDioMaterijal.Text = "PVC";
                        uiInputKomponentaKolicina.Text = "4";
                        uiInputKomponentaBoja.Text = "Crna";
                        uiInputKomponentaKantiranost.Text = " ";
                        break;
                    }
                case "Vijak":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = "60";
                        uiInputDioŠirina.Text = "0";
                        uiInputDioDebljina.Text = "5";
                        uiInputDioMaterijal.Text = "Metal";
                        uiInputKomponentaKolicina.Text = "16";
                        uiInputKomponentaBoja.Text = " ";
                        uiInputKomponentaKantiranost.Text = " ";
                        break;
                    }
                case "Vodilice ladica":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = "500";
                        uiInputDioŠirina.Text = "10";
                        uiInputDioDebljina.Text = "5";
                        uiInputDioMaterijal.Text = "Metal";
                        uiInputKomponentaKolicina.Text = "4";
                        uiInputKomponentaBoja.Text = " ";
                        uiInputKomponentaKantiranost.Text = " ";
                        break;
                    }
                case "Ruckica":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = "500";
                        uiInputDioŠirina.Text = "0";
                        uiInputDioDebljina.Text = " ";
                        uiInputDioMaterijal.Text = "Metal";
                        uiInputKomponentaKolicina.Text = "4";
                        uiInputKomponentaBoja.Text = " ";
                        uiInputKomponentaKantiranost.Text = " ";
                        break;
                    }
            }
        }

        private void DodajDio()
        {            
                string naziv = uiInputDioNaziv.Text;
                int duljina = int.Parse(uiInputDioDužina.Text.ToString());
                int sirina = int.Parse(uiInputDioŠirina.Text.ToString());
                int visina = int.Parse(uiInputDioDebljina.Text.ToString());
                string slika = "";
                string materijal = uiInputDioMaterijal.Text;

                Baza18043_DBDataSetTableAdapters.DioTableAdapter noviDioTableAdapter = new Baza18043_DBDataSetTableAdapters.DioTableAdapter();
                noviDioTableAdapter.Insert(naziv, duljina, sirina, visina, slika, materijal);

                SpremiPromjene();
        }

        private void DodajKomponentu(int ulogaID, int dioID, int proizvodID)
        {

            int kolicina = int.Parse(uiInputKomponentaKolicina.Text.ToString());
            string boja = uiInputKomponentaBoja.Text;
            string kantiranost = uiInputKomponentaKantiranost.Text;
            int uloga = ulogaID;
            int dio = dioID;
            int proizvod = proizvodID;

            Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter noviKomponentaTableAdapter = new Baza18043_DBDataSetTableAdapters.KomponentaTableAdapter();
            noviKomponentaTableAdapter.Insert(kolicina, boja, kantiranost, uloga, dio, proizvod);

            SpremiPromjene();
        }

        public void PopuniTablicu()
        {
            this.pogledDjelovaPoProoizvoduTableAdapter.FillByProizvodID(this.baza18043_DBDataSet.PogledDjelovaPoProoizvodu, ProizvodID);
        }

        private void uiActionDodaj_Click(object sender, EventArgs e)
        {

            if (uiInputOdabirTipaUnosaDijela.SelectedIndex == 0)
            {
                DodajDio();
                int ulogaID = int.Parse(uiInputUlogaID.Text.ToString());
                int dioID = int.Parse(this.dioTableAdapter.VratiZadnjiIDDio().ToString());
                DodajKomponentu(ulogaID, dioID, ProizvodID);
            }

            if (uiInputOdabirTipaUnosaDijela.SelectedIndex == 1)
            {
                int dioID = int.Parse(uiInputDioID.Text.ToString());
                int ulogaID = int.Parse(uiInputUlogaID.Text.ToString());
                DodajKomponentu(ulogaID, dioID, ProizvodID);
            }
            PopuniTablicu();
        }

        private void uiActionDalje_Click(object sender, EventArgs e)
        {
            Proizvod.uiDodajElementUProizvod frm = new Proizvod.uiDodajElementUProizvod(ProizvodID);
            frm.ShowDialog();
            this.Close();
        }

        private void uiActionObrišiDio_Click(object sender, EventArgs e)
        {
            if(uiOutputDataTableDioUProizvodu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite dio koji želite izbrisati iz prizvoda!");
            }
            else if (MessageBox.Show("Jeste li sigurni da želite obrisati ovaj dio iz proizvoda?", "Obrisati dio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int dioID = int.Parse(uiOutputDataTableDioUProizvodu.SelectedCells[0].Value.ToString());
                int ulogaID = int.Parse(uiOutputDataTableDioUProizvodu.SelectedCells[1].Value.ToString());
                this.komponentaTableAdapter.DeleteByUlogaDioProizvod(ulogaID, dioID, ProizvodID);

                uiOutputDataTableDioUProizvodu.Rows.RemoveAt(uiOutputDataTableDioUProizvodu.CurrentRow.Index);
            }
            SpremiPromjene();
            PopuniTablicu();
        }
    }
}
