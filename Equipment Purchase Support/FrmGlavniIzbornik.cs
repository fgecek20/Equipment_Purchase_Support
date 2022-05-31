using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equipment_Purchase_Support.Models;
using DBLayer;

namespace Equipment_Purchase_Support
{
    public partial class FrmGlavniIzbornik : Form
    {

        public FrmGlavniIzbornik()
        {
            InitializeComponent();
            label_KorimePrijavljenog.Text = FrmLogin.UlogiraniDjelatnik.KorisnickoIme;
            if(FrmLogin.UlogiraniDjelatnik.Pozicija == "djelatnik")
            {
                button_Odobri.Visible = false;
                button_Izvjestaji.Visible = false;
            }
            else if(FrmLogin.UlogiraniDjelatnik.Pozicija == "vod_proj" ||
                    FrmLogin.UlogiraniDjelatnik.Pozicija == "vod_racun" ||
                    FrmLogin.UlogiraniDjelatnik.Pozicija == "prod_nast")
            {
                button_Odobri.Visible = true;
                button_Odobri.Text = "Odobri";
                button_Izvjestaji.Visible = false;
            }
            else
            {
                button_Odobri.Visible = true;
                button_Odobri.Text = "Ažuriraj narudžbe";
                button_Izvjestaji.Visible = true;
            }
        }

        private void button_NoviZahtjev_Click(object sender, EventArgs e)
        {
            FrmNoviZahtjev frmNoviZahtjev = new FrmNoviZahtjev();
            frmNoviZahtjev.ShowDialog();
        }

        private void button_Odjava_Click(object sender, EventArgs e)
        {
            FrmLogin.UlogiraniDjelatnik = null;
            FrmLogin frmLogin = new FrmLogin();
            Hide();
            frmLogin.ShowDialog();
            Close();

        }

        private void button_Odobri_Click(object sender, EventArgs e)
        {
            FrmOdobri frmOdobri = new FrmOdobri();
            frmOdobri.ShowDialog();
        }

        private void button_PopisZahtjeva_Click(object sender, EventArgs e)
        {
            FrmPopis frmPopis = new FrmPopis();
            frmPopis.ShowDialog();
        }

        private void button_Izvjestaji_Click(object sender, EventArgs e)
        {
            FrmIzvjestaji frmIzvjestaji = new FrmIzvjestaji();
            frmIzvjestaji.ShowDialog();
        }
    }
}
