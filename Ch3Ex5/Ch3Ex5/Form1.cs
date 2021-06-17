using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch3Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private long Primo(long n)
        {
            long p = 1;

            for (long i = 2; i <= n / 2; ++i)
            {
                if (n % i == 0)
                {
                    p = 0;
                    break;
                }
            }
            return p;
        }
        private void btn1_Click_1(object sender, EventArgs e)
        {

            rtbResultados.Clear();

            long f = 0;
            long n = (long)nud1.Value;

            for (long i = 2; i <= n / 2; ++i)
            {
                if (Primo(i) == 1)
                {
                    if (Primo(n - i) == 1)
                    {
                        rtbResultados.AppendText($"{n} = {i} + {n - i}\n");
                        f = 1;
                    }
                }
            }
            if (f == 0)
            {
                rtbResultados.AppendText($"A soma de dois números primos não resultam em {n}\n");
            }


        }

        private void nud1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
