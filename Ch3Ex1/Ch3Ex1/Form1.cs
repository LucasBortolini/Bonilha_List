using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch3Ex1
{
    public partial class Form1 : Form
    {
        
   
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i, j;
 
            int m = (int)nudM.Value; 
            int n = (int)nudN.Value;

            double m1 = 1;
            double n2 = 1;

            for (i = m; i > 0; --i)
            {
                m1 *= m;
                m--;
            }

            for (j = n; j > 0; --j)
            {
                n2 *= n;
                n--;
            }

            rtbResultados.Text = $"{m1 + n2}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
