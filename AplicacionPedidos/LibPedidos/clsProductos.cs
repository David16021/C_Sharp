using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPedidos
{
    public class clsProductos
    {
        public int idProducto { get; set; }
        public string Descripcion { get; set; }
        public string CodigoBarras { get; set; }

        public override string ToString()
        {
            return $"idProducto: {idProducto.ToString()}" + 
                $"Descripcion:  {Descripcion} " +
                $"Codigo Barras: {CodigoBarras}";
        }
    }
}
