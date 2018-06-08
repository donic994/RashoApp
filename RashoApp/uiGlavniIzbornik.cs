using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RashoApp
{
    public partial class uiGlavniIzbornik : Form
    {
        public uiGlavniIzbornik()
        {
            InitializeComponent();
        }

        private void uiTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            TabPage _tabPage = uiTabControl.TabPages[e.Index];
            Rectangle _tabBounds = uiTabControl.GetTabRect(e.Index);

            //Custom boje za prozore
            SolidBrush brushProizvodi = new SolidBrush(PopisBoja.bojaProizvod);
            SolidBrush brushNarudžbe = new SolidBrush(PopisBoja.bojaNarudžba);
            SolidBrush brushDnevnik = new SolidBrush(PopisBoja.bojaDnevnik);
            SolidBrush brushKorisnici = new SolidBrush(PopisBoja.bojaKorisnici);
            SolidBrush brushNeaktivno = new SolidBrush(PopisBoja.bojaNeaktivniTab);

            if (e.State == DrawItemState.Selected)
            {
                _textBrush = new SolidBrush(Color.White);
                if (e.Index == 0)
                {
                    g.FillRectangle(brushProizvodi, e.Bounds);
                }
                if (e.Index == 1)
                {
                    g.FillRectangle(brushNarudžbe, e.Bounds);
                }
                if (e.Index == 2)
                {
                    g.FillRectangle(brushDnevnik, e.Bounds);
                }
                if (e.Index == 3)
                {
                    g.FillRectangle(brushKorisnici, e.Bounds);
                }
            }
            else
            {
                g.FillRectangle(brushNeaktivno, e.Bounds);
                _textBrush = new System.Drawing.SolidBrush(Color.White);
            }
            Font _tabFont = new Font("Arial", (float)18.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Nacrtaj string i poravnaj ga po sredini
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));                    
        }

        private void uiTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (uiTabControl.SelectedIndex)
            {
                case 0:
                    {
                        uiDjelovi frm = new uiDjelovi();
                        frm.TopLevel = false;
                        frm.Visible = true;
                        frm.FormBorderStyle = FormBorderStyle.None;
                        frm.Dock = DockStyle.Fill;
                        uiTabControl.TabPages[0].Controls.Add(frm);
                        break;
                    }

            }
        }
    }
}
