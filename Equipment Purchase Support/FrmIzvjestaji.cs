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
    public partial class FrmIzvjestaji : Form
    {
        public FrmIzvjestaji()
        {
            InitializeComponent();
        }

        private void FrmIzvjestaji_Load(object sender, EventArgs e)
        {
            button_Trajanje.Enabled = false;
        }

        private void button_BrojZahtjeva_Click(object sender, EventArgs e)
        {
            FrmIzvjestajOBrojuZahtjeva frmIzvjestajOBrojuZahtjeva = new FrmIzvjestajOBrojuZahtjeva();
            frmIzvjestajOBrojuZahtjeva.ShowDialog();
        }
    }
}
