using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch2Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double r = (double)nud1.Value;
            double d = (double)nud2.Value;
            int q = 0;

            while (r >= d)
            {
                r -= d;
                q++;

            }

            if (d == 0)
            {
                rtbResultados.Text = "Impossivel dividir por zero";
            }
            else
            {
                rtbResultados.Text = $"A divisão resulta em {q} e sobra {r}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

