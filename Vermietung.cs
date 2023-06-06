using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVermietung
{
    internal class Vermietung
    {
        // Attribute
        private int VermietungsNr { get; set; }
        private DateTime MietStart { get; set; }
        private DateTime MietEnde { get; set; }
        private int MietDauerInTagen { get; set; }
        private Kunde Kunde { get; set; }
        private Auto Auto { get; set; }

        public Vermietung(int vermietungsNr, DateTime mietStart, DateTime mietEnde, int mietDauerInTagen, Kunde kunde, Auto auto)
        {
            VermietungsNr = vermietungsNr;
            MietStart = mietStart;
            MietEnde = mietEnde;
            MietDauerInTagen = mietDauerInTagen;
            Kunde = kunde;
            Auto = auto;
        }

        public void AutoVermieten(int vermietungsNr, int mietDauerInTagen, Kunde kunde, Auto auto)
        {
            VermietungsNr = vermietungsNr;
            MietStart = DateTime.Now;
            MietDauerInTagen = mietDauerInTagen;
            Kunde = kunde;
            Auto = auto;
        }

        public DateTime AutoRueckgabe()
        {
            MietEnde = DateTime.Now;
            return MietEnde;
        }

        public void MietdauerErhohen(int mietDauerInTagen)
        {
            MietDauerInTagen += mietDauerInTagen;
        }

        public double BerechnePreisMitTagen()
        {
            return Auto.GetMietPreis() * MietDauerInTagen;
        }

        public double BerechnePreisMitDateTime()
        {
            TimeSpan Differenz = MietEnde - MietStart;
            return Differenz.Days * Auto.GetMietPreis();
        }

    }
}
