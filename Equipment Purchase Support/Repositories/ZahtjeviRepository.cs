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
    public class ZahtjeviRepository
    {
        public static List<Zahtjev> GetRequests(string position)
        { 
            var requests = new List<Zahtjev>();

            string sql;
            string leader;
            if (position == "vod_proj")
            {
                leader = FrmLogin.UlogiraniDjelatnik.Ime + " " + FrmLogin.UlogiraniDjelatnik.Prezime;
                sql = $"SELECT * FROM Zahtjevi WHERE Voditelj_projekta = '{leader}' " +
                $"AND Odobrenje_vod_proj IS NULL";
            }
            else if (position == "vod_racun")
                sql = $"SELECT * FROM Zahtjevi WHERE Odobrenje_vod_racun IS NULL";
            else if (position == "prod_nast")
                sql = $"SELECT * FROM Zahtjevi WHERE Odobrenje_prod_nast IS NULL";
            else sql = $"SELECT * FROM Zahtjevi";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while(reader.Read())
            {
                Zahtjev request = CreateObject(reader);
                requests.Add(request);
            }
            reader.Close();
            DB.CloseConnection();
            return requests;
        }

        public static List<Zahtjev> GetMyRequests()
        {
            var requests = new List<Zahtjev>();

            string myname = FrmLogin.UlogiraniDjelatnik.Ime + " " + FrmLogin.UlogiraniDjelatnik.Prezime;
            string sql = $"SELECT * FROM Zahtjevi WHERE Podnositelj_zahtjeva = '{myname}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zahtjev request = CreateObject(reader);
                requests.Add(request);
            }
            reader.Close();
            DB.CloseConnection();
            return requests;
        }

        private static Zahtjev CreateObject(SqlDataReader reader)
        {
            int urbroj = int.Parse(reader["Urbroj"].ToString());
            string naziv = reader["Naziv_opreme"].ToString();
            string ponuditelj = reader["Ponuditelj"].ToString();
            float cijenabezPDV = float.Parse(reader["Cijena_bez_PDV"].ToString());
            float cijenaPDV = float.Parse(reader["Cijena_s_PDV"].ToString());
            string valuta = reader["Valuta"].ToString();
            string izvorfinanciranja = reader["Izvor_financiranja"].ToString();
            string nazivprojekta = reader["Naziv_projekta"].ToString();
            string voditeljprojekta = reader["Voditelj_projekta"].ToString();
            string podnositeljzahtjeva = reader["Podnositelj_zahtjeva"].ToString();
            string datumpodnosenja = reader["Datum_podnosenja"].ToString();
            string odobrenjevodproj = reader["Odobrenje_vod_proj"].ToString();
            string odobrenjevodracun = reader["Odobrenje_vod_racun"].ToString();
            string odobrenjeprodnast = reader["Odobrenje_prod_nast"].ToString();
            string statusprispijeca = reader["Status_prispijeca"].ToString();
            string datumprispijeca = reader["Datum_prispijeca"].ToString();


            var request = new Zahtjev
            {
                Urbroj = urbroj,
                NazivOpreme = naziv,
                Ponuditelj = ponuditelj,
                CijenaBezPDV = cijenabezPDV,
                CijenaPDV = cijenaPDV,
                Valuta = valuta,
                IzvorFinanciranja = izvorfinanciranja,
                NazivProjekta = nazivprojekta,
                VoditeljProjekta = voditeljprojekta,
                PodnositeljZahtjeva = podnositeljzahtjeva,
                DatumPodnosenja = datumpodnosenja,
                OdobrenjeVodProj = odobrenjevodproj,
                OdobrenjeVodRacun = odobrenjevodracun,
                OdobrenjeProdNast = odobrenjeprodnast,
                StatusPrispijeca = statusprispijeca,
                DatumPrispijeca = datumprispijeca
            };

            return request;

        }
    }
}
