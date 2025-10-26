using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPOOII
{
    internal interface IAcciones
    {
        bool AgregarProducto(ProductoElectonico producto);
        List <ProductoElectonico> MostrarProducto();
    }
}
