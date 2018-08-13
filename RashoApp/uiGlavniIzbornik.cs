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

        public uiGlavniIzbornik() {
            InitializeComponent();

            TabControls = new List<Control>();
            GetAllControlsByType(this, typeof(TabPage), TabControls);

            PopuniOdUiDjelovi();
            PopuniOdUiElement();
            PopuniOdUiKomponenta();
            PopuniOdUiProizvod();
            PopuniOdUiUlogaDijela();
            PopuniOdUiUlogeKorisnika();
            PopuniOdUiKorisnici();

            PrilagodiVisinuTabova();
        }

        ~uiGlavniIzbornik() {
            LoginInfo.CloseSession();
        }

        private void uiGlavniIzbornik_Load(object sender, EventArgs e) {
            // ako nije admin
            Debug.WriteLine("uloga:" + LoginInfo.Role);
            if (LoginInfo.Role != 1) {

                foreach(var c in TabControls) {
                    Debug.WriteLine("Control: " + c.Name);
                }

                HideTabPage("uiTabKorisniciKorisnici");
                HideTabPage("Dnevnik");
                Debug.WriteLine("Tag: " + GetTabByName("Dnevnik").Tag);
                ShowTabPage("uiTabKorisniciKorisnici");
                ShowTabPage("Dnevnik");

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

        private void HideTabPage(string tabName) {
            TabPage tab = GetTabByName(tabName);
            if (tab != null) {
                tab.Parent.Controls.RemoveByKey(tabName);
            }
        }

        private void ShowTabPage(string tabName) {
            TabPage tab = GetTabByName(tabName);
            ShowTabPage(tab, uiTabControlKorisnici.TabPages.Count);
        }
        
        private void ShowTabPage(TabPage tab, int index) {
            TabControl parent = tab.Tag as TabControl;

            if (parent == null) {
                Debug.WriteLine("Roditelj nije pronađen.");
                return;
            }
            
            if (parent.Controls.Contains(tab)) { return; }
            InsertTabPage(tab, parent, index);
        }

        private void InsertTabPage(TabPage tab, TabControl parent, int index) {
            if (index < 0 || index > parent.Controls.Count)
                throw new ArgumentException("Index out of Range.");
            parent.Controls.Add(tab);
            if (index < parent.Controls.Count - 1)
                do {
                    SwapTabPages(tab, parent.Controls[parent.Controls.IndexOf(tab) - 1] as TabPage);
                }
                while (parent.Controls.IndexOf(tab) != index);
        }

        private void SwapTabPages(TabPage tab1, TabPage tab2) {
            if (tab1.Parent.Controls.Contains(tab1) == false || tab1.Parent.Controls.Contains(tab2) == false)
                throw new ArgumentException("TabPages must be in the TabControls TabPageCollection.");

            int Index1 = tab1.Parent.Controls.IndexOf(tab1);
            int Index2 = tab1.Parent.Controls.IndexOf(tab2);
            tab1.Parent.Controls.SetChildIndex(tab2, Index1);
            tab1.Parent.Controls.SetChildIndex(tab1, Index2);
        }


        private void GetAllControlsByType(Control parent, Type type, List<Control> ControlList) {
            foreach (Control c in parent.Controls) {
                GetAllControlsByType(c, type, ControlList);
                if (c.GetType() == type) {
                    c.Tag = c.Parent; // da mogu vratiti tab kod pravog roditelja
                    ControlList.Add(c);
                }
            }
        }

        private TabPage GetTabByName(string tabName) {
            foreach(TabPage tab in TabControls) {
                if (tab.Name == tabName) {
                    return tab;
                }
            }
            return null;
        }
    }
}
