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

        public uiGlavniIzbornik() {
            InitializeComponent();

            // ako nije admin
            Debug.WriteLine("uloga:" + LoginInfo.Role);
            if (LoginInfo.Role != 1) {
                uiTabControl.TabPages.RemoveAt(3);
                uiTabControlProizvodi.TabPages.Remove(uiTabProizvodiElement);
                uiTabControlProizvodi.TabPages.Remove(uiTabProizvodiKomponenta);
                uiTabControlProizvodi.TabPages.Remove(uiTabProizvodiUlogaDijela);
            }

            PopuniOdUiDjelovi();
            PopuniOdUiElement();
            PopuniOdUiKomponenta();
            PopuniOdUiProizvod();
            PopuniOdUiUlogaDijela();
            PopuniOdUiUlogeKorisnika();
            PopuniOdUiKorisnici();

            PrilagodiVisinuTabova();
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
    }
}
