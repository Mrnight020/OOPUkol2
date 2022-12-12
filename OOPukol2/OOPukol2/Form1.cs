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
        NakladniAuto noveauto;
        private void button1_Click(object sender, EventArgs e)
        {
            noveauto = new NakladniAuto(textBox1.Text,(short) numericUpDown3.Value);
            panel1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            noveauto.NalozNaklad((short)numericUpDown1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            noveauto.VylozNaklad((short)numericUpDown2.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(noveauto.ToString());
        }
    }
}
