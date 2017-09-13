using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Paralelismo
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre  { get; set; }
        public int Edad       { get; set; }




        public static List<Empleado> ObtenerEmpleado(int n)
        {
            Random r = new Random( Guid.NewGuid().GetHashCode() );

            List<Empleado> empleados = new List<Empleado>();

            for (int i = 0; i < n; i++)
            {
                empleados.Add(new Empleado
                {
                    IdEmpleado = i,
                    Nombre = string.Format("Empleado {0}" , i),
                    Edad = r.Next(20 , 80)
                });
            }
            return empleados;
        }
    }
}
