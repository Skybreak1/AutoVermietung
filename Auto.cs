using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVermietung
{
    internal class Auto
    {
        private int AutoNr;
        private String Hersteller;
        private String Modell;
        private int PS;
        private string Baujahr;
        private float Mietpreis;
        private bool Verfuegbar;

        public Auto(int autoNr, string hersteller, string modell, int pS, string baujahr, float mietpreis, bool verfuegbar)
        {
            AutoNr = autoNr;
            Hersteller = hersteller;
            Modell = modell;
            PS = pS;
            Baujahr = baujahr;
            Mietpreis = mietpreis;
            Verfuegbar = verfuegbar;
        }
        float getMietPreis()
        {
            return Mietpreis;
        }

        bool getVerfuegbar()
        {
            return Verfuegbar;
        }
        bool setVerfuegbar() 
        { 
            return Verfuegbar; 
        }
    }
}
