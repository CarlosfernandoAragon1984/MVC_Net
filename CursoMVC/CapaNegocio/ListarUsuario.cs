using CapaDatos;
using CapaEntidad;
using CapaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ListarUsuario: IListarUsuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            Conexion datos = new Conexion();
            try
            {
                //datos.SetProsedimiento("spLista_Usurio");
                string consulta = "Select IdUsuario,Nombres,Apellidos,Correo,Clave,Restablecer,Activo from USUARIO";
                datos.SetConsulta(consulta);
                // datos.SetConsulta(consulta);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.IdUsuario = (int)datos.Lector["IdUsuario"];
                    if (!(datos.Lector["Nombres"] is DBNull))
                    {
                        aux.Nombre = (string)datos.Lector["Nombres"];
                    }
                    if (!(datos.Lector["Apellidos"] is DBNull))
                    {
                        aux.Apellido = (string)datos.Lector["Apellidos"];
                    }
                    if (!(datos.Lector["Correo"] is DBNull))
                    {
                        aux.Correo = (string)datos.Lector["Correo"];
                    }
                    if (!(datos.Lector["Clave"] is DBNull))
                    {
                        aux.Clave = (string)datos.Lector["Clave"];
                    }
                    if (!(datos.Lector["Restablecer"] is DBNull))
                    {
                        aux.Reestablecer = (bool)datos.Lector["Restablecer"];
                    }
                    if (!(datos.Lector["Activo"] is DBNull))
                    {
                        aux.Activo = (bool)datos.Lector["Activo"];
                    }
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
