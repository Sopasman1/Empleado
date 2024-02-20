namespace Empleado
{


    internal class Program
    {
        static void Main(string[] args)
        {
            
            Empleado empleado1 = new Empleado("Juan", 30, "Desarrollador");

           
            empleado1.EstablecerSalario(30000);

            
            empleado1.ImprimirInformacion();

            
            Console.ReadLine();
        }
    }
}