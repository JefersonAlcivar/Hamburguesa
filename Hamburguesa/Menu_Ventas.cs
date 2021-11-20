using System;
using System.Collections.Generic;
namespace NEGOCIO_DE_HAMBURGUESAS
{
    class Menu_Ventas
    {
        //ingresar nuevos pedidos
        public List<Pedidos> IngresarPedidos(List<Pedidos> ListaPedidos, List<Cliente> ListaCliente, List<Factura> ListaFactura)
        {
            return (ListaPedidos);
        }
        //ingresar nuevos clientes
        public List<Cliente> IngresarCliente(List<Pedidos> ListaPedidos, List<Cliente> ListaCliente, List<Factura> ListaFactura)
        {
            return (ListaCliente);
        }
        //facturas
        public List<Factura> IngresarFactura(List<Pedidos> ListaPedidos, List<Cliente> ListaCliente, List<Factura> ListaFactura)
        {
            return (ListaFactura);
        }

    }
}