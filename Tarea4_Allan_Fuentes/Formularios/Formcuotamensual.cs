using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_Allan_Fuentes.Formularios
{
    public partial class Formcuotamensual : Form
    {
        public Formcuotamensual()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rd.Checked)
            {
                double t = double.Parse(pre.Text.Trim());
                double to = t * 1.35;
                tot.Text = to.ToString();

            }
            else
            {
                double t = double.Parse(pre.Text.Trim());
                tot.Text = t.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nom.Clear();
            pre.Clear();
            tot.Clear();
            nom.Focus();
        }
    }
}
