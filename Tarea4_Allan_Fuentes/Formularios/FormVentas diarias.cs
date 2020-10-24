using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_Allan_Fuentes.Formularios
{
    public partial class FormVentas_diarias : Form
    {
        Clases.Validar v = new Clases.Validar();
        public FormVentas_diarias()
        {
            InitializeComponent();
        }

        private void listpre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {

            if (txtcodigo.Text.Trim().Length == 0)
            {
                string g = "Rellenen el campo de codigo";
                v.validar(g);
                return;
            }
            if (txtnombre.Text.Trim().Length == 0)
            {
                string g = "Rellenen el campo del nombre";
                v.validar(g);
                return;
            }
            if (txtruta.Text.Trim().Length == 0)
            {
                string g = "Rellenen el campo de la ruta";
                v.validar(g);
                return;
            }
            if (txtventas.Text.Trim().Length == 0)
            {
                string g = "Rellenen el campo de las ventas";
                v.validar(g);
                return;
            }
            if (Dtime.Value > DateTime.Today)
            {
                string g = "La fecha ingresada es mayor a la actual";
                v.validar(g);
                return;
            }


         
           
           

         

            Dventas.Rows.Add(txtcodigo.Text.Trim(), txtnombre.Text.Trim(), txtruta.Text.Trim(), Dtime.Text.Trim(), txtventas.Text.Trim());
            int s = 0;
           
            

            foreach (DataGridViewRow row in Dventas.Rows)
            {


                s += Convert.ToInt32(row.Cells["Cventa"].Value);

                Vto.Text = s.ToString();
            }
            double to = double.Parse(Vto.Text);
            double z = to * 0.05;
            Sp.Text = z.ToString("F");
            txtcodigo.Clear();
            txtnombre.Clear();
            txtruta.Clear();
            txtventas.Clear();
            txtcodigo.Focus();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            
            
            


        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtruta_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtventas_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            Dventas.Rows.Clear();
     
      
            Sp.Clear();
            Vto.Clear();
          
            return;


        }
    }
}
