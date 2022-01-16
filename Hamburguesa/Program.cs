// debido a un error del git, nos vimos a la necesidad de colocar el codigo manualmente
using System;
using System.Collections.Generic;
namespace NEGOCIO_DE_HAMBURGUESAS
{
    class Program
    {
        static void Main(string[] args)
        {
            String elegir;
            List<Pedidos> ListaPedidos = new List<Pedidos>();
            List<Cliente> ListaCliente = new List<Cliente>();
            List<Factura> ListaFactura = new List<Factura>();
            Console.Clear();
            Console.WriteLine("*NEGOCIO DE HAMBURGUESAS*" + "\n 1.Pedidos" + "\n 2.Cliente" + "\n 3.Factura" + "\n 4.Salir");
            elegir = Console.ReadLine();
            Menu_Ventas Elegir = new Menu_Ventas();
            while (!elegir.Equals("4"))
            {
                switch (elegir)
                {
                    case "1":
                        Elegir.IngresarPedidos(ListaPedidos, ListaCliente, ListaFactura);
                        break;
                    case "2":
                        Elegir.IngresarCliente(ListaPedidos, ListaCliente, ListaFactura);
                        break;
                    case "3":
                        Elegir.IngresarFactura(ListaPedidos, ListaCliente, ListaFactura);
                        break;
                }
                if (!elegir.Equals("4"))
                {
                    Console.Clear();
                    Console.WriteLine("-----Menu Ventas Negocio de Hamburguesas-----" + "\n 1.Pedidos" + "\n 2.Cliente" + "\n 3.Factura" + "\n 4.Salir");
                    elegir = Console.ReadLine();
                }
                else
                {
                    elegir = "4";
                }
            }


        }
    }
}

