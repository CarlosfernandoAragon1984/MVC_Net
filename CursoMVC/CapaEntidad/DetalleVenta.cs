using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public Venta IdVenta { get; set; }
        public Producto IdProducot { get; set; }
        public int Cantidad { get; set; }
        public decimal Total  { get; set; }
    }
}
