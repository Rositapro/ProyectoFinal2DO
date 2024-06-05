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
        
     

        // Constructor sin parámetros
        public Persona()
        {
            Name = "";
            LastNameP = "";
            LastNameM = "";
            CURP = "";
        }

        // Constructor con parámetros
        public Persona(string name, string lastnamep, string lastnamem, string curp, int age, int hoursworked) :this()
        {
            Name = name;
            LastNameP = lastnamep;
            LastNameM = lastnamem;
            CURP = curp;
            Age = age;
            HoursWorked = hoursworked;
        }


      
        // Método estático 
        public static void ShowMessage()
        {
            MessageBox.Show("Good morning dear employee.");
        }


        public virtual string Saludate()
        {
            return "Hello " + Name;
        }
    }
}
