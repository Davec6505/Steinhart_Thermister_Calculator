using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steinhart_Thermister_Calc
{
    public partial class Form1 : Form
    {
        public double KelT1 { get; set; }
        public double KelT2 { get; set; }
        public double KelT3 { get; set; }

        double[,] R_Polynomial =
        {
          {1.0,1.1,1.1 },
          {1.0,1.1,1.1 },
          {1.0,1.1,1.1 }
        };
        public Form1()
        {
            InitializeComponent();
            labelOhm.Text = "\u03a9";


        }


        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double temp = 0.0;


            //2nd expression of mateix
            if (double.TryParse(textBoxR1.Text, out temp))
            {
                R_Polynomial[0, 1] = Math.Log(temp);
            }

            if (double.TryParse(textBoxR2.Text, out temp))
            {
                R_Polynomial[1, 1] = Math.Log(temp);
            }

            if (double.TryParse(textBoxR1.Text, out temp))
            {
                R_Polynomial[2, 1] = Math.Log(temp);
            }

            //3rd exp of matrix
            if (double.TryParse(textBoxR1.Text, out temp))
            {
                temp = Math.Pow((Math.Log(temp)),3);
                R_Polynomial[0, 1] = temp;
            }

            if (double.TryParse(textBoxR2.Text, out temp))
            {
                temp = Math.Pow((Math.Log(temp)), 3);
                R_Polynomial[1, 1] = temp;
            }

            if (double.TryParse(textBoxR1.Text, out temp))
            {
                temp = Math.Pow((Math.Log(temp)), 3);
                R_Polynomial[2, 1] = temp;
            }

            //calculate kelvin

        }
    }
}
