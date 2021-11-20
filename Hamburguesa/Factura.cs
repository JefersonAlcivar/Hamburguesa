using System;
using System.Collections.Generic;
using System.Text;

namespace Hamburguesa
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
