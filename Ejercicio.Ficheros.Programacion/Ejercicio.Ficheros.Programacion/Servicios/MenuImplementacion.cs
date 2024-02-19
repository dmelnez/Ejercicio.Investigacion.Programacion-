using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Ficheros.Programacion.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuPrincipal()
      
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("| [0] -> Cerrar Aplicacion |");
            Console.WriteLine("| [1] -> Menu Empleado     |");
            Console.WriteLine("| [2] -> Menu Cliente      |");
            Console.WriteLine("----------------------------");
            int seleccionMenuPrincipal = Convert.ToInt32(Console.ReadLine());
            return seleccionMenuPrincipal;
        }

        public int menuEmpleado()
        {

            Console.WriteLine("-------------------------------");
            Console.WriteLine("| [0] -> Menu Principal       |");
            Console.WriteLine("| [1] -> Validar Cliente      |");
            Console.WriteLine("| [2] -> Eliminar Cliente     |");
            Console.WriteLine("| [3] -> Mostrar Cliente      |");
            Console.WriteLine("-------------------------------");
            int seleccionMenuEmpleado = Convert.ToInt32(Console.ReadLine());  
            return seleccionMenuEmpleado;
        }

        public int menuCliente()

        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("| [0] -> Menu Principal         |");
            Console.WriteLine("| [1] -> Registrase Cliente     |");
            Console.WriteLine("| [2] -> Acceso Cliente (LOGIN) |");
            Console.WriteLine("--------------------------------");
            int seleccionMenuCliente = Convert.ToInt32(Console.ReadLine());
            return seleccionMenuCliente;
        }
    }
}
