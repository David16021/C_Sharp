using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public delegate void AvisaLinea(int valor);
    public class clsRepositorioDelegado
    {
        public event AvisaLinea ReportaAvance;

        public void ObtenTodos()
        {
            for (int i = 0; i<100; i++)
            {
                Thread.Sleep(250);
                ReportaAvance(i + 1);
            }
        }
    }
}
