using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal2DO
{
    internal class Obrero : ITrabajador
    {
        public void Trabajar()
        {
            MessageBox.Show("El obrero está trabajando.");
        }
    }
}
