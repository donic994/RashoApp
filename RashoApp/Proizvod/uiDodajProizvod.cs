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

            Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter noviDioTableAdapter = new Baza18043_DBDataSetTableAdapters.ProizvodTableAdapter();
            noviDioTableAdapter.Insert(duzina, sirina, dubina, slika, naziv);

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
                string filePath = openFileDialogOdaberiSliku.FileName;

                uiInputSlika.Text = filePath;
            }


            //PictureBox pb = new PictureBox();
            //pb.Load(path)
        }
    }
}
