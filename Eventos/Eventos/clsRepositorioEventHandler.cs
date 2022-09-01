using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class Argumentos : EventArgs
    {
        public int Valor { get; set; }
    }
    public class clsRepositorioEventHandler
    {
        public event EventHandler<Argumentos> ReportaAvance;
        public void ObtenTodos()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(250);
                ReportaAvance(this, new Argumentos { Valor = i + 1 });
            }
        }
    }

}
