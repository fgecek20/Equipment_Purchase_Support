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
    public partial class FrmOdobri2 : Form
    {
        public Zahtjev SelectedZahtjev { get; set; }

        public FrmOdobri2(Zahtjev selectedZahtjev)
        {
            InitializeComponent();
            button_Azuriraj.Visible = false;
            label_status.Visible = false;
            comboBox_status.Visible = false;
            SelectedZahtjev = selectedZahtjev;
            label_urbr.Text = "Urbroj: " + SelectedZahtjev.Urbroj.ToString();
            label_naziv.Text = "Naziv opreme: " + SelectedZahtjev.NazivOpreme;
            label_ponuditelj.Text = "Ponuditelj: " + SelectedZahtjev.Ponuditelj;
            label_cijenabezPDV.Text ="Cijena bez PDV-a: " + SelectedZahtjev.CijenaBezPDV.ToString();
            label_cijenasPDV.Text = "Cijena s PDV-om: " + SelectedZahtjev.CijenaPDV.ToString();
            label_valuta.Text = "Valuta: " + SelectedZahtjev.Valuta;
            label_izvorfin.Text = "Izvor financiranja: " + SelectedZahtjev.IzvorFinanciranja;
            label_nazivproj.Text = "Naziv projekta: " + SelectedZahtjev.NazivProjekta;
            label_vodproj.Text = "Voditelj projekta: " + SelectedZahtjev.VoditeljProjekta;
            label_podnositelj.Text = "Podnositelj zahtjeva: " + SelectedZahtjev.PodnositeljZahtjeva;
            label_datumpodnosenja.Text = "Datum podnošenja zahtjeva: " + SelectedZahtjev.DatumPodnosenja;
            label_odobvodproj.Text = "Voditelj/ica projekta: " + SelectedZahtjev.DetermineStatus(SelectedZahtjev.OdobrenjeVodProj);
            label_odobvodracun.Text = "Voditelj/ica računovodstva: " + SelectedZahtjev.DetermineStatus(SelectedZahtjev.OdobrenjeVodRacun);
            label_odobprodnast.Text = "Prodekan/ica za nastavu: " + SelectedZahtjev.DetermineStatus(SelectedZahtjev.OdobrenjeProdNast);

            if(FrmLogin.UlogiraniDjelatnik.Pozicija == "cip")
            {
                button_Odobri.Visible = false;
                button_Odbij.Visible = false;
            }

            if(SelectedZahtjev.DetermineStatus(SelectedZahtjev.OdobrenjeVodProj) == "Prihvaćeno" &&
                SelectedZahtjev.DetermineStatus(SelectedZahtjev.OdobrenjeVodRacun) == "Prihvaćeno" &&
                SelectedZahtjev.DetermineStatus(SelectedZahtjev.OdobrenjeProdNast) == "Prihvaćeno" &&
                FrmLogin.UlogiraniDjelatnik.Pozicija == "cip")
            {
                button_Azuriraj.Visible = true;
                label_status.Visible = true;
                comboBox_status.Visible = true;
                comboBox_status.Text = "U dolasku";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_Odustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Odobri_Click(object sender, EventArgs e)
        {
            string sql;
            if (FrmLogin.UlogiraniDjelatnik.Pozicija == "vod_proj")
                sql = $"UPDATE Zahtjevi SET Odobrenje_vod_proj = '1'  WHERE Urbroj = '{SelectedZahtjev.Urbroj}'";
            else if (FrmLogin.UlogiraniDjelatnik.Pozicija == "vod_racun")
                sql = $"UPDATE Zahtjevi SET Odobrenje_vod_racun = '1' WHERE Urbroj = '{SelectedZahtjev.Urbroj}'";
            else sql = $"UPDATE Zahtjevi SET Odobrenje_prod_nast = '1' WHERE Urbroj = '{SelectedZahtjev.Urbroj}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            Close();

        }

        private void button_Odbij_Click(object sender, EventArgs e)
        {
            string sql;
            if (FrmLogin.UlogiraniDjelatnik.Pozicija == "vod_proj")
                sql = $"UPDATE Zahtjevi SET Odobrenje_vod_proj = '0'  WHERE Urbroj = '{SelectedZahtjev.Urbroj}'";
            else if (FrmLogin.UlogiraniDjelatnik.Pozicija == "vod_racun")
                sql = $"UPDATE Zahtjevi SET Odobrenje_vod_racun = '0' WHERE Urbroj = '{SelectedZahtjev.Urbroj}'";
            else sql = $"UPDATE Zahtjevi SET Odobrenje_prod_nast = '0' WHERE Urbroj = '{SelectedZahtjev.Urbroj}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            Close();
        }

        private void button_Azuriraj_Click(object sender, EventArgs e)
        {
            string sql;
            if (comboBox_status.Text == "Zaprimljeno")
                sql = $"UPDATE Zahtjevi SET Status_prispijeca = '1', " +
                    $"Datum_prispijeca = GETDATE() WHERE Urbroj = '{SelectedZahtjev.Urbroj}'";
            else
                sql = $"UPDATE Zahtjevi SET Status_prispijeca = '0' " +
                    $"WHERE Urbroj = '{SelectedZahtjev.Urbroj}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            Close();
        
        }
    }
}
