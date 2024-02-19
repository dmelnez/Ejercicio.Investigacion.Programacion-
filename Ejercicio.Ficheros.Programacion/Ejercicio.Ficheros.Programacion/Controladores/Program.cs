using Ejercicio.Ficheros.Programacion.Servicios;

namespace Ejercicio.Ficheros.Programacion.Controladores
{

    class Program
    {
        public static void Main(string[] args)
        {

         

            MenuInterfaz me = new MenuImplementacion();
            OperativaInterfaz op = new OperativaImplementacion();


            bool cerrarAplicacion = false;

            do
            {
               

                switch (me.menuPrincipal())
                {

                    case 0:
                        Console.WriteLine("CIERRE DE LA APLICACION");
                        cerrarAplicacion = true;
                        break;


                    case 1:
                        op.funcionesEmpleado();
                        break;

                    case 2:
                        op.funcionesCliente();
                        break;

                    default:
                        Console.WriteLine("SELECCION NO VALIDA");
                        break;




                }

            }

            while (!cerrarAplicacion);














        }
    }


}

