using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if ((tb_gyart.Text is null) || (tb_tipus.Text is null) || (tb_rendsz.Text is null))
                {
                    MessageBox.Show("Nem töltöttél ki minden mezőt. Minden mezőt ki kell tölteni", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (tb_gyart.Text is null)
                    {
                        tb_gyart.Focus();
                    }
                    if (tb_rendsz.Text is null)
                    {
                        tb_rendsz.Focus();
                    }
                    if (tb_tipus.Text is null)
                    {
                        tb_tipus.Focus();
                    }
            }
            if (cb_teljesitmeny.SelectedItem == null)
            {
                MessageBox.Show("Nem választottad ki a teljesítményt", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Kocsi kocsi = new Kocsi(tb_gyart.Text, tb_tipus.Text, tb_rendsz, cb_teljesitmeny.SelectedItem.ToString());
            lib_1.Items.Add(kocsi);
        }

        private void lib_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kocsi kocsi = (Kocsi)lib_1.Items[lib_1.SelectedIndex];
            tb_gyart.Text = kocsi.Gyártmány;
            tb_tipus.Text = kocsi.Tipus;
            tb_rendsz = kocsi.Rendszám;
            cb_teljesitmeny.SelectedItem = kocsi.Teljesítmény;
        }
    }
}
