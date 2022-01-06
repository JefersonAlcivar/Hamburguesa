//debido a un error del git, nos vimos la necesidad de subir el codigo manuelamente 
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
            
            return ListaFacturas;
        }
        //facturas menores a diez
        public void MostrarFacturasMenores(List<Factura> ListaFacturas, List<Pedidos> ListaPedidos)
        {

        }
    }
}
