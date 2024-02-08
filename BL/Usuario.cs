using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        //public static Dictionary<string, object> GetByEmail(string Email)
        //{
        //    Dictionary<string, object> diccionario = new Dictionary<string, object> { { "Exepcion", "" }, { "Resultado", false }, { "Producto", null } };
        //    try
        //    {
        //        using (DL.AposadasMoviesContext context = new DL.AposadasMoviesContext())
        //        {
        //            var registro = (from usario in context.Usuarios
        //                            where usario.Email == Email
        //                            select new
        //                            {

        //                                Email = usario.Email,
        //                                Password = usario.Password,



        //                            }).FirstOrDefault();

        //            if (registro != null)
        //            {
        //                ML.Usuario user = new ML.Usuario();


        //                user.Email = registro.Email;
        //                user.Password = registro.Password;



        //                diccionario["Resultado"] = true;
        //                diccionario["Usuario"] = user;
        //            }
        //            else
        //            {

        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        diccionario["Exepcion"] = ex;
        //    }
        //    return diccionario;
        //}

        //public static Dictionary<string, object> Add(ML.Usuario usuario)

        //{
        //    Dictionary<string, object> diccionario = new Dictionary<string, object> { { "Exepcion", "" }, { "Resultado", false } };

        //    try
        //    {

        //        using (DL.AposadasMoviesContext context = new DL.AposadasMoviesContext())
        //        {

        //            var filasAfectadas = context.Database.ExecuteSqlRaw($"UsuarioAdd '{usuario.Nombre}','{usuario.ApellidoPaterno}','{usuario.ApellidoMaterno}','{usuario.Username}', '{usuario.Email}', '{usuario.Password}',  '{usuario.Rol.IdRol}');

        //            if (filasAfectadas > 0)
        //            {
        //                diccionario["Resultado"] = true;
        //            }
        //            else
        //            {
        //                diccionario["Resultado"] = false;
        //            }
        //        }
        //    }

        //    catch (Exception ex)//fallo algo
        //    {
        //        diccionario["Resultado"] = false;
        //        diccionario["Exepcion"] = ex.Message;
        //    }
        //    return diccionario;
        //}
    }
}
