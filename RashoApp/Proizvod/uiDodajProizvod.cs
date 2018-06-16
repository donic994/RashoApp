using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RashoApp.Proizvod
{
    public partial class uiDodajProizvod : Form
    {
        private string destinacijaČitanja;
        private string destinacijaSpremanja = "";

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
            int duzina = 0, sirina = 0, dubina = 0;
            string naziv = uiInputNaziv.Text;
            int.TryParse(uiInputDužina.Text.ToString(), out duzina);
            int.TryParse(uiInputŠirina.Text.ToString(), out sirina);
            int.TryParse(uiInputDubina.Text.ToString(), out dubina);
            string slika = uiInputSlika.Text;

            if (!String.IsNullOrWhiteSpace(slika))
            {
                //Dodaj sliku u lokalni direktorij(Slike)
                destinacijaSpremanja = "F:\\DoNiC\\FOI\\8 semestar\\PI\\Projekt2018\\RashoApp\\RashoApp\\bin\\Debug\\Slike\\Slika" + naziv + ".png";

                File.Copy(destinacijaČitanja.ToString(), destinacijaSpremanja);
                //

                Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter noviDioTableAdapter = new Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter();
                noviDioTableAdapter.Insert(duzina, sirina, dubina, destinacijaSpremanja, naziv);
            }else
            {
                Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter noviDioTableAdapter = new Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter();
                noviDioTableAdapter.Insert(duzina, sirina, dubina, slika, naziv);
            }

            SpremiPromjene();

            int proizvodID = int.Parse(this.proizvodTableAdapter.VratiZadnjiIDProizvoda().ToString());

            this.Close();
            Proizvod.uiDodajDjeloveUProizvod frm = new uiDodajDjeloveUProizvod(proizvodID, duzina, sirina, dubina);
            frm.ShowDialog();
        }

        private void uiActionOdaberiSliku_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialogOdaberiSliku = new OpenFileDialog();
            openFileDialogOdaberiSliku.Title = "Odaberi sliku";
            openFileDialogOdaberiSliku.Filter = "Picture files (*.png, *.jpg, *.jpeg) | *.png; *.jpg; *.jpeg";

            if (openFileDialogOdaberiSliku.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                destinacijaČitanja = openFileDialogOdaberiSliku.FileName;
                StreamReader čitaj = new StreamReader(File.OpenRead(openFileDialogOdaberiSliku.FileName));

                uiInputSlika.Text = destinacijaČitanja;
                čitaj.Dispose();
            }
        }

        private void uiInputDužina_Leave(object sender, EventArgs e)
        {
            int ispis;
            if (!int.TryParse(uiInputDužina.Text, out ispis) || uiInputDužina.Text == null)
            {
                MessageBox.Show("Unesite brojčanu vrijednost u Dužina!");
                uiInputDužina.Text = "";
                uiInputDužina.Focus();
                uiActionDalje.Enabled = false;
            }
            else
            {
                uiActionDalje.Enabled = true;
            }
        }

        private void uiInputNaziv_Leave(object sender, EventArgs e)
        { 
            if (uiInputNaziv.Text == null)
            {
                MessageBox.Show("Unesite vrijednost u Naziv!");
                uiInputNaziv.Text = "";
                uiInputNaziv.Focus();
                uiActionDalje.Enabled = false;
            }
            else
            {
                uiActionDalje.Enabled = true;
            }
        }

        private void uiInputŠirina_Leave(object sender, EventArgs e)
        {
            int ispis;
            if(!int.TryParse(uiInputŠirina.Text, out ispis) || uiInputŠirina.Text == null)
            {
                MessageBox.Show("Unesite brojčanu vrijednost u Širina!");
                uiInputŠirina.Text = "";
                uiInputŠirina.Focus();
                uiActionDalje.Enabled = false;
            }
            else
            {
                uiActionDalje.Enabled = true;
            }
        }

        private void uiInputDubina_Leave(object sender, EventArgs e)
        {
            int ispis;
            if (!int.TryParse(uiInputDubina.Text, out ispis) || uiInputDubina.Text == null)
            {
                MessageBox.Show("Unesite brojčanu vrijednost u Dubina!");
                uiInputDubina.Text = "";
                uiInputDubina.Focus();
                uiActionDalje.Enabled = false;
            }
            else
            {
                uiActionDalje.Enabled = true;
            }
        }      
    }
}

