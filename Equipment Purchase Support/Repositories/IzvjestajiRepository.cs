using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Equipment_Purchase_Support.Models;
using DBLayer;
using System.Data.SqlClient;

namespace Equipment_Purchase_Support.Repositories
{
    public class IzvjestajiRepository
    {
        public static List<BrojIzvjestaja> GetReport(string sql)
        {
            var reports = new List<BrojIzvjestaja>();

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while(reader.Read())
            {
                BrojIzvjestaja brojIzvjestaja = CreateObject(reader);
                reports.Add(brojIzvjestaja);
            }
            reader.Close();
            DB.CloseConnection();
            return reports;
        }

        private static BrojIzvjestaja CreateObject(SqlDataReader reader)
        {
            string izvorfinancija = reader["Izvor_financiranja"].ToString();
            int brojzahtjeva = int.Parse(reader["Broj"].ToString());

            var report = new BrojIzvjestaja
            {
                IzvorFinancija = izvorfinancija,
                BrojZahtjeva = brojzahtjeva
            };

            return report;
        }
    }
}
