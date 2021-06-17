using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch3Ex2
{
    public partial class Date : Form
    {
        public Date()
        {
            InitializeComponent();
        }

        private long md(long x, long y)
        {
            long r;
            r = x % y;

            while (r != 0)
            {
                x = y;
                y = r;
                r = x % y;
            }
            return y;
        }

        private void btnProb_Click(object sender, EventArgs e)
        {
                long p, i, r, h1, h2, mt;

            try
            {
                h1 = (long)nudh1.Value;
                h2 = (long)nudh2.Value;
                mt = (long)nudhmx.Value;

                if (h1 > h2)
                {
                    i = (h1 - h2) * 60;

                    r = (i * i);

                    p = r - ((i - mt) * (i - mt));

                    rtbResults.Text = $"A possibilidade é de {p / md(p, r)}/{r / md(p, r)}";
                }

                else
                {
                    i = (h2 - h1) * 60;

                    r = (i * i);

                    p = r - ((i - mt) * (i - mt));

                    rtbResults.Text = $"A possibilidade é de {p / md(p, r)}/{r / md(p, r)}";
                }

            }
            catch 
            {

                MessageBox.Show("Ops! Só funciona com horas diferentes :D");
            }
        }
    }
}
