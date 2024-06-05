using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal2DO
{
    internal class Empleado : Persona
    {
        //Propiedad de solo escritura
        public string Workstation { private get; set; }
        //Propiedad de lectura
        public double CalculatedSalary { get; }
        public string Salary { get; set; }



        public Empleado() : base() 
        {
            Workstation = "";
               
        }

        public Empleado(string name, string lastnamep, string lastnamem, string curp, int age,int hoursworked, string workstation) : base(name, lastnamep, lastnamem, curp, age, hoursworked)
        {
            this.Workstation = workstation;
            this.CalculatedSalary = CalculateSalary(workstation, hoursworked);

        }

        // Método que recibe y regresa
        private double CalculateSalary(string workstation, int hoursWorked)
        {
            // Definir las tarifas por hora para cada tipo de trabajo
            double engineerRate = 250;
            double workerRate = 100;

            // Calcular el salario en función del tipo de trabajo
            double salary = 0;
            if (workstation == "Engineer")
            {
                salary = engineerRate * hoursWorked;
            }
            else if (workstation == "Worker")
            {
                salary = workerRate * hoursWorked;
            }
            return salary;
        }

        //Polimorfismo: Sobrescribir el método Saludar
        //no recibe parametros pero regresa algo
        public override string Saludate()
        {
            return "Hello " +  Workstation + Name;
        }
    }
}
                                                                                                                                 