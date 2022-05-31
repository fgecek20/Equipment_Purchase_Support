using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equipment_Purchase_Support.Repositories;
using Equipment_Purchase_Support.Models;

namespace Equipment_Purchase_Support
{
    public partial class FrmIzvjestajOBrojuZahtjeva : Form
    {
        public FrmIzvjestajOBrojuZahtjeva()
        {
            InitializeComponent();
        }

        private void FrmIzvjestajOBrojuZahtjeva_Load(object sender, EventArgs e)
        {
            string Order = "ASC";
            ShowReport(Order);
        }

        private void ShowReport(string order)
        {
            BrojIzvjestaja broj = new BrojIzvjestaja();
            var reports = IzvjestajiRepository.GetReport(broj.AscDesc(order));
            dataGridView_BROJ.DataSource = reports;

            dataGridView_BROJ.Columns[0].HeaderText = "Izvor financija";
            dataGridView_BROJ.Columns[1].HeaderText = "Broj";
        }

        private void button_ASC_Click(object sender, EventArgs e)
        {
            ShowReport("ASC");
        }

        private void button_DSC_Click(object sender, EventArgs e)
        {
            ShowReport("DSC");
        }

        private void button_Zatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
