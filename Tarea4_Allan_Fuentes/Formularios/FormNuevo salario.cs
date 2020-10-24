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
    public partial class FormNuevo_salario : Form
    {
        Clases.operaciones t = new Clases.operaciones();
        public FormNuevo_salario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void FormNuevo_salario_Load(object sender, EventArgs e)
        {

        }

        private void aumento_MouseLeave(object sender, EventArgs e)
        {
            ToolTip tooltip1 = new ToolTip();
            tooltip1.ShowAlways = true;
            tooltip1.SetToolTip(this.aumento, "Ingrese numeros enteros");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(Sueldo.Text.Trim());
            double d = Convert.ToDouble(aumento.Text.Trim());
            pago.Text = t.sueld(c, d).ToString();
        }
    }
}
