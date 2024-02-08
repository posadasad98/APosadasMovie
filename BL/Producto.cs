using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Producto
    {
        public static Dictionary<string, object> GetAll()
        {
            Dictionary<string, object> diccionario = new Dictionary<string, object> { { "Exepcion", "" }, { "Resultado", false }, { "Producto", null } };
            try
            {
                using (DL.AposadasMoviesContext context = new DL.AposadasMoviesContext())
                {

                    var registros = (from productos in context.Productos
                                     select new
                                     {
                                         IdProducto = productos.IdProducto,
                                         NombreProducto = productos.Nombre,
                                         Precio = productos.Precio,
                                         Stock = productos.Stock,
                                         IdProveedor = productos.IdProveedor,
                                         IdCategoria = productos.IdCategoria,
                                         Descripcion = productos.Descripcion,
                                         Imagen = productos.Imagen,
                                     }).ToList();



                    //DL.Usuario usuar = new DL.Usuario();
                    //var filasAfectadas = context.Usuarios.Add(usuar);
                    if (registros.Count > 0)
                    {
                        ML.Producto producto = new ML.Producto();
                        producto.Productos = new List<object>();
                        foreach (var registro in registros)
                        {
                            ML.Producto product = new ML.Producto();
                            product.IdProducto = registro.IdProducto;
                            product.NombreProducto = registro.NombreProducto;
                            product.Precio = (decimal)registro.Precio;
                            product.Stock = registro.Stock;
                            product.Proveedor = new ML.Proveedor();
                            product.Proveedor.IdProveedor = registro.IdProveedor;
                            product.Categoria = new ML.Categoria();
                            product.Categoria.IdCategoria = registro.IdCategoria;
                            product.Descripcion = registro.Descripcion;
                            product.Imagen = registro.Imagen;

                            producto.Productos.Add(product);
                        }
                        diccionario["Resultado"] = true;
                        diccionario["Producto"] = producto;
                    }
                    else
                    {

                    }
                }

            }
            catch (Exception ex)
            {
                diccionario["Exepcion"] = ex;
            }
            return diccionario;
        }
    }
}
