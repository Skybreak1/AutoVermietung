namespace AutoVermietung
{
    public partial class Form1 : Form
    {
        List<Kunde> kunden = new List<Kunde>();
        List<Auto> autos = new List<Auto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AutoManagerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutoManager autoManager = new AutoManager();
            autoManager.ShowDialog(this);
            this.Show();
        }

        private void KundenManagerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            KundenManager kundenManager = new KundenManager(kunden);
            kundenManager.ShowDialog(this);
            this.Show();
        }

        private void Vermietungbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VermietungManager vermietungManager = new VermietungManager();
            vermietungManager.ShowDialog(this);
            this.Show();
        }

        private void ImportKunden()
        {
            kunden.Clear();
            StreamReader sr = new StreamReader("..\\..\\..\\Kunden.csv");
            while (!sr.EndOfStream)
            {
                string GesamtLine = sr.ReadLine();
                string[] Splitted = GesamtLine.Split(';');
                Kunde kundeTemp = new Kunde(Convert.ToInt32(Splitted[0]), Splitted[1], Splitted[2], Splitted[3], Convert.ToDateTime(Splitted[4]));
                kunden.Add(kundeTemp);
            }
            sr.Close();
            MessageBox.Show(kunden.Count + " Kunden Importiert", "Import fertig", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }


        private void ImportAutos()
        {
            autos.Clear();
            StreamReader sr = new StreamReader("..\\..\\..\\Autos.csv");
            while (!sr.EndOfStream)
            {
                string GesamtLine = sr.ReadLine();
                string[] Splitted = GesamtLine.Split(';');
                Auto autoTemp = new Auto(Convert.ToInt32(Splitted[0]), Splitted[1], Splitted[2], Convert.ToInt32(Splitted[3]), Splitted[4], Convert.ToDouble(Splitted[5]), Convert.ToBoolean(Splitted[6]));
                autos.Add(autoTemp);
            }
            sr.Close();
            MessageBox.Show(autos.Count + " Autos Importiert", "Import fertig", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportKunden();
            ImportAutos();
        }
    }
}