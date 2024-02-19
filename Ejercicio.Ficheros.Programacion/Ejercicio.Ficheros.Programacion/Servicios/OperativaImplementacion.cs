using Ejercicio.Ficheros.Programacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Ficheros.Programacion.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        string rutaFichero = "log" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + ".txt";
        List<ClienteDtos> listaClientes = new List<ClienteDtos>();
        public void funcionesEmpleado()
        {

            MenuInterfaz me = new MenuImplementacion();


            switch (me.menuEmpleado())
            {

                case 0:
                    break;

                case 1:


                    using(StreamWriter sw = new StreamWriter(rutaFichero, true)) 
                    
                    {
                        sw.WriteLine("[EMPLEADO] - VALIDAR CLIENTE");
                    
                    }

                    Console.WriteLine("-----------------------");
                    Console.WriteLine("| VALIDAR A UN CLIENTE |");
                    Console.WriteLine("-----------------------");
                    validarCliente();
                    break;

                case 2:


                    using (StreamWriter sw = new StreamWriter(rutaFichero, true))

                    {
                        sw.WriteLine("[EMPLEADO] - ELIMINAR A UN CLINTE");

                    }

                    Console.WriteLine("------------------------");
                    Console.WriteLine("| ELIMINAR A UN CLIENTE |");
                    Console.WriteLine("------------------------");
                    eliminarCliente();
                    break;


                case 3:

                    using (StreamWriter sw = new StreamWriter(rutaFichero, true))

                    {
                        sw.WriteLine("[EMPLEADO] - MOSTRAR UN CLIENTE");

                    }
                    Console.WriteLine("----------------------");
                    Console.WriteLine("| MOSTRAR UN CLIENTE |");
                    Console.WriteLine("----------------------");
                    mostrarClientes();
                    break;
                default:
                   
                    break;


            }
        }


            public void funcionesCliente()
            {

                MenuInterfaz me = new MenuImplementacion();


                switch (me.menuCliente())
                {

                    case 0:
                        break;

                    case 1:

                    using (StreamWriter sw = new StreamWriter(rutaFichero, true))

                    {
                        sw.WriteLine("[CLIENTE] - REGISTRO CLIENTE");

                    }

                        Console.WriteLine("--------------------");
                        Console.WriteLine("| REGISTRO CLIENTE  |");
                        Console.WriteLine("--------------------");

                        registroCliente();

                    break;

                    case 2:

                    using (StreamWriter sw = new StreamWriter(rutaFichero, true))

                    {
                        sw.WriteLine("[CLIENTE] - ACCESO CLIENTE (LOGIN)");

                    }


                        Console.WriteLine("-------------------------");
                        Console.WriteLine("| ACCESO CLIENTE (LOGIN) |");
                        Console.WriteLine("-------------------------");
                         accesoCliente();
                    break;

                    default:
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("| SELECCION NO VALIDA |");
                        Console.WriteLine("-----------------------");
                    break;


                    
                }



            }


           public void registroCliente()
            {

            
            ClienteDtos cliente = new ClienteDtos();

      


            Console.WriteLine("DNI: ");
            cliente.DniCliente = Console.ReadLine();

            Console.WriteLine("NOMBRE COMPLETO: ");
            cliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("EMAIL: ");
            cliente.EmailCliente = Console.ReadLine();

            Console.WriteLine("CONTRASENIA: ");
            cliente.ContraseniaCliente = Console.ReadLine();



            if (listaClientes.Count == 0)
            {

                cliente.IdCliente = 1;

            }


            else
            {

                cliente.IdCliente = listaClientes[listaClientes.Count - 1].IdCliente +1;

            }


            listaClientes.Add(cliente);


            using (StreamWriter sw = new StreamWriter(rutaFichero, true))

            {
                sw.WriteLine("[CLIENTE] - NUEVO CLIENTE CREADO");

            }



        }


           public void accesoCliente()
            {

            Console.WriteLine("EMAIL: ");
            string email = Console.ReadLine();
            Console.WriteLine("CONTRASENIA: ");
            string contrasenia = Console.ReadLine();


            foreach (ClienteDtos cliente in listaClientes)
            {

               if( cliente.EmailCliente.Equals(email) && cliente.ContraseniaCliente.Equals(contrasenia))
               {

                  if (cliente.EsValidado == true)
                  {

                        using (StreamWriter sw = new StreamWriter(rutaFichero, true))

                        {
                            sw.WriteLine("[CLIENTE] - NUEVO INICIO DE SESION");
                            sw.WriteLine("CLIENTE INICIADO: " + cliente.NombreCliente);

                        }




                        Console.WriteLine("INICIO DE SESION CORRECTO");
                  }

                  else
                  {

                        Console.WriteLine("EL CIENTE NO HA SIDO VALIDADO");
                  }


                }


            }



           }


           public void validarCliente()
            {

            foreach(ClienteDtos cliente in listaClientes)
            {

                if(cliente.EsValidado == false)
                {
                    Console.WriteLine("\\\\\\\\\\\\\\\\\\\\");
                    Console.WriteLine(cliente.DniCliente + " - " + cliente.NombreCliente);
                    Console.WriteLine("\\\\\\\\\\\\\\\\\\\\");
                }

            }


            Console.WriteLine("DNI CLIENTE A VALIDAR: ");
            string dniAValidar = Console.ReadLine();

            foreach(ClienteDtos cliente in listaClientes)
            {

                if (cliente.DniCliente.Equals(dniAValidar))
                {

                    cliente.EsValidado = true;
                    Console.WriteLine("CLIENTE VALIDADO CORRECTAMENTE");





                    using (StreamWriter sw = new StreamWriter(rutaFichero, true))

                    {
                        sw.WriteLine("[EMPLEADO] - CLIENTE VALIDADO");
                        sw.WriteLine("CLIENTE VALIDADO: " + cliente.NombreCliente);

                    }

                }

            }




            }




         public void mostrarClientes()
         {


            foreach(ClienteDtos cliente in listaClientes)
            {

                Console.WriteLine("%%%%%%%%%%");
                Console.WriteLine("DNI: " + cliente.DniCliente);
                Console.WriteLine(cliente.IdCliente);
                Console.WriteLine("NOMBRE: " + cliente.NombreCliente);
                if(cliente.EsValidado == true)
                {
                   Console.WriteLine("ESTADO VALIDACION: si" );
                   Console.WriteLine("%%%%%%%%%%");
                }

                else
                {
                    Console.WriteLine("ESTADO VALIDACION: no");
                    Console.WriteLine("%%%%%%%%%%");


                }
                



            }



        }


        public void eliminarCliente()
        {

            Console.WriteLine("DNI DEL CLIENTE A ELIMINAR: ");
            string dniAEliminar = Console.ReadLine();

            foreach(ClienteDtos cliente in listaClientes)
            {

                if (cliente.DniCliente.Equals(dniAEliminar) == true)
                {

                    listaClientes.Remove(cliente);

                    using (StreamWriter sw = new StreamWriter(rutaFichero, true))

                    {
                        sw.WriteLine("[EMPLEADO] - CLIENTE ELIMINADO CON EXITO");
                        sw.WriteLine("CLIENTE ELIMINADO: " + cliente.NombreCliente);

                    }




                    break;
                }


               

            }



        }



      
    }
}
