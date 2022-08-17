using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPedidos
{
    public class ctrObtenProductos
    {
        private intRepositorioProductos repoProductos;
        public Dictionary<string, recProductos> Productos { get; set; }
        public ctrObtenProductos(intRepositorioProductos pRepoProductos)
        {
            repoProductos = pRepoProductos;
            Productos = new Dictionary<string, recProductos>();
        }

        public void obtenProductos()
        {
            Productos.Clear();
            Productos = repoProductos.ObtenTodos();
        }
        public bool ObtenProducto(string codigoBarras, out recProductos productos)
        {
            return Productos.TryGetValue(codigoBarras, out productos);
        }
    }
}
