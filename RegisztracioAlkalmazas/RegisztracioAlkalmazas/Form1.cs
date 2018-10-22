using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    MessageBox.Show("Már létezik ilyen hobbi.");
                }

            }
            else
            {
                MessageBox.Show("Nem adtál meg új hobbit.");
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
            string tesztMentes = "";
            if (tbNev.Text.ToString() != "" && dtpSzulDatum.Value.ToString() != szulDat && (rbFerfi.Checked == true || rbNo.Checked == true) && lbHobbik.SelectedItem != null)
            {
                tesztMentes += "Név: " + tbNev.Text.ToString() + "\nSzületési dátum:";
                string[] adat = dtpSzulDatum.Value.ToString().Split(' ');

                for (int i = 0; i < 3; i++)
                {
                    tesztMentes += " " + adat[i];
                }
                tesztMentes += "\nNem: ";
                if (rbFerfi.Checked == true)
                {
                    tesztMentes += "Férfi";
                }
                else
                {
                    tesztMentes += "Nő";
                }
                if (lbHobbik.Items.Count > 1)
                {
                    tesztMentes += "\nHobbik: " + lbHobbik.Items[0];
                    for (int i = 1; i < lbHobbik.Items.Count; i++)
                    {
                        tesztMentes += ", " + lbHobbik.Items[i];
                    }
                }
                tesztMentes += "\nKedvenc hobbi: " + lbHobbik.SelectedItem.ToString();
                MessageBox.Show("Sikeres mentés!\n" + tesztMentes);
            }
            else
            {
                MessageBox.Show("Valami nincs kitöltve.");
            }
        }
    }
}
