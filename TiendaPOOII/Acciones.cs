using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPOOII
{
    internal class Acciones : IAcciones
    {
        List<ProductoElectonico> productos = new List<ProductoElectonico>();
        public ProductoElectonico UltimoProducto { get; private set; }


        public bool AgregarProducto(ProductoElectonico producto)
        {
            try
            {
                productos.Add(producto);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string ObtenerTodosLosProductos()
        {
            if (productos.Count == 0)
                return "No hay productos registrados.";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" Lista de productos registrados:");

            foreach (var p in productos)
            {
                sb.AppendLine($"- Nombre: {p.Nombre}, Precio: {p.Precio}, Stock: {p.Stock}, Categoría: {p.Categoria}, Garantía: {p.Garantia}");
            }
            return sb.ToString();
        }


        public List<ProductoElectonico> MostrarProducto()
        {
            return productos;
        }
    }
}