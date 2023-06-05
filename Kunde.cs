using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVermietung
{
    internal class Kunde
    {
        private int KundenNr;
        private string Vorname;
        private string Nachname;
        private string Adresse;
        private DateTime KundeSeit;

        public Kunde(int kundenNr, string vorname, string nachname, string adresse, DateTime kundeSeit)
        {
            KundenNr = kundenNr;
            Vorname = vorname;
            Nachname = nachname;
            Adresse = adresse;
            KundeSeit = kundeSeit;
        }
        int GetKundenNr()
        {
            return KundenNr;
        }
        string GetName()
        {
            return Vorname + "" + Nachname;
        }
        string GetAdresse()
        {
            return Adresse;
        }
        DateTime GetKundeSeit()
        {
            return KundeSeit;
        }
        

        
    }
}
