using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPedidos
{
    public class clsRepositorioArchivoProductos : intRepositorioProductos
    {
        public string NombreArchivo { get; set; }

        public clsRepositorioArchivoProductos(string nombreArchivo)
        {
            NombreArchivo = nombreArchivo;
        }

        public Dictionary<string, recProductos> ObtenTodos()
        {
            TextReader txtReader;
            string linea;
            Dictionary<string, recProductos> Produtos = new Dictionary<string, recProductos>();
            //if (File.Exists(NombreArchivo))
            //{
            try
            {
                using (txtReader = new StreamReader(NombreArchivo))
                {
                    do
                    {
                        linea = txtReader.ReadLine();
                        if (linea != null)
                        {
                            string[] campos = linea.Split(',');
                            Produtos.Add(campos[2], new recProductos(
                                Convert.ToInt32(campos[0]), campos[1], campos[2]));
                        }
                    } while (linea != null);
                    txtReader.Close();
                }
                //}
                return Produtos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
