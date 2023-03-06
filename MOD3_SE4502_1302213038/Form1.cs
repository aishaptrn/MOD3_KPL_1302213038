using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD3_SE4502_1302213038
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.numA = " ";
            this.numB = " ";
        }

        string num, numA, numB;
        int numC, numD;

        private void button1_Click(object sender, EventArgs e)
        {
            this.numA = this.labOutput.Text;
            this.labOutput.Text = "";
            Refresh();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            num = "0";
            this.labOutput.Text = num;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            num = "1";
            this.labOutput.Text = num;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            num = "2";
            this.labOutput.Text = num;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            num = "3";
            this.labOutput.Text = num;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            num = "4";
            this.labOutput.Text = num;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            num = "5";
            this.labOutput.Text = num;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            num = "6";
            this.labOutput.Text = num;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            num = "7";
            this.labOutput.Text = num;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            num = "8";
            this.labOutput.Text = num;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            num = "9";
            this.labOutput.Text = num;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            this.numB = this.labOutput.Text;
            this.labOutput.Text = "";
            Refresh();
            numC = int.Parse(numA);
            numD = int.Parse(numB);
        }
    }
}
