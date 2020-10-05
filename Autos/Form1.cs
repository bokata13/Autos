using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Autos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            int errorcounter = 0;
            if ((String.IsNullOrEmpty(tb_gyart.Text)) || (String.IsNullOrEmpty(tb_rendsz.Text)) || (String.IsNullOrEmpty(tb_tipus.Text)))
            {
                MessageBox.Show("Nem töltöttél ki minden mezőt. Minden mezőt ki kell tölteni", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                if (String.IsNullOrEmpty(tb_gyart.Text))
                {
                    tb_gyart.Focus();
                    errorcounter++;
                }

                if (String.IsNullOrEmpty(tb_rendsz.Text))
                {
                    tb_rendsz.Focus();
                    errorcounter++;
                }
              

                if (String.IsNullOrEmpty(tb_tipus.Text))
                {
                    tb_tipus.Focus();
                    errorcounter++;
                }
            }
            
            if (!Regex.Match(tb_rendsz.Text, "^([A-Z]{3})([0-9]{3})$").Success)
            {
                tb_rendsz.Focus();
                MessageBox.Show("Nem megfelelő a renszám formátuma. A helyes formátum: ABC123", "Hibás adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorcounter++;
            }


            Kocsi kocsi = new Kocsi(tb_rendsz.Text, tb_gyart.Text, tb_tipus.Text, (int)numericUpDown1.Value);
            if (errorcounter == 0)
            {
                lib_1.Items.Add(kocsi);
            }
            else 
            {
                errorcounter = 0;
            }
             
        }

        private void lib_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kocsi kocsi = (Kocsi)lib_1.Items[lib_1.SelectedIndex];
            tb_gyart.Text = kocsi.Gyártmány;
            tb_tipus.Text = kocsi.Típus;
            tb_rendsz.Text = kocsi.Rendszám;
            numericUpDown1.Value = kocsi.Teljesítmény;
        }
    }
}
