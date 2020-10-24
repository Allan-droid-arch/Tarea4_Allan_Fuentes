using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_Allan_Fuentes.Fromularios
{
    public partial class FormSalarioextra : Form
    {
        Clases.operaciones t = new Clases.operaciones();
        public FormSalarioextra()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(salario.Text.Trim());
            double g = Convert.ToDouble(ext.Text.Trim());
            double i = Convert.ToDouble(horp.Text.Trim());

            Nuevo.Text= t.salario(f,g,i).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
