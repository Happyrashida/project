using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bankName = comboBox1.Text;
            int timeInYear = Convert.ToInt32(textBox1.Text);
            float principleAmount = Convert.ToInt32(textBox2.Text);
            float total=0;
            if (bankName == "BRAC")
            {
                total = (6*principleAmount*timeInYear)/100;
            }
            else if(bankName== "EBL")
            {
                total = (7*principleAmount*timeInYear)/100;

            }
            else if (bankName == "HSBC")
            {
                total = (8*principleAmount*timeInYear)/100;
            }
            label5.Text = Convert.ToString(total);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
