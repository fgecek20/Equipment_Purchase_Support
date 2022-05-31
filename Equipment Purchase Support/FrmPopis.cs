using Equipment_Purchase_Support.Models;
using Equipment_Purchase_Support.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipment_Purchase_Support
{
    public partial class FrmPopis : Form
    {
        public FrmPopis()
        {
            InitializeComponent();
        }

        private void FrmPopis_Load(object sender, EventArgs e)
        {
            ShowRequests("baldur");
            button_MojiZahtjevi.Enabled = true;
        }

        private void ShowRequests(string position)
        {
            
            var requests = ZahtjeviRepository.GetRequests(position);
            dataGridView_Requests.DataSource = requests;

            dataGridView_Requests.Columns["Urbroj"].Visible = true;
            dataGridView_Requests.Columns["NazivOpreme"].Visible = true;
            dataGridView_Requests.Columns["Ponuditelj"].Visible = false;
            dataGridView_Requests.Columns["CijenaBezPDV"].Visible = false;
            dataGridView_Requests.Columns["CijenaPDV"].Visible = false;
            dataGridView_Requests.Columns["Valuta"].Visible = false;
            dataGridView_Requests.Columns["IzvorFinanciranja"].Visible = false;
            dataGridView_Requests.Columns["NazivProjekta"].Visible = false;
            dataGridView_Requests.Columns["VoditeljProjekta"].Visible = false;
            dataGridView_Requests.Columns["PodnositeljZahtjeva"].Visible = true;
            dataGridView_Requests.Columns["DatumPodnosenja"].Visible = false;
            dataGridView_Requests.Columns["OdobrenjeVodProj"].Visible = false;
            dataGridView_Requests.Columns["OdobrenjeVodRacun"].Visible = false;
            dataGridView_Requests.Columns["OdobrenjeProdNast"].Visible = false;
            dataGridView_Requests.Columns["StatusPrispijeca"].Visible = false;
            dataGridView_Requests.Columns["DatumPrispijeca"].Visible = false;

        }

        private void ShowMyRequests()
        {

            var requests = ZahtjeviRepository.GetMyRequests();
            dataGridView_Requests.DataSource = requests;

            dataGridView_Requests.Columns["Urbroj"].Visible = true;
            dataGridView_Requests.Columns["NazivOpreme"].Visible = true;
            dataGridView_Requests.Columns["Ponuditelj"].Visible = false;
            dataGridView_Requests.Columns["CijenaBezPDV"].Visible = false;
            dataGridView_Requests.Columns["CijenaPDV"].Visible = false;
            dataGridView_Requests.Columns["Valuta"].Visible = false;
            dataGridView_Requests.Columns["IzvorFinanciranja"].Visible = false;
            dataGridView_Requests.Columns["NazivProjekta"].Visible = false;
            dataGridView_Requests.Columns["VoditeljProjekta"].Visible = false;
            dataGridView_Requests.Columns["PodnositeljZahtjeva"].Visible = true;
            dataGridView_Requests.Columns["DatumPodnosenja"].Visible = false;
            dataGridView_Requests.Columns["OdobrenjeVodProj"].Visible = false;
            dataGridView_Requests.Columns["OdobrenjeVodRacun"].Visible = false;
            dataGridView_Requests.Columns["OdobrenjeProdNast"].Visible = false;
            dataGridView_Requests.Columns["StatusPrispijeca"].Visible = false;
            dataGridView_Requests.Columns["DatumPrispijeca"].Visible = false;

        }

        private void button_MojiZahtjevi_Click(object sender, EventArgs e)
        {
            ShowMyRequests();
            button_MojiZahtjevi.Enabled = false;
            button_SviZahtjevi.Enabled = true;

        }

        private void button_SviZahtjevi_Click(object sender, EventArgs e)
        {
            ShowRequests("terracotta");
            button_SviZahtjevi.Enabled = false;
            button_MojiZahtjevi.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zahtjev selectedrequest = dataGridView_Requests.CurrentRow.DataBoundItem as Zahtjev;
            if(selectedrequest != null)
            {
                FrmDetalji frmDetalji = new FrmDetalji(selectedrequest);
                frmDetalji.ShowDialog();
            }
        }
    }
}
