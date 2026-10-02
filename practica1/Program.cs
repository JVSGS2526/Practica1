namespace practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona juan = new Persona("juan", 23);


            bool esMayor = juan.EsMayorDeEdad();
            Console.WriteLine($"¿Es mayor de edad? {esMayor}");
        }
    }
}
