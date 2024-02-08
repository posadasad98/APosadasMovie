using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }
        public ML.Categoria Categoria { get; set; }
        public ML.Proveedor Proveedor { get; set; }
        public List<object> Productos { get; set; }

    }
}
