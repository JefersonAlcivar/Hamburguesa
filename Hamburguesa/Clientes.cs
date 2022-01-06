using System;
using System.Collections.Generic;
//
namespace NEGOCIO_DE_HAMBURGUESAS
{     //El patrón utilizado que es Single responsability la cual indica que cada clase solo tiene una razón de ser 
    //la cual nos permite agregar funciones a futuro sin reestructurar el código fuente.

    class Cliente : Menu_Ventas
    {
        public String Cedula { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Correo_Electronico { get; set; }

        //Single Responsability 
        //METODO PARA MOSTRAR LOS CLIENTES
        public void MostrarClientes(List<Cliente> ListaClientes)
        {

        }
        //METODO PARA ELIMINAR CLIENTES DE LA LISTA 
        public List<Cliente> EliminarCliente(List<Cliente> ListaCliente)
        {
            string ingreso = "";
            int f = 0;
            Boolean opp = true;
            Cliente elicliente = new Cliente();
            Cliente verificacion = new Cliente();
            while (opp)
            {
                Console.WriteLine("Ingrese la Cedula del Cliente");
                ingreso = Console.ReadLine();
                f = verificacion.validar(ListaCliente, ingreso);
                if (f == 1)
                {
                    foreach (var item in ListaCliente)
                    {
                        if (item.Cedula.Equals(ingreso))
                        {
                            elicliente = item;
                        }
                    }
                    ListaCliente.Remove(elicliente);
                    opp = false;
                }
                else
                {
                    Console.WriteLine("no existe ese cliente dentro del registro, por favor ingrese una cedula que pertenezca a un cliente");
                    opp = true;
                }
            }
            return ListaCliente;
        }
        //METODO PARA MODIFICAR DATOS DE NUESTROS CLIENTES
        public List<Cliente> ModificarCliente(List<Cliente> ListaCliente)
        {
            string h = "", ingreso = "";
            int f = 0;
            Boolean opp = true;
            Cliente verificacion = new Cliente();
            Cliente modcliente = new Cliente();
            while (opp)
            {
                Console.WriteLine("Ingrese la Cedula del Cliente");
                ingreso = Console.ReadLine();
                f = verificacion.validar(ListaCliente, ingreso);
                if (f == 1)
                {
                    foreach (var item in ListaCliente)
                    {
                        if (item.Cedula.Equals(ingreso))
                        {
                            modcliente = item;
                        }
                    }
                    var indice = ListaCliente.IndexOf(modcliente);
                    Console.WriteLine("Desea modificar la cedula? S/N");
                    h = Console.ReadLine();
                    if (h.Equals("S"))
                    {
                        Console.WriteLine("Ingrese la nueva cedula?");
                        ingreso = Console.ReadLine();
                        modcliente.Cedula = ingreso;
                    }
                    else
                    {
                        modcliente.Cedula = ingreso;
                    }
                    Console.WriteLine("Ingrese el Nombre del Cliente");
                    ingreso = Console.ReadLine();
                    modcliente.Nombre = ingreso;
                    Console.WriteLine("Ingrese la Direccion del Cliente");
                    ingreso = Console.ReadLine();
                    modcliente.Direccion = ingreso;
                    Console.WriteLine("Ingrese el Telefono del Cliente");
                    ingreso = Console.ReadLine();
                    modcliente.Telefono = ingreso;
                    Console.WriteLine("Ingrese el Correo Electronico del Cliente");
                    ingreso = Console.ReadLine();
                    modcliente.Correo_Electronico = ingreso;
                    ListaCliente.RemoveAt(indice);
                    ListaCliente.Insert(indice, modcliente);
                    opp = false;
                }
                else
                {
                    Console.WriteLine("no existe ese cliente dentro del registro, por favor ingrese una cedula que pertenezca a un cliente");
                    opp = true;
                }
            }
            return ListaCliente;
        }

        //CREAMOS O AÑADIMOS NUEVOS CLIENTES
        public Cliente CrearCliente(List<Cliente> ListaCliente)
        {
            int f;
            Cliente verificacion = new Cliente();
            Boolean opp = true;
            Cliente nuevocliente = new Cliente();
            while (opp)
            {
                Console.WriteLine("Ingrese la Cedula del Cliente");
                string ingreso = "";
                ingreso = Console.ReadLine();
                f = verificacion.validar(ListaCliente, ingreso);
                if (f == 1)
                {
                    Console.WriteLine("Existe ese cliente dentro del registro, por favor ingrese una cedula que no pertenezca a un cliente");
                    opp = true;
                }
                else
                {
                    nuevocliente.Cedula = ingreso;
                    Console.WriteLine("Ingrese el Nombre del Cliente");
                    ingreso = Console.ReadLine();
                    nuevocliente.Nombre = ingreso;
                    Console.WriteLine("Ingrese la Direccion del Cliente");
                    ingreso = Console.ReadLine();
                    nuevocliente.Direccion = ingreso;
                    Console.WriteLine("Ingrese el Telefono del Cliente");
                    ingreso = Console.ReadLine();
                    nuevocliente.Telefono = ingreso;
                    Console.WriteLine("Ingrese el Correo Electronico del Cliente");
                    ingreso = Console.ReadLine();
                    nuevocliente.Correo_Electronico = ingreso;
                    opp = false;
                }
            }
            return nuevocliente;
        }
        //METODOS PARA VALIDAR

        public int validar(List<Cliente> ListaCliente, string Cedula)
        {
            int x = 1, f = 0;
            foreach (var item in ListaCliente)
            {
                if (item.Cedula.Equals(Cedula))
                {
                    x = 1;
                }
                else
                {
                    x = 0;
                }
                if (x == 1)
                {
                    f = 1;
                }
            }
            return f;
        }
        // public String validarNom(List<Cliente> ListaCliente, string Cedula)

    }
}




