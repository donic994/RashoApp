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

        private int standardnaDebljinaDaske = 15;
        private int standardnaDebljinaPoledine = 6;
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
            this.tableAdapterManager.UpdateAll(this.baza18043_DBDataSet);

        }

        private void uiDodajDjeloveUProizvod_Load(object sender, EventArgs e)
        {
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
        }

        public void PostaviVrijednostiOdabraneUlogeDijelova(string id, string naziv)
        {
            uiInputUlogaID.Text = id;
            uiOutputUlogaNaziv.Text = naziv;
        }

        private void uiInputOdabirTipaUnosaDijela_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(uiInputOdabirTipaUnosaDijela.SelectedIndex == 0)
            {
                uiInputDioNaziv.Visible = true;
                uiInputDioDužina.Visible = true;
                uiInputDioŠirina.Visible = true;
                uiInputDioDebljina.Visible = true;
                uiInputDioSlika.Visible = true;
                uiInputDioMaterijal.Visible = true;

                uiInputDioID.Visible = false;
                uiOutputDioNaziv.Visible = false;                
            }

            else if (uiInputOdabirTipaUnosaDijela.SelectedIndex == 1)
            {
                uiInputDioNaziv.Visible = false;
                uiInputDioDužina.Visible = false;
                uiInputDioŠirina.Visible = false;
                uiInputDioDebljina.Visible = false;
                uiInputDioSlika.Visible = false;
                uiInputDioMaterijal.Visible = false;


                uiInputDioID.Visible = true;
                uiOutputDioNaziv.Visible = true;
            }
            else
            {
                uiActionDalje.Visible = false;
            }
        }

        private void uiActionDodaj_Click(object sender, EventArgs e)
        {

        }

        private void DajPrijedlogDimenzija()
        {
            switch (uiOutputUlogaNaziv.Text)
            {
                case "Vrata":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = Duzina.ToString();
                        uiInputDioŠirina.Text = Sirina.ToString();
                        uiInputDioDebljina.Text = standardnaDebljinaDaske.ToString();
                        uiInputDioMaterijal.Text = prijeglodZaMaterijalDaska;
                        break;
                    }
                case "Bocna stranica":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = Duzina.ToString();
                        uiInputDioŠirina.Text = Dubina.ToString();
                        uiInputDioDebljina.Text = standardnaDebljinaDaske.ToString();
                        uiInputDioMaterijal.Text = prijeglodZaMaterijalDaska;
                        break;
                    }
                case "Poledina":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = Duzina.ToString();
                        uiInputDioŠirina.Text = Sirina.ToString();
                        uiInputDioDebljina.Text = standardnaDebljinaPoledine.ToString();
                        uiInputDioMaterijal.Text = prijeglodZaMaterijalDaska;
                        break;
                    }
                case "Polica":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = Dubina.ToString();
                        uiInputDioŠirina.Text = Sirina.ToString();
                        uiInputDioDebljina.Text = standardnaDebljinaDaske.ToString();
                        uiInputDioMaterijal.Text = prijeglodZaMaterijalDaska;
                        break;
                    }
                case "Gornja/donja stranica":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = Dubina.ToString();
                        uiInputDioŠirina.Text = Sirina.ToString();
                        uiInputDioDebljina.Text = standardnaDebljinaDaske.ToString();
                        uiInputDioMaterijal.Text = prijeglodZaMaterijalDaska;
                        break;
                    }
                case "Prednja/zadnja stranica":
                    {
                        uiInputDioNaziv.Text = prijedlogZaNazivDaska;
                        uiInputDioDužina.Text = Duzina.ToString();
                        uiInputDioŠirina.Text = Sirina.ToString();
                        uiInputDioDebljina.Text = standardnaDebljinaDaske.ToString();
                        uiInputDioMaterijal.Text = prijeglodZaMaterijalDaska;
                        break;
                    }

            }
        }
    }
}
