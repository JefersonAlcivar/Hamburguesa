using System;
using System.Collections.Generic;

namespace Hamburguesa
{
    class Cliente : Menu_Ventas
    {
        public String Cedula { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Correo_Electronico { get; set; }
        //METODO PARA MOSTRAR LOS CLIENTES
        public void MostrarClientes(List<Cliente> ListaClientes)
        {

        }
        //METODO PARA ELIMINAR CLIENTES DE LA LISTA 
        public List<Cliente> EliminarCliente(List<Cliente> ListaCliente)
        {

        }
        //METODO PARA MODIFICAR DATOS DE NUESTROS CLIENTES
        public List<Cliente> ModificarCliente(List<Cliente> ListaCliente)
        {
            return ListaCliente;
        }
        //CREAMOS O AÑADIMOS NUEVOS CLIENTES
        public Cliente CrearCliente(List<Cliente> ListaCliente)
        {
            //METODOS PARA VALIDAR
        }
        public int validar(List<Cliente> ListaCliente, string Cedula)
        {

        }
        public String validarNom(List<Cliente> ListaCliente, string Cedula)
        {
        
        }
    }
}
