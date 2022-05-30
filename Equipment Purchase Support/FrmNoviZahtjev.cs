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
    public partial class FrmNoviZahtjev : Form
    {
        public FrmNoviZahtjev()
        {
            InitializeComponent();
            textBox_PodnositeljZahtjeva.Text = FrmLogin.UlogiraniDjelatnik.Ime + " "
                + FrmLogin.UlogiraniDjelatnik.Prezime;
            comboBox_Valuta.Text = "HRK";
            textBox_Urbroj.Text = GenerateUrbroj().ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_Odustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int GenerateUrbroj()
        {
            Random randomon_digimon = new Random();
            int urbroj;
            bool ready;
            do
            {
                ready = false;
                urbroj = randomon_digimon.Next(1000, 10000);
                string sql = $"SELECT * FROM Zahtjevi WHERE Urbroj = '{urbroj}'";
                DB.OpenConnection();
                var reader = DB.GetDataReader(sql);
                if(!reader.HasRows) ready = true;
                DB.CloseConnection();

            } while(!ready);

            return urbroj;
        }

        private void button_Podnesi_Click(object sender, EventArgs e)
        {
            if (textBox_Urbroj.Text != "" && textBox_Naziv.Text != "" &&
                textBox_Ponuditelj.Text != "" && textBox_CijenaBezPDV.Text != "" &&
                textBox_CijenaPDV.Text != "" && textBox_IzvorFinanciranja.Text != "" &&
                textBox_NazivProjekta.Text != "" && textBox_VoditeljProjekta.Text != "" &&
                textBox_PodnositeljZahtjeva.Text != "")
            {
                int broj = int.Parse(textBox_Urbroj.Text);
                string naziv = textBox_Naziv.Text;
                string ponuditelj = textBox_Ponuditelj.Text;
                float cijenabezPDV = float.Parse(textBox_CijenaBezPDV.Text);
                float cijenaPDV = float.Parse(textBox_CijenaPDV.Text);
                string valuta = comboBox_Valuta.Text;
                string izvorfinanciranja = textBox_IzvorFinanciranja.Text;
                string nazivprojekta = textBox_NazivProjekta.Text;
                string voditeljprojekta = textBox_VoditeljProjekta.Text;
                string podnositeljzahtjeva = textBox_PodnositeljZahtjeva.Text;

                string sql = $"INSERT INTO Zahtjevi (Urbroj, Naziv_opreme, Ponuditelj, Cijena_bez_PDV, " +
                    $"Cijena_s_PDV, Valuta, Izvor_financiranja, Naziv_projekta, Voditelj_projekta, " +
                    $"Podnositelj_zahtjeva, Datum_podnosenja) VALUES ('{broj}', '{naziv}', '{ponuditelj}', " +
                    $"'{cijenabezPDV}', '{cijenaPDV}', '{valuta}', '{izvorfinanciranja}', '{nazivprojekta}', " +
                    $"'{voditeljprojekta}', '{podnositeljzahtjeva}', GETDATE())";
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
                Close();
            }
            else MessageBox.Show("Unesite sve podatke!", "", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
        }
    }
}
