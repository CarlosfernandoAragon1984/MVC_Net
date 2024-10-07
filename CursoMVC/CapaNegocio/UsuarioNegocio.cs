using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using CapaNegocio.Interfaces;

namespace CapaNegocio
{
    public class UsuarioNegocio
    {
       IListarUsuario lista = new ListarUsuario();
        public void GetAllUsuario() { lista.Listar(); }
    }
}
