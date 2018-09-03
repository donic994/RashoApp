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

namespace RashoApp {
    public partial class uiGlavniIzbornik : Form {

        List<Control> TabControls;
        Baza18043_DBDataSetTableAdapters.VidljiviElementiTableAdapter vidljiviElementi;
        Baza18043_DBDataSetTableAdapters.UIElementiTableAdapter UIElementi;

        public uiGlavniIzbornik() {
            InitializeComponent();
            vidljiviElementi = new Baza18043_DBDataSetTableAdapters.VidljiviElementiTableAdapter();
            UIElementi = new Baza18043_DBDataSetTableAdapters.UIElementiTableAdapter();

            TabControls = new List<Control>();
            DohvatiSveKontrolePremaTipu(this, typeof(TabPage), TabControls);

            // Popuni tablice
            PopuniOdUiDjelovi();
            PopuniOdUiElement();
            PopuniOdUiKomponenta();
            PopuniOdUiProizvod();
            PopuniOdUiUlogaDijela();
            PopuniOdUiUlogeKorisnika();
            PopuniOdUiKorisnici();

            PrilagodiVisinuTabova();
        }

        private void uiGlavniIzbornik_Load(object sender, EventArgs e) {

            // Dohvati iz baze listu tabova koje smije viditi
            var vidljiviElementi = this.vidljiviElementi.GetVidljiviElementiByUloga(LoginInfo.UlogaKorisnika);

            foreach (var tab in TabControls) {
                // Ako se tab ne nalazi na listi, tada ga sakrij
                bool contains = vidljiviElementi.AsEnumerable().Any(row => tab.Name == row.Field<String>("naziv"));
                if (!contains) {
                    SakrijTab(tab.Name);
                }
            }
        }

        private void uiTabControl_DrawItem(object sender, DrawItemEventArgs e) {
            Graphics g = e.Graphics;
            Brush textBrush;

            TabPage tabPage = uiTabControl.TabPages[e.Index];
            Rectangle tabBounds = uiTabControl.GetTabRect(e.Index);

            //Custom boje za prozore
            SolidBrush brushProizvodi = new SolidBrush(PopisBoja.bojaProizvod);
            SolidBrush brushNarudžbe = new SolidBrush(PopisBoja.bojaNarudžba);
            SolidBrush brushDnevnik = new SolidBrush(PopisBoja.bojaDnevnik);
            SolidBrush brushKorisnici = new SolidBrush(PopisBoja.bojaKorisnici);
            SolidBrush brushNeaktivno = new SolidBrush(PopisBoja.bojaNeaktivniTab);

            g.FillRectangle(brushNeaktivno, e.Bounds);
            if (e.State == DrawItemState.Selected) {
                textBrush = new SolidBrush(Color.White);
                if (e.Index == 0) {
                    g.FillRectangle(brushProizvodi, e.Bounds);
                }
                if (e.Index == 1) {
                    g.FillRectangle(brushNarudžbe, e.Bounds);
                }
                if (e.Index == 2) {
                    g.FillRectangle(brushDnevnik, e.Bounds);
                }
                if (e.Index == 3) {
                    g.FillRectangle(brushKorisnici, e.Bounds);
                }
            } else {
                g.FillRectangle(brushNeaktivno, e.Bounds);
                textBrush = new System.Drawing.SolidBrush(Color.White);
            }
            Font _tabFont = new Font("Arial", (float)18.0, FontStyle.Bold, GraphicsUnit.Pixel);


            // Nacrtaj string i poravnaj ga po sredini
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(tabPage.Text, _tabFont, textBrush, tabBounds, new StringFormat(_stringFlags));
        }

        private void PopuniOdUiUlogeKorisnika() {
            Korisnici.UIUlogeKorisnika frm = new RashoApp.Korisnici.UIUlogeKorisnika();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            uiTabKorisniciUlogeKorisnika.Controls.Add(frm);
        }

        private void PopuniOdUiKorisnici() {
            Korisnici.UIKorisnici frm = new RashoApp.Korisnici.UIKorisnici();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            uiTabKorisniciKorisnici.Controls.Add(frm);
        }

        private void PopuniOdUiDjelovi() {
            uiDjelovi frm = new uiDjelovi();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            uiTabProizvodiDio.Controls.Add(frm);
        }

        private void PopuniOdUiElement() {
            Element.uiElement frm = new Element.uiElement(); ;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            uiTabProizvodiElement.Controls.Add(frm);
        }

        private void PopuniOdUiKomponenta() {
            Komponenta.uiKomponenta frm = new Komponenta.uiKomponenta();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            uiTabProizvodiKomponenta.Controls.Add(frm);
        }

        private void PopuniOdUiProizvod() {
            Proizvod.uiProizvod frm = new Proizvod.uiProizvod();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            uiTabProizvodiProizvod.Controls.Add(frm);
        }

        private void PopuniOdUiUlogaDijela() {
            UlogaDijela.uiUlogaDijela frm = new UlogaDijela.uiUlogaDijela();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            uiTabProizvodiUlogaDijela.Controls.Add(frm);
        }

        private void uiGlavniIzbornik_SizeChanged(object sender, EventArgs e) {
            PrilagodiVisinuTabova();
        }

        private void PrilagodiVisinuTabova() {
            if (!(WindowState == FormWindowState.Minimized)) {
                if (uiTabControl.TabCount == 4) {
                    uiTabControl.ItemSize = new System.Drawing.Size((this.Height / uiTabControl.TabCount) - 11, 120);
                }
                if (uiTabControl.TabCount == 3) {
                    uiTabControl.ItemSize = new System.Drawing.Size((this.Height / uiTabControl.TabCount) - 15, 120);
                }
            }
        }

        // Skriva tab kojemu znamo naziv
        private void SakrijTab(string tabName) {
            TabPage tab = DohvatiTabPremaImenu(tabName);
            if (tab != null) {
                tab.Parent.Controls.RemoveByKey(tabName);
            }
        }

        // Prikazuje tab za koji znamo naziv
        private void PrikaziTab(string tabName) {
            TabPage tab = DohvatiTabPremaImenu(tabName);
            TabControl parent = tab.Tag as TabControl;
            PrikaziTab(tab, parent, parent.Controls.Count);
        }

        // Pomoćna metoda za prikazivanje taba na formi
        private void PrikaziTab(TabPage tab, TabControl parent, int index) {
            if (parent.Controls.Contains(tab)) { return; }
            UbaciTab(tab, parent, index);
        }

        // Ubacuje tab na formu
        private void UbaciTab(TabPage tab, TabControl parent, int index) {
            if (index < 0 || index > parent.Controls.Count)
                throw new ArgumentException("Index out of Range.");
            parent.Controls.Add(tab);
            if (index < parent.Controls.Count - 1)
                do {
                    ZamijeniMjestaTabovima(tab, parent.Controls[parent.Controls.IndexOf(tab) - 1] as TabPage);
                } while (parent.Controls.IndexOf(tab) != index);
        }

        // Mijenja mjesta tabovima na formi
        private void ZamijeniMjestaTabovima(TabPage tab1, TabPage tab2) {
            if (tab1.Parent.Controls.Contains(tab1) == false || tab1.Parent.Controls.Contains(tab2) == false)
                throw new ArgumentException("TabPages must be in the TabControls TabPageCollection.");

            int Index1 = tab1.Parent.Controls.IndexOf(tab1);
            int Index2 = tab1.Parent.Controls.IndexOf(tab2);
            tab1.Parent.Controls.SetChildIndex(tab2, Index1);
            tab1.Parent.Controls.SetChildIndex(tab1, Index2);
        }

        // Vraća sve kontrole na formi zadanog tipa
        private void DohvatiSveKontrolePremaTipu(Control parent, Type type, List<Control> ControlList) {
            foreach (Control c in parent.Controls) {
                DohvatiSveKontrolePremaTipu(c, type, ControlList);
                if (c.GetType() == type) {
                    c.Tag = c.Parent; // da mogu vratiti tab kod pravog roditelja
                    ControlList.Add(c);
                }
            }
        }

        // Vraća tab za koji smo dali ime
        private TabPage DohvatiTabPremaImenu(string tabName) {
            foreach (TabPage tab in TabControls) {
                if (tab.Name == tabName) {
                    return tab;
                }
            }
            return null;
        }
    }
}
