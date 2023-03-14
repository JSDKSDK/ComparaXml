using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.MetodosGenericos
{
    public class MetodosGenericos
    {
        public void cabeceras()
        {
            Console.WriteLine("********************************************");
            Console.Title = "Analista de PDF";
            Console.WriteLine("********************************************");
           
        }
        public string CapturarTextoConsola()
        {
            String texto;
            texto = Console.ReadLine();
            return texto;
        }
    }
}
