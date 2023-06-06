using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVermietung
{
    public class Auto
    {
        // Attribute
        private int AutoNr;
        private string Hersteller;
        private string Model;
        private int PS;
        private string Baujahr;
        private double MietPreis;
        private bool Verfuegbar;

        public Auto(int autoNr, string hersteller, string model, int pS, string baujahr, double mietPreis, bool verfuegbar)
        {
            AutoNr = autoNr;
            Hersteller = hersteller;
            Model = model;
            PS = pS;
            Baujahr = baujahr;
            MietPreis = mietPreis;
            Verfuegbar = verfuegbar;
        }

        public double GetMietPreis()
        {
            return MietPreis;
        }

        public bool GetVerfuegbar()
        {
            return Verfuegbar;
        }

        public void SetVerfuegbar(bool verfuegbar)
        {
            Verfuegbar = verfuegbar;
        }
    }
}
