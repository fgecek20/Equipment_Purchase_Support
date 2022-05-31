using Equipment_Purchase_Support.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

namespace Equipment_Purchase_Support
{
    public partial class FrmDetalji : Form
    {
        public Zahtjev SelectedRequest { get; set; }

        public FrmDetalji(Zahtjev selectedrequet)
        {
            InitializeComponent();
            button_Ponisti.Visible = false;
            label_stat.Visible = false;
            stat.Visible = false;
            label_datup.Visible = false;
            datup.Visible = false;
            SelectedRequest = selectedrequet;
            urb.Text = SelectedRequest.Urbroj.ToString();
            naz.Text = SelectedRequest.NazivOpreme;
            pon.Text = SelectedRequest.Ponuditelj;
            cbPDV.Text = SelectedRequest.CijenaBezPDV.ToString();
            csPDV.Text = SelectedRequest.CijenaPDV.ToString();
            val.Text = SelectedRequest.Valuta;
            izv.Text = SelectedRequest.IzvorFinanciranja;
            nazp.Text = SelectedRequest.NazivProjekta;
            vod.Text = SelectedRequest.VoditeljProjekta;
            podn.Text = SelectedRequest.PodnositeljZahtjeva;
            datu.Text = SelectedRequest.DatumPodnosenja;
            odobvodp.Text = SelectedRequest.DetermineStatus(SelectedRequest.OdobrenjeVodProj);
            odobvodr.Text = SelectedRequest.DetermineStatus(SelectedRequest.OdobrenjeVodRacun);
            odobprod.Text = SelectedRequest.DetermineStatus(SelectedRequest.OdobrenjeProdNast);

            if((podn.Text == FrmLogin.UlogiraniDjelatnik.Ime + " " + FrmLogin.UlogiraniDjelatnik.Prezime) &&
                (odobvodp.Text == "U obradi" || odobvodr.Text == "U obradi" || odobprod.Text == "U obradi"))
            {
                button_Ponisti.Visible = true;
            }

            if(odobvodp.Text == "Prihvaćeno" && odobvodr.Text == "Prihvaćeno" && odobprod.Text == "Prihvaćeno")
            {
                label_stat.Visible = true;
                stat.Visible = true;
                stat.Text = SelectedRequest.StatusPrispijeca;
                if (stat.Text == "") stat.Text = "Narudžba nije ažurirana";
                else if(stat.Text == "False") stat.Text = "U dolasku";
                else
                {
                    stat.Text = "Zaprimljeno";
                    label_datup.Visible = true;
                    datup.Visible = true;
                    datup.Text = SelectedRequest.DatumPrispijeca;
                }
            }
        }

        private void FrmDetalji_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM Zahtjevi WHERE Urbroj = '{SelectedRequest.Urbroj}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            Close();
        }
    }
}
