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
            var taskA = new Task( () => Console.WriteLine("Ejecutando desde la TaskA"));

            taskA.Start();

            Console.WriteLine("Lalamada del hijo principal");

            Console.ReadKey();

        }
    }
}
