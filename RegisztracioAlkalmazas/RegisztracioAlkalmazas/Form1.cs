using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public string szulDat;

        public FormMain()
        {
            InitializeComponent();
            szulDat = dtpSzulDatum.Value.ToString();
        }

        private void btnUjHobbiAd_Click(object sender, EventArgs e)
        {
            if (tbUjHobbi.Text.ToString() != "")
            {
                if (VanEIlyenHobbi(tbUjHobbi.Text.ToString()) == false)
                {
                    lbHobbik.Items.Add(tbUjHobbi.Text.ToString());
                    tbUjHobbi.Text = "";
                }
                else
                {
                    MessageBox.Show("Már létezik ilyen hobbi.", "Hiba");
                }

            }
            else
            {
                MessageBox.Show("Nem adtál meg értéket a hobbi felvételéhez.", "Hiba");
            }
        }

        public bool VanEIlyenHobbi(string vanEIlyen)
        {
            int i = 0;
            bool igazE = false;
            while (lbHobbik.Items.Count > i && igazE == false)
            {
                if (lbHobbik.Items[i].ToString() == vanEIlyen)
                {
                    igazE = true;
                }
                i++;
            }
            return igazE;
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            Mentes();
        }

        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            Megnyitas();
        }

        public string KarakterKihagyo(string ebben, char ezt)
        {
            string visszaAd = "";

            for (int i = 0; i < ebben.Length; i++)
            {
                if (ebben[i] != ezt)
                {
                    visszaAd += ebben[i];
                }
            }
            return visszaAd;
        }

        public string CsakEgyKarakterKihagyo(string ebben, char ezt, int itt)
        {
            string visszaAd = "";
            if (ebben[itt] == ezt)
            {
                for (int i = 0; i < ebben.Length; i++)
                {
                    if (i != itt)
                    {
                        visszaAd += ebben[i];
                    }
                }
            }
            else
            {
                visszaAd += ebben;
            }
            return visszaAd;
        }

        public void Mentes()
        {
            string adatMentes = "";
            if (tbNev.Text.ToString() != "" && dtpSzulDatum.Value.ToString() != szulDat && (rbFerfi.Checked == true || rbNo.Checked == true) && lbHobbik.SelectedItem != null)
            {
                adatMentes += "Név: " + tbNev.Text.ToString() + "\nSzületési dátum:";
                string[] adat = dtpSzulDatum.Value.ToString().Split(' ');

                for (int i = 0; i < 3; i++)
                {
                    adatMentes += " " + adat[i];
                }
                adatMentes += "\nNem: ";
                if (rbFerfi.Checked == true)
                {
                    adatMentes += "Férfi";
                }
                else
                {
                    adatMentes += "Nő";
                }
                if (lbHobbik.Items.Count > 1)
                {
                    adatMentes += "\nHobbik: " + lbHobbik.Items[0];
                    for (int i = 1; i < lbHobbik.Items.Count; i++)
                    {
                        adatMentes += ", " + lbHobbik.Items[i];
                    }
                }
                adatMentes += "\nKedvenc hobbi: " + lbHobbik.SelectedItem.ToString();

                try
                {
                    if (saveFileDialog.ShowDialog(this)==DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, adatMentes);
                        MessageBox.Show("Sikeres mentés!\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba: " + ex, "Hiba");
                }
            }
            else
            {
                List<string> hianyok = new List<string>();
                if (tbNev.Text.ToString() == "")
                {
                    hianyok.Add("a nevet");
                }
                if (dtpSzulDatum.Value.ToString() == szulDat)
                {
                    hianyok.Add("a születési dátumot");
                }
                if (rbFerfi.Checked == false && rbNo.Checked == false)
                {
                    hianyok.Add("a nemet");
                }
                if (lbHobbik.SelectedItem == null)
                {
                    hianyok.Add("a hobbit");
                }

                string nincsKitoltve = "Nem adtad meg ";

                nincsKitoltve += hianyok[0];
                if (hianyok.Count > 2)
                {
                    for (int i = 1; i < hianyok.Count - 1; i++)
                    {
                        nincsKitoltve += ", " + hianyok[i];
                    }
                    nincsKitoltve += " és " + hianyok[hianyok.Count - 1];
                }
                else if (hianyok.Count == 2)
                {
                    nincsKitoltve += " és " + hianyok[1];
                }
                MessageBox.Show(nincsKitoltve + ".", "Hiba");
            }
        }

        public void Megnyitas()
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                //komponens értékek nullázása
                lbHobbik.Items.Clear();
                rbFerfi.Checked = false;
                rbNo.Checked = false;
                tbNev.Text = "";
                dtpSzulDatum.Value = DateTime.Now;
                //Betöltés
                List<string> adatok = new List<string>();
                try
                {
                    StreamReader beolvas = new StreamReader(openFileDialog.FileName);
                    while (!beolvas.EndOfStream)
                    {
                        string sor = beolvas.ReadLine();
                        try
                        {
                            string[] adat = sor.Split(':');
                            adatok.Add(adat[1]);
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("" + ex, "Hiba");
                            MessageBox.Show("Nem betölthető fájl!", "Hiba");
                            return;
                        }

                    }
                    beolvas.Close();

                    //BETÖLTÖTT ÉRTÉKEK FELDOLGOZÁSA
                    //név
                    tbNev.Text = CsakEgyKarakterKihagyo(adatok[0], ' ', 0);
                    //dátum
                    adatok[1] = KarakterKihagyo(adatok[1], ' ');
                    dtpSzulDatum.Value = DateTime.Parse(adatok[1]);
                    //nem
                    adatok[2] = CsakEgyKarakterKihagyo(adatok[2], ' ', 0);
                    if (adatok[2] == "Férfi")
                    {
                        rbFerfi.Checked = true;
                    }
                    else if (adatok[2] == "Nő")
                    {
                        rbNo.Checked = true;
                    }else
                    {
                        MessageBox.Show("Érvénytelen nem.", "Hiba");
                    }
                    //hobbik
                    string[] hobbik = adatok[3].Split(',');
                    for (int i = 0; i < hobbik.Length; i++)
                    {
                        hobbik[i] = CsakEgyKarakterKihagyo(hobbik[i], ' ', 0);
                        lbHobbik.Items.Add(hobbik[i]);
                    }
                    //kedvenchobbi
                    lbHobbik.SelectedItem = CsakEgyKarakterKihagyo(adatok[4], ' ', 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba: " + ex, "Hiba");
                }
            }
        }

    }
}
