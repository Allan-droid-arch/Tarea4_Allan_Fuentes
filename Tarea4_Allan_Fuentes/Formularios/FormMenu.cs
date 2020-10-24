using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_Allan_Fuentes.Fromularios
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSalarioextra sal = new FormSalarioextra();
            sal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FormNuevo_salario nu = new Formularios.FormNuevo_salario();
            nu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.FormVentas_diarias ven = new Formularios.FormVentas_diarias();
            ven.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.Formcuotamensual c = new Formularios.Formcuotamensual();
            c.ShowDialog();
        }
    }
}
