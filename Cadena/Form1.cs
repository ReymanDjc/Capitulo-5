using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cadena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickButton_Click(object sender, EventArgs e)
        {
            int digiteNumero;
            digiteNumero = int.Parse(DigiteNumerotextBox1.Text);
            if (digiteNumero == 1)
            {
                RegresaPalabratextBox1.Text = "Juan Jose";

            }
            else if (digiteNumero == 2)
            {
                RegresaPalabratextBox1.Text = "Danilo Medina";
            }
            else if (digiteNumero == 3)
            {
                RegresaPalabratextBox1.Text = "Juana Medina";
            }
            else if (digiteNumero == 4)
            {
                RegresaPalabratextBox1.Text = "Danilo Sanchez";
            }
            else if (digiteNumero > 4)
            {
                RegresaPalabratextBox1.Text = "ya no hay mas Palabra solo cuatro Palabra";
            }
        }
    }
}
