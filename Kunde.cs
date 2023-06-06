using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVermietung
{
    internal class Kunde
    {
        // Attribute
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

        public int GetKundenNr()
        {
            return KundenNr;
        }

        public string GetName()
        { 
            return Vorname + " " + Nachname; 
        }

        public string GetAdresse()
        {
            return Adresse;
        }

        public DateTime GetKundeSeit()
        {
            return KundeSeit;
        }

    }
}
