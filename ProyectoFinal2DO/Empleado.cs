using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal2DO
{
    internal class Empleado : Persona
    {
        public string Puesto { get; set; }

        public Empleado() : base() 
        {
            Puesto = "";
               
        }

        public Empleado(string nombre, string lastnamep, string lastnamem, string curp, int age,int hoursworked, string puesto) : base(nombre, lastnamep, lastnamem, curp, age, hoursworked)
        {
            this.Puesto = puesto;
          
        }

        //Polimorfismo: Sobrescribir el método Saludar
        public virtual void Saludar()
        {
            MessageBox.Show($"Hola {Puesto} {Name}");
        }
    }
}
