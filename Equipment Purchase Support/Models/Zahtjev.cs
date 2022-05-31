using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Purchase_Support.Models
{
    public class Zahtjev
    {
        public int Urbroj { get; set; }
        public string NazivOpreme { get; set; }
        public string Ponuditelj { get; set; }
        public float CijenaBezPDV { get; set; }
        public float CijenaPDV { get; set; }
        public string Valuta { get; set; }
        public string IzvorFinanciranja { get; set; }
        public string NazivProjekta { get; set; }
        public string VoditeljProjekta { get; set; }
        public string PodnositeljZahtjeva { get; set; }
        public string DatumPodnosenja { get; set; }
        public string OdobrenjeVodProj { get; set; }
        public string OdobrenjeVodRacun { get; set; }
        public string OdobrenjeProdNast { get; set; }
        public string StatusPrispijeca { get; set; }
        public string DatumPrispijeca { get; set; }

        public string DetermineStatus(string status)
        {
            if(status == "") return "U obradi";
            else if(status == "False") return "Odbijeno";
            else return "Prihvaćeno";
        }

    }
}
