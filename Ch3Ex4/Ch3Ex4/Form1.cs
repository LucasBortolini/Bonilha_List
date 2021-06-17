using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch3Ex4
{
    public partial class Pascal : Form
    {
        
        public Pascal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int l = (int)nudNumero.Value;
            int[,] m = new int[l, l];

            rtbResultados.Clear();

            for (int i = 0; i < l; i++)
            {
                m[i, 0] = 1;
            }

            for (int i = 0; i < l; i++)
            {
                m[i, i] = 1;
            }

            for (int i = 2; i < l; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    m[i, j] = m[i - 1, j] + m[i - 1, j - 1];
                }
            }
            for (int i = 0; i < l; i++)
            {
                string s = " ";
                for (int j = 0; j <= i; j++)
                {
                    s += m[i, j] + " ";
                }
                rtbResultados.AppendText(s + "\n");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
