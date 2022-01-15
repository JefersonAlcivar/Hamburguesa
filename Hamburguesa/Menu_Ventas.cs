using System;
using System.Collections.Generic;

// Con la ayuda del segundo principio del metodo SOLID (Open/Close) permite observar que al momento de querer modificar la clase no afecta
// a las otras clases que se encuentran rotundamente cerrados para una modificacion pero aun pueden crearse clases
// como extension y para despues agregarse en esta clase madre para ingresar y hacer todos los debidos adaptamientos
// al programa.
namespace NEGOCIO_DE_HAMBURGUESAS
{
    class Menu_Ventas
    {
        //ingresar nuevos pedidos
        public List<Pedidos> IngresarPedidos(List<Pedidos> ListaPedidos, List<Cliente> ListaCliente, List<Factura> ListaFactura)
        {

            Cliente verificacion = new Cliente();
            Boolean oc = true;
            string ingreso;
            while (oc)
            {
                Console.Clear();
                int c = 0, a = 0, f = 0;
                String nom = "";
                String elegir = "1";
                Boolean opp = true;
                Console.WriteLine("    Pedidos    ");
                Console.WriteLine("Cedula\tNombre");
                foreach (var item in ListaCliente)
                {
                    Console.WriteLine(item.Cedula + "\t" + item.Nombre);
                    c = c + 1;
                }

                if (c == 0)
                {
                    Console.WriteLine("No hay clientes en el sistema, por favor ingrese un cliente para poder continuar, presione enter para volver al menu");
                    Console.ReadLine();

                    while (opp)
                    {
                        Console.WriteLine(" 1.Ingresar Clientes" + "\n 2. Volver");
                        elegir = Console.ReadLine();
                        switch (elegir)
                        {
                            case "1":
                                Cliente nuevocliente = new Cliente();
                                nuevocliente = nuevocliente.CrearCliente(ListaCliente);
                                ListaCliente.Add(nuevocliente);
                                opp = false;
                                break;
                            case "2":
                                opp = false; oc = false;
                                break;
                            default:
                                Console.WriteLine("No existe esta opcion, por favor ingrese una valida");
                                opp = true;
                                break;
                        }
                    }
                }
                else
                {
                    while (opp)
                    {
                        Console.WriteLine("Cedula\tNombre\tHamburguesa\t\tTamaño\t\tPrecio");
                        foreach (var item in ListaPedidos)
                        {
                            Console.WriteLine(item.Cedula + "\t" + item.Nombre + "\t" + item.Hamburguesa + "\t" + item.Tamaño + "\t" + item.Precio);
                            a = a + 1;
                        }
                        if (a == 0)
                        {
                            Console.WriteLine(" 1. Ingresar Un Nuevo Pedido" + "\n 2. mostrar pedidos mayores a 10$" + "\n 3. Volver");
                            elegir = Console.ReadLine();
                            switch (elegir)
                            {
                                case "1":
                                    Pedidos nuevopedido = new Pedidos();
                                    foreach (var item in ListaCliente)
                                    {
                                        Console.WriteLine(item.Cedula + "\t" + item.Nombre);

                                    }
                                    Console.WriteLine("Ingrese la Cedula del Cliente");
                                    ingreso = Console.ReadLine();
                                    f = verificacion.validar(ListaCliente, ingreso);
                                    if (f == 1)
                                    {
                                        nom = verificacion.validarNom(ListaCliente, ingreso);
                                        nuevopedido = nuevopedido.CrearPedidos(ListaPedidos, ingreso, nom);
                                        ListaPedidos.Add(nuevopedido);
                                        opp = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No existe ese cliente dentro del registro, por favor ingrese una cedula que pertenezca a un cliente");
                                        opp = true;
                                    }
                                    break;
                                case "3":
                                    opp = false;
                                    oc = false;
                                    break;
                                case "2":
                                    Pedidos mosPedi = new Pedidos();
                                    mosPedi.MostrarPedidosMayores(ListaPedidos);
                                    opp = false;

                                    break;
                                default:
                                    Console.WriteLine("No existe esta opcion, por favor ingrese una valida");
                                    opp = true;
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine(" 1. Ingresar Un Nuevo Pedido" + "\n 2. Modificar Pedido" + "\n 3. Eliminar Pedido" + "\n 4. mostrar pedidos mayores a 10$" + "\n 5. Volver");
                            elegir = Console.ReadLine();
                            switch (elegir)
                            {
                                case "1":
                                    Pedidos nuevopedido = new Pedidos();
                                    foreach (var item in ListaCliente)
                                    {
                                        Console.WriteLine(item.Cedula + "\t" + item.Nombre);
                                    }
                                    Console.WriteLine("Ingrese la Cedula del Cliente");
                                    ingreso = Console.ReadLine();
                                    f = verificacion.validar(ListaCliente, ingreso);
                                    if (f == 1)
                                    {
                                        nom = verificacion.validarNom(ListaCliente, ingreso);
                                        nuevopedido = nuevopedido.CrearPedidos(ListaPedidos, ingreso, nom);
                                        ListaPedidos.Add(nuevopedido);
                                        opp = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No existe ese cliente dentro del registro, por favor ingrese una cedula que pertenezca a un cliente");
                                        opp = true;
                                    }
                                    break;
                                case "2":
                                    Pedidos modpedido = new Pedidos();
                                    foreach (var item in ListaCliente)
                                    {
                                        Console.WriteLine(item.Cedula + "\t" + item.Nombre);
                                    }
                                    Console.WriteLine("Ingrese la Cedula del Cliente del pedido a la cual quiere modificar");
                                    ingreso = Console.ReadLine();
                                    f = verificacion.validar(ListaCliente, ingreso);
                                    if (f == 1)
                                    {
                                        nom = verificacion.validarNom(ListaCliente, ingreso);
                                        modpedido.ModificarPedido(ListaPedidos, ingreso, nom);
                                        opp = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No existe ese cliente dentro del registro, por favor ingrese una cedula que pertenezca a un cliente");
                                        opp = true;
                                    }
                                    break;
                                case "3":
                                    Pedidos elipedido = new Pedidos();
                                    Console.WriteLine("Ingrese la Cedula del Cliente del pedido a la cual quiere eliminar");
                                    ingreso = Console.ReadLine();
                                    f = verificacion.validar(ListaCliente, ingreso);
                                    if (f == 1)
                                    {
                                        nom = verificacion.validarNom(ListaCliente, ingreso);
                                        elipedido.EliminarPedido(ListaPedidos, ingreso);
                                        opp = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No existe ese cliente dentro del registro, por favor ingrese una cedula que pertenezca a un cliente");
                                        opp = true;
                                    }
                                    break;
                                case "4":
                                    Pedidos mosPedi = new Pedidos();
                                    mosPedi.MostrarPedidosMayores(ListaPedidos);
                                    opp = false;
                                    break;
                                case "5":
                                    opp = false;
                                    oc = false;
                                    break;
                                default:
                                    Console.WriteLine("No existe esta opcion, por favor ingrese una valida");
                                    opp = true;
                                    break;
                            }
                        }

                    }
                }
            }
            return (ListaPedidos);
        }
        //ingresar nuevos clientes
        public List<Cliente> IngresarCliente(List<Pedidos> ListaPedidos, List<Cliente> ListaCliente, List<Factura> ListaFactura)
        {
            Cliente verificacion = new Cliente();
            Boolean oc = true;
            while (oc)
            {
                Console.Clear();
                int c = 0;
                String elegir = "1";
                Boolean opp = true;
                Console.WriteLine("    Clientes    ");
                Console.WriteLine("Cedula\tNombre");
                foreach (var item in ListaCliente)
                {
                    Console.WriteLine(item.Cedula + "\t" + item.Nombre);
                    c = c + 1;
                }

                if (c == 0)
                {
                    Console.WriteLine("No hay clientes en el sistema, por favor ingrese un cliente para poder continuar");
                    while (opp)
                    {
                        Console.WriteLine(" 1.Ingresar Clientes" + "\n 2. Volver");
                        elegir = Console.ReadLine();
                        switch (elegir)
                        {
                            case "1":
                                Cliente nuevocliente = new Cliente();
                                nuevocliente = nuevocliente.CrearCliente(ListaCliente);
                                ListaCliente.Add(nuevocliente);
                                opp = false;
                                break;
                            case "2":
                                opp = false; oc = false;
                                break;
                            default:
                                Console.WriteLine("No existe esta opcion, por favor ingrese una valida");
                                opp = true;
                                break;
                        }
                    }
                }
                else
                {
                    while (opp)
                    {
                        Console.WriteLine(" 1.Ingresar Clientes" + "\n 2. Modificar clientes" + "\n 3. Eliminar Cliente" + "\n 4. Mostrar Clientes" + "\n 5. Volver");
                        elegir = Console.ReadLine();
                        switch (elegir)
                        {
                            case "1":
                                Cliente nuevocliente = new Cliente();
                                nuevocliente = nuevocliente.CrearCliente(ListaCliente);
                                ListaCliente.Add(nuevocliente);
                                opp = false;
                                break;
                            case "2":
                                Cliente modcliente = new Cliente();
                                modcliente.ModificarCliente(ListaCliente);
                                opp = false;
                                break;
                            case "3":
                                Cliente elicliente = new Cliente();
                                elicliente.EliminarCliente(ListaCliente);
                                opp = false;
                                break;
                            case "4":
                                Cliente moscliente = new Cliente();
                                moscliente.MostrarClientes(ListaCliente);
                                opp = false;
                                break;
                            case "5":
                                opp = false; oc = false;
                                break;
                            default:
                                Console.WriteLine("No existe esta opcion, por favor ingrese una valida");
                                opp = true;
                                break;
                        }
                    }
                }
            }
            return (ListaCliente);

        }
        //facturas
        public List<Factura> IngresarFactura(List<Pedidos> ListaPedidos, List<Cliente> ListaCliente, List<Factura> ListaFactura)
        {
            Console.Clear();
            string elegir;
            Boolean oc = true;
            while (oc)
            {
                Console.WriteLine(" 1.Imprimir Facturero" + "\n 2. mostrar facturas menores a 10$" + "\n 3. Volver");
                elegir = Console.ReadLine();
                switch (elegir)
                {
                    case "1":
                        Factura facturero = new Factura();
                        facturero.MostrarFacturas(ListaPedidos, ListaFactura);
                        oc = false;
                        break;
                    case "2":
                        Factura mosFac = new Factura();
                        mosFac.MostrarFacturasMenores(ListaFactura, ListaPedidos);
                        oc = false;
                        break;
                    case "3":
                        oc = false;
                        break;
                    default:
                        Console.WriteLine("No existe esta opcion, por favor ingrese una valida");
                        oc = true;
                        break;
                }
            }
            return (ListaFactura);
        }
    }
}
