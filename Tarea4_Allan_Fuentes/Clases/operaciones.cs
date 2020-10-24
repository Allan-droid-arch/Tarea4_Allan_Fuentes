using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_Allan_Fuentes.Clases
{
    class operaciones
    {
        public double salario(double d, double h, double p)
        {
            double sala = h*p;
            double t = d*0.5;
            double tot = d - t;
            double tota = sala + tot;
            return tota;
        }
        public double sueld(double r, double g)
        {
            double au = g / 100;
            double to = r *au;
            double tot = to + r;
            return tot;

        }
       
    }
}
