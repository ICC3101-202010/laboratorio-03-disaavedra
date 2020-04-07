using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{

    class Proveedor
    {
        public List<List<String>> listaDulces = new List<List<String>>();

        public List<List<String>> listaLacteos = new List<List<String>>();

        public List<List<String>> listaCarnes = new List<List<String>>();

        public List<List<String>> listaVerduras = new List<List<String>>();

        public List<List<String>> listaFrutas = new List<List<String>>();

        public List<List<String>> listaCarbohidratos = new List<List<String>>();

        public List<List<String>> listaLimpieza = new List<List<String>>();

        public Proveedor ()
        {
            //
        }

        public void metodoDulces(Producto producto)
        {
            List<String> listaMomentanea = new List<String>();

            listaMomentanea.Add(producto.nombre);

            listaMomentanea.Add(producto.marca);

            listaMomentanea.Add(producto.precio);

            listaMomentanea.Add(producto.stock);

            listaDulces.Add(listaMomentanea);
        }

        public void metodoLacteos(Producto producto)
        {
            List<String> listaMomentanea = new List<String>();

            listaMomentanea.Add(producto.nombre);

            listaMomentanea.Add(producto.marca);

            listaMomentanea.Add(producto.precio);

            listaMomentanea.Add(producto.stock);

            listaLacteos.Add(listaMomentanea);
        }

        public void metodoCarnes(Producto producto)
        {
            List<String> listaMomentanea = new List<String>();

            listaMomentanea.Add(producto.nombre);

            listaMomentanea.Add(producto.marca);

            listaMomentanea.Add(producto.precio);

            listaMomentanea.Add(producto.stock);

            listaCarnes.Add(listaMomentanea);
        }

        public void metodoVerduras(Producto producto)
        {
            List<String> listaMomentanea = new List<String>();

            listaMomentanea.Add(producto.nombre);

            listaMomentanea.Add(producto.marca);

            listaMomentanea.Add(producto.precio);

            listaMomentanea.Add(producto.stock);

            listaVerduras.Add(listaMomentanea);
        }

        public void metodoFrutas(Producto producto)
        {
            List<String> listaMomentanea = new List<String>();

            listaMomentanea.Add(producto.nombre);

            listaMomentanea.Add(producto.marca);

            listaMomentanea.Add(producto.precio);

            listaMomentanea.Add(producto.stock);

            listaFrutas.Add(listaMomentanea);
        }

        public void metodoCarbohidratos(Producto producto)
        {
            List<String> listaMomentanea = new List<String>();

            listaMomentanea.Add(producto.nombre);

            listaMomentanea.Add(producto.marca);

            listaMomentanea.Add(producto.precio);

            listaMomentanea.Add(producto.stock);

            listaCarbohidratos.Add(listaMomentanea);
        }

        public void metodoLimpieza(Producto producto)
        {
            List<String> listaMomentanea = new List<String>();

            listaMomentanea.Add(producto.nombre);

            listaMomentanea.Add(producto.marca);

            listaMomentanea.Add(producto.precio);

            listaMomentanea.Add(producto.stock);

            listaLimpieza.Add(listaMomentanea);
        }

        public void informacionDulces()
        {
            int contador = 0;

            foreach (var i in listaDulces)
            {
                Console.WriteLine($"\nEL codigo para agregar este producto es {contador} es ");

                Console.WriteLine("\nNombre: " + i[0] + "Marca: " + i[1] + "Precio: " + i[2] + "Stock: " + i[3]);

                contador++;
            }
        }

        public void informacionLacteos()
        {
            int contador = 0;

            foreach (var i in listaLacteos)
            {
                Console.WriteLine($"\nEL codigo para agregar este producto es {contador} es ");

                Console.WriteLine("\nNombre: " + i[0] + "Marca: " + i[1] + "Precio: " + i[2] + "Stock: " + i[3]);

                contador++;
            }
        }

        public void informacionCarnes()
        {
            int contador = 0;

            foreach (var i in listaCarnes)
            {
                Console.WriteLine($"\nEL codigo para agregar este producto es {contador} es ");

                Console.WriteLine("\nNombre: " + i[0] + "Marca: " + i[1] + "Precio: " + i[2] + "Stock: " + i[3]);

                contador++;
            }
        }

        public void informacionVerduras()
        {
            int contador = 0;

            foreach (var i in listaVerduras)
            {
                Console.WriteLine($"\nEL codigo para agregar este producto es {contador} es ");

                Console.WriteLine("\nNombre: " + i[0] + "Marca: " + i[1] + "Precio: " + i[2] + "Stock: " + i[3]);

                contador++;
            }
        }

        public void informacionFrutas()
        {
            int contador = 0;

            foreach (var i in listaFrutas)
            {
                Console.WriteLine($"\nEL codigo para agregar este producto es {contador} es ");

                Console.WriteLine("\nNombre: " + i[0] + "Marca: " + i[1] + "Precio: " + i[2] + "Stock: " + i[3]);

                contador++;
            }
        }

        public void informacionCarbohidratos()
        {
            int contador = 0;

            foreach (var i in listaCarbohidratos)
            {
                Console.WriteLine($"\nEL codigo para agregar este producto es {contador} es ");

                Console.WriteLine("\nNombre: " + i[0] + "Marca: " + i[1] + "Precio: " + i[2] + "Stock: " + i[3]);

                contador++;
            }
        }

        public void informacionLimpieza()
        {
            int contador = 0;

            foreach (var i in listaLimpieza)
            {
                Console.WriteLine($"\nEL codigo para agregar este producto es {contador} es ");

                Console.WriteLine("\nNombre: " + i[0] + "Marca: " + i[1] + "Precio: " + i[2] + "Stock: " + i[3]);

                contador++;
            }
        }
    }
}
