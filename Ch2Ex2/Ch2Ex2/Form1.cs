using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch2Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int divisores = 0;
            double n = (double)nudNum.Value;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    divisores++;
                    break;
                }
            }
            if (divisores == 0)
            {
                rctResultados.Text = $"{n} é um número primo\n";
            }
            else
                rctResultados.Text = $"{n} não é um número primo\n";

 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
