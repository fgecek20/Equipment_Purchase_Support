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
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;
            Authentication(username, password);
        }

        private void Authentication(string username, string password)
        {
            string sql = $"SELECT * FROM Djelatnici WHERE Korisnicko_ime = '{username}' AND " +
                $"Lozinka = '{password}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                FrmGlavniIzbornik frmGlavniIzbornik = new FrmGlavniIzbornik();
                Hide();
                frmGlavniIzbornik.ShowDialog();
                reader.Close();
                Close();

            }
            else
                MessageBox.Show("Neispravni podaci!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
