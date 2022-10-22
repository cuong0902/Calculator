using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a + b;
            txtKQ.Text = c.ToString();
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (txtA.Text != String.Empty && txtB.Text != String.Empty)
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = a + b;
                txtKQ.Text = c.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Calculator c = new Calculator(a, b);
            txtKQ.Text = c.Execute("-").ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Calculator c = new Calculator(a, b);
            txtKQ.Text = c.Execute("+").ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Calculator c = new Calculator(a, b);
            txtKQ.Text = c.Execute("*").ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Calculator c = new Calculator(a, b);
            txtKQ.Text = c.Execute("/").ToString();
        }
    }
}
