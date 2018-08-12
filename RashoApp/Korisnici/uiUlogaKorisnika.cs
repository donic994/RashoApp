using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

/// <summary>
/// UIUlogaKorisnika služi za dodavanje ili izmjenu već postojećih uloga korisnika
/// Konstruktor prima jedan parametar koji označava ID uloge (default je -1; označava da korisnik nije odabrao već postojeću ulogu nego se kreira nova)
/// U slučaju da je prenesen ID konstruktoru, automatski će se popuniti polja podacima iz baze te nakon klika na gumb uiActionPrihvati, ažurirat će se uloga u bazi.
/// U slučaju da nije prenesen ID uloge, tada program prepoznaje da korisnik unosi novu ulogu i nakon prihvaćanja, dodaje se nova uloga u bazu.
/// </summary>

namespace RashoApp.Korisnici {

    public partial class UIUlogaKorisnika : Form {

        private int ulogaID;
        private Baza18043_DBDataSetTableAdapters.UlogaKorisnikaTableAdapter ulogaTableAdapter;
        private Baza18043_DBDataSetTableAdapters.UIElementiTableAdapter uiElementiTableAdapter;

        public UIUlogaKorisnika(int ulogaID=-1) {
            InitializeComponent();
            ulogaTableAdapter = new Baza18043_DBDataSetTableAdapters.UlogaKorisnikaTableAdapter();
            uiElementiTableAdapter = new Baza18043_DBDataSetTableAdapters.UIElementiTableAdapter();

            this.ulogaID = ulogaID;

            // Ako je uloga prosljeđena formi (ako se radi o izmjeni uloge)
            if (ulogaID >= 0) {
                IspuniPodatkeOUlogi();
            }
        }

        private void UIUlogaKorisnika_Load(object sender, EventArgs e) {
            // Popuni tree view rootove
            var uiElementi = uiElementiTableAdapter.GetDataByNullRoditelj();
            foreach (DataRow row in uiElementi.Rows) {
                // Kreiraj čvor
                TreeNode node = new TreeNode();
                node.Text = row[1].ToString();
                node.Name = row[0].ToString();

                uiTreeDozvole.Nodes.Add(node);

                // Popuni trenutni node
                PopuniTreeNode(node);
            }
        }

        // Popunjava tree view podacima iz baze
        private void PopuniTreeNode(TreeNode parent) {
            var uiElementi = uiElementiTableAdapter.GetDataByRoditelj(int.Parse(parent.Name));
            
            foreach (DataRow row in uiElementi.Rows) {
                TreeNode node = new TreeNode();
                node.Text = row[1].ToString();
                node.Name = row[0].ToString();
                Debug.WriteLine("redak: " + row[1].ToString());

                parent.Nodes.Add(node);
                // Popuni trenutni node
                PopuniTreeNode(node);
            }
        }

        // Ispunjava podatke o ulogi iz baze
        private void IspuniPodatkeOUlogi() {
            uiInputID.Text = ulogaID.ToString();
            var uloga = ulogaTableAdapter.GetDataByID(ulogaID);
            uiInputNaziv.Text = uloga[0].naziv;
            uiInputOpis.Text = uloga[0].opis;
        }

        private void uiActionPrihvati_Click(object sender, EventArgs e) {

            
            //Debug.WriteLine();

            return;

            if (!IsValidInput()) { return; }

            try {
                // Ako se radi o izmjeni uloge
                if (ulogaID >= 0) {
                    ulogaTableAdapter.UpdateRow(uiInputNaziv.Text, uiInputOpis.Text, ulogaID);
                // Ako se radi o novoj ulogi
                } else {
                    ulogaTableAdapter.InsertRow(uiInputNaziv.Text, uiInputOpis.Text);
                }
                Close();
            } catch (Exception) {
                uiOznakaGreška.Text = "Greška: Promjene nisu spremljene.";
            }
        }

        // Provjerava valjanost unesenih podataka
        private bool IsValidInput() {
            uiOznakaGreška.Text = "";
            bool isValid = true;

            // Jesu li unesena obvezna polja
            if (uiInputNaziv.Text.Length < 1) {
                uiOznakaGreška.Text = "Nisu unesena sva obvezna polja.";
                return false;
            }

            return isValid;
        }

        private void uiActionPoništi_Click(object sender, EventArgs e) {
            Close();
        }

        private void uiTreeDozvole_AfterCheck(object sender, TreeViewEventArgs e) {

            TreeNode node = e.Node;
            bool check = e.Node.Checked;

            CheckNodes(node, check);

        }

        // Označava svu djecu označenog čvora
        private void CheckNodes(TreeNode node, bool check) {
            foreach (TreeNode child in node.Nodes) {
                child.Checked = check;
                CheckNodes(child, check);
            }
        }
    }
}
