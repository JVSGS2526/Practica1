using System;
using System.Collections.Generic;
using System.Text;

namespace practica1
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public string MostrarDatos()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}";
        }

        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }

    }
    

}
