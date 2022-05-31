using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Purchase_Support.Models
{
    public class BrojIzvjestaja
    {
        public string IzvorFinancija { get; set; }
        public int BrojZahtjeva { get; set; }

        public string AscDesc(string order)
        {
            string sql;
            if (order == "ASC")
                sql = $"SELECT Izvor_financiranja, COUNT(Urbroj) AS Broj FROM Zahtjevi " +
                    $"GROUP BY Izvor_financiranja ORDER BY Broj ASC";
            else
                sql = $"SELECT Izvor_financiranja, COUNT(Urbroj) AS Broj FROM Zahtjevi " +
                    $"GROUP BY Izvor_financiranja ORDER BY Broj DESC";
            return sql;
        }
    }
}
