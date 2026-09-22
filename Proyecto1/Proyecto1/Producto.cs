using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
        public string MostrarDatos()
        {
            return $"Nombre: {Nombre}, Precio: {Precio}";
        }
    }
}
