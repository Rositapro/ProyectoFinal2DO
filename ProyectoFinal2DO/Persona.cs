using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal2DO
{
    internal class Persona
    {
        // Propiedades
        public string Name { get; set; }
        public string LastNameP { get; set; }
        public string LastNameM { get; set; }
        public string CURP { get; set; }
        public int Age { get; set; }
        public int HoursWorked { get; set; }
        // Propiedad solo lectura
        public string Salary { get; set; }



        // Propiedad solo lectura
        public string Identificacion { get; }




        // Constructor sin parámetros
        public Persona()
        {
            Identificacion = Guid.NewGuid().ToString();
            Name = "";
            LastNameP = "";
            LastNameM = "";
            CURP = "";
            Salary = "";

        }

        // Constructor con parámetros
        public Persona(string nombre, string lastnamep, string lastnamem, string curp, int age, int hoursworked) : this()
        {
            Name = nombre;
            LastNameP = lastnamep;
            LastNameM = lastnamem;
            CURP = curp;
            Age = age;
            HoursWorked = hoursworked;
        }


        // Métodos
        // Método estático (si)
        public static void ShowMessage()
        {
            MessageBox.Show("Buenos dias estimado empleado.");
        }




    }
}
