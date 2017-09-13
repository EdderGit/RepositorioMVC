using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Paralelismo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dtInicio = DateTime.Now;

            for (int i = 0; i < 1000000; i++)
            {
                int tmp = i;
                Task t = Task.Factory.StartNew(() => MetodoProceso(tmp));
            }

            DateTime fin = DateTime.Now;
            TimeSpan diff = fin - dtInicio;

            Console.WriteLine("Inicio = {0} - Fin = {1} - Diferencias = {2}:{3}:{4}.{5}", 
                                                                                        dtInicio.ToString("yyyy/MM/dd HH:mm:ss.ffffff") , 
                                                                                        fin.ToString("yyyy/MM/dd HH:mm:ss.ffffff"),diff.Hours, diff.Minutes,diff.Seconds,diff.Milliseconds );

            Console.ReadKey();
        }


        static void MetodoProceso( int i )
        {
            for (int j = 0; j < 100000; j++)
            {
                double d = 45345/6546*7989/0.2254;
            }
        }
    }
}
