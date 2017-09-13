using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Paralelismo
{
    class Program
    {
        private static Dictionary<int, Empleado> _dictionary;

        static void Main(string[] args)
        {

            //MetodoTarea1();
            //MetodoTarea2()
              
            
            _dictionary = new Dictionary<int, Empleado>();
            _dictionary = Empleado.ObtenerEmpleado(100000).ToDictionary(p => p.IdEmpleado);

            IniciarConcurrencia();

            Console.WriteLine("Termino concurrencia");
            Console.ReadKey();
        }


        static void MetodoProceso( int i )
        {
            for (int j = 0; j < 100000; j++)
            {
                double d = 45345/6546*7989/0.2254;
            }
        }


        static void MetodoTarea1()
        {
            var taskA = new Task(() => Console.WriteLine("Ejecutando desde la TaskA"));

            taskA.Start();

            Console.WriteLine("Lalamada del hijo principal");

            Console.ReadKey();
        }

        static void MetodoTarea2()
        {
                    DateTime dtInicio = DateTime.Now;

            for (int i = 0; i < 100000; i++)
            {
                int tmp = i;
                Task t = Task.Factory.StartNew(() => MetodoProceso(tmp));
            }

            DateTime fin = DateTime.Now;
            TimeSpan diff = fin - dtInicio;

            Console.WriteLine("Inicio = {0} - Fin = {1} - Diferencias = {2}:{3}:{4}.{5}",
                                                                                        dtInicio.ToString("yyyy/MM/dd HH:mm:ss.ffffff"), fin.ToString("yyyy/MM/dd HH:mm:ss.ffffff"), diff.Hours, diff.Minutes, diff.Seconds, diff.Milliseconds);
                            
        }

        static void EliminarItem(int id)
        {
            if (_dictionary.ContainsKey(id) && _dictionary[id].Edad < 30) _dictionary.Remove(id);
        }

        static void ActualizarItem(int id)
        {
            if (_dictionary.ContainsKey(id)) _dictionary[id].Edad++;
        }

        static void IniciarConcurrencia()
        {
            for (int i = 0; i < 7000; i++)
            {
                Random r = new Random( Guid.NewGuid().GetHashCode());
                int id = r.Next(1, _dictionary.Count);
                Task.Factory.StartNew( () => EliminarItem(id));
                Task.Factory.StartNew( () => ActualizarItem(id));
                
            }
        }

    }
}
