using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPOOII
{
    internal class ProductoElectonico: Producto
    {
        public ProductoElectonico() { }
        public ProductoElectonico(string nombre, double precio, int stock, string categoria, int  garantia)
            : base(nombre, precio, stock, categoria)
        {
            Garantia = garantia;
        }
        public int Garantia { get; set; }
    }
}
