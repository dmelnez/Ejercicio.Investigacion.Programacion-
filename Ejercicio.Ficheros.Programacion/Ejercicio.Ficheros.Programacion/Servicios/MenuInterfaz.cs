using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Ficheros.Programacion.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo encargado de mostrar el Menu Principal de la Aplicacion
        /// </summary>
        /// <returns></returns>
        public int menuPrincipal();

        /// <summary>
        /// Metodo encargado de mostrar al usuario el Menu Empleado, y las opciones correspondientes a elegir por el mismo
        /// </summary>
        /// <returns></returns>
        public int menuEmpleado();

        /// <summary>
        /// Metodo encargado de mostrar al usuario el menu de Cliente
        /// </summary>
        /// <returns></returns>
        public int menuCliente();


    }
}
