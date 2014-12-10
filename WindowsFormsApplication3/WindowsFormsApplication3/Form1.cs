using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void showTwoTimes_Click(object sender, EventArgs e)
        {
            double aNumber = Convert.ToDouble(aNumberText.Text);
            double result = aNumber*2;
            twoTimes.Text = result.ToString();
        }

        private double GetTwoTimes(double aNumber)
        {
            double result = aNumber*2;
            return result;
        }


    }
}
