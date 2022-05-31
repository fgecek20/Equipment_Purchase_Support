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
using Equipment_Purchase_Support.Models;
using Equipment_Purchase_Support.Repositories;

namespace Equipment_Purchase_Support
{
    public partial class FrmOdobri : Form
    {
        public FrmOdobri()
        {
            InitializeComponent();
            if (FrmLogin.UlogiraniDjelatnik.Pozicija == "cip")
                button_ObradiZahtjev.Text = "Ažuriraj zahtjev";
        }

        private void Odobri_Load(object sender, EventArgs e)
        {
            string position = FrmLogin.UlogiraniDjelatnik.Pozicija;
            ShowRequestsWaitingApproval(position);


        }

        private void ShowRequestsWaitingApproval(string position)
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
            dataGridView_Requests.Columns["DatumPodnosenja"].Visible = true;
            dataGridView_Requests.Columns["OdobrenjeVodProj"].Visible = false;
            dataGridView_Requests.Columns["OdobrenjeVodRacun"].Visible = false;
            dataGridView_Requests.Columns["OdobrenjeProdNast"].Visible = false;
            dataGridView_Requests.Columns["StatusPrispijeca"].Visible = false;
            dataGridView_Requests.Columns["DatumPrispijeca"].Visible = false;

        }

        private void dataGridView_Requests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Odustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_ObradiZahtjev_Click(object sender, EventArgs e)
        {
            Zahtjev selectedrequest = dataGridView_Requests.CurrentRow.DataBoundItem as Zahtjev;
            if(selectedrequest != null)
            {
                FrmOdobri2 frmOdobri2 = new FrmOdobri2(selectedrequest);
                frmOdobri2.ShowDialog();
            }
        }
    }
}
