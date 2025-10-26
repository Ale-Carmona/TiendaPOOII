using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPOOII
{
    internal class Producto
    {
        public Producto() { }
        public Producto(string nombre, double precio, int stock, string categoria)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Categoria = categoria;
        }

        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public string Categoria { get; set; }
    }
}
