using System;
using System.Collections.Generic;

namespace NEGOCIO_DE_HAMBURGUESAS
{  //El patrón utilizado que es Single responsability la cual indica que cada clase solo tiene una razón de ser 
   //la cual nos permite agregar funciones a futuro sin reestructurar el código fuente.
    class Pedidos : Menu_Ventas
    {
        public String Cedula { get; set; }
        public String Nombre { get; set; }
        public String Hamburguesa { get; set; }
        public String Tamaño { get; set; }
        public int Precio { get; set; }

        public List<Pedidos> EliminarPedido(List<Pedidos> ListaPedido, string cedula)
        {
            Pedidos eligepedido = new Pedidos();
            foreach (var item in ListaPedido)
            {
                if (item.Cedula.Equals(cedula))
                {
                    eligepedido = item;
                }
            }
            ListaPedido.Remove(eligepedido);
            return ListaPedido;

        }
        //EN ESTE APARTADO PODEMOS MODIFICAR LOS PEDIDOS
        public List<Pedidos> ModificarPedido(List<Pedidos> ListaPedido, string cedula, string nombre)
        {
            string h = "";
            int precio = 0;
            Pedidos modpedido = new Pedidos();
            foreach (var item in ListaPedido)
            {
                if (item.Cedula.Equals(cedula))
                {
                    modpedido = item;
                }
            }
            var indice = ListaPedido.IndexOf(modpedido);

            ListaPedido.RemoveAt(indice);
            modpedido.Cedula = cedula;
            modpedido.Nombre = nombre;
            Console.WriteLine("Seleccione el tipo de hamburguesa  \n 1. Especial  \n 2. Sencilla  \n 3. Completa  \n 4. Mega Hamburguesa");
            h = Console.ReadLine();
            switch (h)
            {
                case "1":
                    h = "Especial";
                    break;

                case "2":
                    h = "Sencilla";
                    break;

                case "3":
                    h = "Completa";
                    break;

                case "4":
                    h = "Mega Hamburguesa";
                    break;

                default:
                    break;
            }
            modpedido.Hamburguesa = h;
            Console.WriteLine("Seleccione su acompañante \n 1. Papas francesas  \n 2. Ensalada  \n 3. Nuggets");
            h = Console.ReadLine();
            switch (h)
            {
                case "1":
                    h = "Papas francesas";
                    precio = precio + 3;
                    break;

                case "2":
                    h = "Ensalada";
                    precio = precio + 1;
                    break;

                case "3":
                    h = "Nuggets";
                    precio = precio + 5;
                    break;

                default:
                    break;
            }
            modpedido.Tamaño = h;
            modpedido.Precio = precio;
            ListaPedido.Insert(indice, modpedido);
            return ListaPedido;
        }
        //METODO CREAR LOS PEDIDOS
        public Pedidos CrearPedidos(List<Pedidos> ListaPedidos, string Cedula, string Nombre)
        {
            string ingreso = "";
            bool op = true;
            Pedidos nuevopedi = new Pedidos();
            nuevopedi.Cedula = Cedula;
            nuevopedi.Nombre = Nombre;
            while (op)
            {
                Console.WriteLine("Seleccione el tipo de hamburguesa  \n 1. Especial  \n 2. Sencilla  \n 3. Completa  \n 4. Mega Hamburguesa");
                ingreso = Console.ReadLine();
                switch (ingreso)
                {
                    case "1":
                        ingreso = "Especial";
                        op = false;
                        break;

                    case "2":
                        ingreso = "Sencilla";
                        op = false;
                        break;

                    case "3":
                        ingreso = "Completa";
                        op = false;
                        break;

                    case "4":
                        ingreso = "Mega Hamburgesa";
                        op = false;
                        break;

                    default:
                        Console.WriteLine("Solo hay 4 tipos de hamburguesas, intentelo de nuevo");
                        op = true;
                        break;
                        
                }
            
            }
            return nuevopedi;
        }
        // mostrar solo  las precios mayores o iguales a diez de los pedidos
        public void MostrarPedidosMayores(List<Pedidos> ListaPedidos)
        {
        
        }

        public int validar(List<Pedidos> ListaPedidos, string Cedula)
        {
            int x = 1, f = 0;
            foreach (var item in ListaPedidos)
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
    }

}
