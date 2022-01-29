using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaPedidos;

namespace ProyectoPedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int opcion;
                ControlPedidos.CrearPedido();
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Seleccionar el cliente");
                    Console.WriteLine("2. Agregar producto al pedido");
                    Console.WriteLine("3. Eliminar producto al pedido");
                    Console.WriteLine("4. Mostrar pedido");
                    Console.WriteLine("0. Salir.");
                    opcion = Convert.ToInt32((string)Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            ControlPedidos.SeleccionaCliente();
                            break;
                        case 2:
                            ControlPedidos.AgregarProducto();
                            break;
                        case 3:
                            ControlPedidos.EliminarProductoPedido();
                            break;
                        case 4:
                            Console.WriteLine(ControlPedidos.MuestraPedido());
                            Console.ReadKey();
                            break;

                        default:
                            break;
                    }
                } while (opcion != 0);
            }catch (Exception ex)
            {
                Console.WriteLine("Ups..! Ocurrió una exepción: "+ex.Message);
            }
        }
    }
}
