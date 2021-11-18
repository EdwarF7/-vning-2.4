using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._4
{
    public partial class Form1 : Form
    {
        List<Figur> figurer = new List<Figur>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkapaTriangel_Click(object sender, EventArgs e)
        {
            float bredd;
            float höjd;
            bool breddOK = float.TryParse(tbxBredd.Text, out bredd);
            bool höjdOK = float.TryParse(tbxHöjd.Text, out höjd);

            if (breddOK && höjdOK)
            {
                Triangel t = new Triangel(bredd, höjd);
                figurer.Add(t);
                lbxFigurer.Items.Add(t.ToString());
            }
        }

        private void btnSkapaCirkel_Click(object sender, EventArgs e)
        {
            float bredd;
            float höjd;
            bool breddOK = float.TryParse(tbxBredd.Text, out bredd);
            bool höjdOK = float.TryParse(tbxHöjd.Text, out höjd);

            if (breddOK && höjdOK)
            {
                Cirkel c = new Cirkel(bredd, höjd);
                figurer.Add(c);
                lbxFigurer.Items.Add(c.ToString());
            }
        }

        private void btnSkapaLinje_Click(object sender, EventArgs e)
        {
            float bredd;
            float höjd;
            bool breddOK = float.TryParse(tbxBredd.Text, out bredd);
            bool höjdOK = float.TryParse(tbxHöjd.Text, out höjd);

            if (breddOK && höjdOK)
            {
                Linje l = new Linje(bredd, höjd);
                figurer.Add(l);
                lbxFigurer.Items.Add(l.ToString());
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            float summa = 0;

            foreach (Figur f in figurer)
            {
                if (f is Triangel)
                {
                    summa += (f as Triangel).BeräknaArea();
                }else if(f is Cirkel)
                {
                    summa += (f as Cirkel).BeräknaArea();
                }

            }

            tbxArea.Text = Math.Round(summa, 2).ToString()+ " m²";
        }
    }
}
