using System;
using System.Collections.Generic;
using System.Linq;

namespace NEGOCIO_DE_HAMBURGUESAS
{
    class Factura
    {
        public String Cedula { get; set; }
        public String Nombre { get; set; }
        public String Hamburguesa { get; set; }
        public String Tamaño { get; set; }
        public int Precio { get; set; }
        //Mostrar las listas de facturas y pedidos
        public List<Factura> MostrarFacturas(List<Pedidos> ListaPedidos, List<Factura> ListaFacturas)
        {
            ListaFacturas.Clear();
            Factura facturero = new Factura();
            //Lamba con select para hacer el cambio
            IEnumerable<Pedidos> Listacambio = ListaPedidos.Select(x => x);
            foreach (var item in Listacambio)
            {

                facturero.Cedula = item.Cedula;
                facturero.Nombre = item.Nombre;
                facturero.Hamburguesa = item.Hamburguesa;
                facturero.Tamaño = item.Tamaño;
                facturero.Precio = item.Precio;
                ListaFacturas.Add(facturero);
            }

            //Lamba con select para mostrar el facturero
            IEnumerable<Pedidos> Listanombre = ListaPedidos.Select(x => x);
            foreach (var item in Listanombre)
            {
                Console.WriteLine(item.Cedula + "\t" + item.Nombre + "\t" + item.Hamburguesa + "\t" + item.Tamaño + "\t" + item.Precio);
            }
            Console.ReadKey();
            return ListaFacturas;
        }
        public void MostrarFacturasMenores(List<Factura> ListaFacturas, List<Pedidos> ListaPedidos)
        {
            //lamba con where para mostrar solo  las precios mayores o iguales a 10 de los pedidos
            IEnumerable<Pedidos> Consulta = ListaPedidos.Where(x => x.Precio < 10).Select(x => x);
            foreach (var item in Consulta)
            {
                Console.WriteLine(item.Cedula + "\t" + item.Nombre + "\t" + item.Precio);
            }
            Console.ReadKey();
        }
    }
}
