using System;
using System.Collections.Generic;
namespace Hamburguesa
{
    class Pedidos : Menu_Ventas
    {
        public String Cedula { get; set; }
        public String Nombre { get; set; }
        public String Hamburguesa { get; set; }
        public String Tamaño { get; set; }
        public int Precio { get; set; }

        public List<Pedidos> EliminarPedido(List<Pedidos> ListaPedido, string cedula)
        {
            return ListaPedido;
        }
        //EN ESTE APARTADO PODEMOS MODIFICAR LOS PEDIDOS
        public List<Pedidos> ModificarPedido(List<Pedidos> ListaPedido, string cedula, string nombre)
        {
            return ListaPedido;
        }
        //METODO CREAR LOS PEDIDOS
        public Pedidos CrearPedidos(List<Pedidos> ListaPedidos, string Cedula, string Nombre)
        {
            
        }
        // mostrar solo  las precios mayores o iguales a diez de los pedidos
        public void MostrarPedidosMayores(List<Pedidos> ListaPedidos)
        {

        }

        public int validar(List<Pedidos> ListaPedidos, string Cedula)
        {

        }
    }

}
