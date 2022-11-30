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

        private void button1_Click(object sender, EventArgs e)
        {

            NakladniAuto noveauto = new NakladniAuto(textBox1.Text, (double)numericUpDown3.Value);

            noveauto.NalozNaklad((double)numericUpDown1.Value);
            MessageBox.Show(noveauto.ToString());
            noveauto.VylozNaklad((double)numericUpDown2.Value);

        }
    }
}
