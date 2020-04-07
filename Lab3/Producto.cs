using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Producto
    {
        public String nombre, marca, precio, stock;

        public Producto(String nombre, String marca, String precio, String stock)
        {
            this.nombre = nombre;

            this.marca = marca;

            this.precio = precio;

            this.stock = stock;
        }

        public void ComprobarStock()
        {
            //
        }
    }
}
