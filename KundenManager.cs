using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoVermietung
{
    public partial class KundenManager : Form
    {
        List<Kunde> kunden = new List<Kunde>();
        public KundenManager(List<Kunde> kunden)
        {
            InitializeComponent();
            this.kunden = kunden;
        }

        private void KundenManager_Load(object sender, EventArgs e)
        {
            foreach (Kunde kunde in kunden)
            {
                lbKunden.Items.Add(kunde.GetKundenNr() + ": " + kunde.GetName());
            }
        }

        private void lbKunden_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selektierterIndex = lbKunden.SelectedIndex;
            tbxAdresse.Text = kunden[selektierterIndex].GetAdresse();
            tbxKundenNr.Text = kunden[selektierterIndex].GetKundenNr().ToString();
            tbxAdresse.Text = kunden[selektierterIndex].GetAdresse().ToString();
            tbxKundeSeit.Text = kunden[selektierterIndex].GetKundeSeit().ToString();
            tbxVorname.Text = kunden[selektierterIndex].GetVorname();
            tbxNachname.Text = kunden[selektierterIndex].GetNachname();


        }
    }
}
