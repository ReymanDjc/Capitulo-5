using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularBotton_Click(object sender, EventArgs e)
        {
            int digiteNumero, factorial = 1;

            digiteNumero = int.Parse(DigiteNumerotextBox1.Text);

            for (int x = 1; x < digiteNumero + 1; x++)
            {
                factorial = factorial * x;
            }
            FactorialtextBox2.Text = factorial.ToString();
        }
    }
}
