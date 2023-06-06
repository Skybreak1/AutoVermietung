using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVermietung
{
    using System;

    internal class Vermietung
    {
        private int VermietungsNr;
        private DateTime MietStart;
        private DateTime MietEnde;
        private int MietdauerinTagen;
        private Kunde Kunde;
        private Auto Auto;

        public Vermietung(int vermietungsNr, DateTime mietStart, DateTime mietEnde, int mietdauerinTagen, Kunde kunde, Auto auto)
        {
            VermietungsNr = vermietungsNr;
            MietStart = DateTime.Now;
            MietEnde = mietEnde;
            MietdauerinTagen = mietdauerinTagen;
            Kunde = kunde;
            Auto = auto;
        }

        public void AutoVermieten(int vermietungsNr, int mietdauerinTagen, Kunde kunde, Auto auto)
        {
            VermietungsNr = vermietungsNr;
            MietdauerinTagen = mietdauerinTagen;
            Kunde = kunde;
            Auto = auto;
        }

        public DateTime AutoRückgabe()
        {
            MietEnde =DateTime.Now;
            return MietEnde;
        }

        public void MietdauerErhoehen(int mietdauerinTagen)
        {
            MietdauerinTagen += mietdauerinTagen;
        }

        public int GetVermietungsNr()
        {
            return VermietungsNr;
        }

        public DateTime GetDatumMietStart()
        {
            return MietStart;
        }

        public DateTime GetDatumMietEnde()
        {
            return MietEnde;
        }

        public int GetMietdauerinTagen()
        {
            return MietdauerinTagen;
        }

        public Kunde GetKunde()
        {
            return Kunde;
        }

        public Auto GetAuto()
        {
            return Auto;
        }

        public float BerechnePreismitTagen()
        {
            float preisProTag = 10.0f;
            float gesamtPreis = MietdauerinTagen * preisProTag;
            return gesamtPreis;
        }

        public float BerechnePreismitDateTime()
        {
            float preisProStunde = 5.0f;
            TimeSpan mietdauer = MietEnde - MietStart;
            float gesamtPreis = (float)mietdauer.TotalHours * preisProStunde;
            return gesamtPreis;
        }
    }

}
