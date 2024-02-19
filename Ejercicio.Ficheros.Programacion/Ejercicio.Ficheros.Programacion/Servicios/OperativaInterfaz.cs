using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Ficheros.Programacion.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo encargado de mostrar al empleado las opciones que puede hacer
        /// </summary>
        public void funcionesEmpleado();


        /// <summary>
        /// Metodo encargado de mostrar al usuario las opciones que puede hacer, y realizar los llamamientos a la Operativas necesarias
        /// </summary>
        public void funcionesCliente();


        /// <summary>
        /// Metodo encargado de solicitar al cliente sus datos, los cuales compondran a un nuevo cliente
        /// </summary>
        public void registroCliente();


        /// <summary>
        /// Metodo Encargado de comprobar si el cliente existe y ha sido validado
        /// </summary>
        public void accesoCliente();

        /// <summary>
        /// Metodo encargado de validar a un cliente si el campo "esvalidado", esta en false
        /// </summary>
        public void validarCliente();

        /// <summary>
        /// Metodo encargado de mostrar al usuario todos los clientes
        /// </summary>
        public void mostrarClientes();

        /// <summary>
        /// Metodo encargado de solicitar al usuario el dni a eliminar, y eliminarlo
        /// </summary>
        public void eliminarCliente();






    }
}
