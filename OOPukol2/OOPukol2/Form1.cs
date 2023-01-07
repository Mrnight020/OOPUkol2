using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPukol2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //NakladniAuto noveauto;
        Tahac novytahac;
        private void button1_Click(object sender, EventArgs e)
        {
            //noveauto = new NakladniAuto(textBox1.Text,(short) numericUpDown3.Value);
            novytahac = new Tahac(textBox1.Text, (short)numericUpDown3.Value,10);
            panel1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            novytahac.NalozNaklad((short)numericUpDown1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            novytahac.VylozNaklad((short)numericUpDown2.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {      
            MessageBox.Show(novytahac.ToString());
            MessageBox.Show("pókus :" + novytahac.Vrat());
        }
    }
}
