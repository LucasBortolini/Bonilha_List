using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ch3Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private long modulo( long @base, long e, long mod)
        {
            long x = 1;
            long y = @base;

            while (e > 0)
            {
                if (e % 2 == 1)
                {
                    x = (x * y) % mod;
                }
                y = (y * y) % mod;
                e = e / 2;
            }
            return x % mod;
        }

        private bool Fermat(long m, int it)
        {
            Random r = new Random();
            if (m == 1)
            {
                return false;
            }
            for (int i = 0; i < it; i++)
            {
                long x = r.Next() % (m - 1) + 1;
                if (modulo(x, m - 1, m) != 1)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnFermat_Click(object sender, EventArgs e)
        {
            int it = 70;
            long n = (long)nud1.Value;

            if (Fermat(n, it))
            {
                rtbResultado.Text = $"{n} é primo";
            }
            else
            {
                rtbResultado.Text = $"{n} não é primo";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

