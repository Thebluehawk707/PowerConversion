using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace PowerConversion
{

    
    public partial class Form1 : Form
    {
        [DllImport("PowerFunctions.dll")]
        public static extern double mW2dBm(double mW);
        [DllImport("PowerFunctions.dll")]
        public static extern double dBm2mW(double dBm);


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mW2dBm_Click(object sender, EventArgs e)
        {
            lbl_mW2dBm.Text = mW2dBm((double)ud_mW2dBm.Value).ToString("F4");
        }

        private void btn_dBm2mW_Click(object sender, EventArgs e)
        {
            lbl_dBm2mW.Text = dBm2mW((double)ud_dBm2mW.Value).ToString("F4");
        }

        private void ud_mW2dBm_ValueChanged(object sender, EventArgs e)
        {
            lbl_mW2dBm.Text = mW2dBm((double)ud_mW2dBm.Value).ToString("F4");
        }

        private void ud_dBm2mW_ValueChanged(object sender, EventArgs e)
        {
            lbl_dBm2mW.Text = dBm2mW((double)ud_dBm2mW.Value).ToString("F4");
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Point temp = new Point();
            temp.X = this.ClientSize.Width / 2  - BoxOfConversions.Width / 2;
            temp.Y = this.ClientSize.Height / 2 - BoxOfConversions.Height / 2;
            
            BoxOfConversions.Location = temp;
        }

    }
}
