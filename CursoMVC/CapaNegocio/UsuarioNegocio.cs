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

        private readonly IListarUsuario _lista;
        public void GetAllUsuario() { _lista.Listar(); }
    }
}
