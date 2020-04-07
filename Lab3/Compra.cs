using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Compra
    {
        private String fecha, hora;

        private List<String> listaCompra = new List<String>();

        // Agregar el objeto Persona que realizo la compra

        // Agregar el objeto Persona que realizo la venta

        public Compra()
        {
            //
        }

        public void AgregarAlCliente(Cliente cliente)
        {

        }

        public void AgregarAlCarro(Proveedor proveedor, String producto, int numero)
        {
            if (producto == "Dulce") 
            {
                listaCompra.Add(proveedor.listaDulces[numero][0]);
            }

            else if (producto == "Lacteos") 
            {
                listaCompra.Add(proveedor.listaLacteos[numero][0]);
            }

            else if (producto == "Carnes") 
            {
                listaCompra.Add(proveedor.listaCarnes[numero][0]);
            }

            else if (producto == "Verduras") 
            {
                listaCompra.Add(proveedor.listaVerduras[numero][0]);
            }

            else if (producto == "Frutas") 
            {
                listaCompra.Add(proveedor.listaFrutas[numero][0]);
            }

            else if (producto == "Carbohidratos") 
            {
                listaCompra.Add(proveedor.listaCarbohidratos[numero][0]);
            }

            else if (producto == "Limpieza") 
            {
                listaCompra.Add(proveedor.listaLimpieza[numero][0]);
            }
        }

        public void AgregarAlCajero(Cajero cajero)
        {
            //
        }
    }
}
