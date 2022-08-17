using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPedidos
{
    public class clsRepositorioMemProductos
    {
        public Dictionary<string, recProductos> ObtenTodos()
        {
            Dictionary<string, recProductos> Productos =
                new Dictionary<string, recProductos>();
            Productos.Add("0001", new recProductos(1, "REF MANZANA 600 ML", "0001"));
            Productos.Add("0002", new recProductos(2, "DET COLOR 1 KG", "0002"));
            Productos.Add("0003", new recProductos(3, "LATA ATUN X 300 G", "0003"));
            Productos.Add("0004", new recProductos(4, "CREMA SOL 1 LT", "0004"));
            Productos.Add("0005", new recProductos(5, "REF NARANJA 2 L", "0005"));
            Productos.Add("0006", new recProductos(6, "ARROZ Z 1 KG", "0006"));
            Productos.Add("0007", new recProductos(7, "PALETA MIA 20 G", "0007"));
            return Productos;
        }

    }
}
