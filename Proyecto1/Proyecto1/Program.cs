using System;

namespace Proyecto1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona juan = new Persona("juan", 23);

            juan.CumplirAños();  

            bool esMayor = juan.EsMayorDeEdad();
            Console.WriteLine($"¿Es mayor de edad? {esMayor}");
        }
    }
}