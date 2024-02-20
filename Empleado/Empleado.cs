using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    internal class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Puesto { get; set; }
        private double salario;

        public Empleado(string nombre, int edad, string puesto)
        {
            Nombre = nombre;
            Edad = edad;
            Puesto = puesto;
            salario = 0;
        }

        public void EstablecerSalario(double nuevoSalario)
        {
            salario = nuevoSalario;
        }

       
        public double ObtenerSalario()
        {
            return salario;
        }
        public void ImprimirInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Puesto: {Puesto}");
            Console.WriteLine($"Salario: {salario:C}");
        }
    }
}
