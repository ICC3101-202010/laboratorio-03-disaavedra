using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class TodoTrabajadores
    {
        public List<List<String>> listaTrabajadores = new List<List<String>>();

        public void ListaTrabajadores(Trabajador trabajador)
        {
            List<String> listaDatos = new List<String>();

            listaDatos.Add(trabajador.rut);

            listaDatos.Add(trabajador.nombre);

            listaDatos.Add(trabajador.apellido);

            listaDatos.Add(trabajador.nacimiento);

            listaDatos.Add(trabajador.nacionalidad);

            listaDatos.Add(trabajador.puesto);

            listaDatos.Add(trabajador.sueldo);

            listaDatos.Add(trabajador.horario);

            listaTrabajadores.Add(listaDatos);
        }
        public void InformacionTrabajo()
        {
            int contador = 0;

            foreach (var i in listaTrabajadores)
            {
                Console.WriteLine($"\nEL {i[5]} es " + i[1]);

                Console.WriteLine("\nRut: " + i[0] + "\nNombre: " + i[1] + "\nApellido: " + i[2] + "\nNacimiento: " + i[3] + "\nNacionalidad: " + i[4]);

                Console.WriteLine("Puesto: " + i[5] + "\nSueldo: " + i[6] + "\nHorario: " + i[7]);

                contador++;
            }

        }

        public void CambioTrabajo(String rut, String trabajoNuevo)
        {
            foreach (var i in listaTrabajadores)
            {
                if(i[0] == rut)
                {
                    i[5] = trabajoNuevo;
                }

            }
        }

        public void CambioSueldo(String rut, String sueldoNuevo)
        {
            foreach (var i in listaTrabajadores)
            {
                if (i[0] == rut)
                {
                    i[6] = sueldoNuevo;
                }

            }
        }

        public void CambioHorario(String rut, String horarioNuevo)
        {
            foreach (var i in listaTrabajadores)
            {
                if (i[0] == rut)
                {
                    i[7] = horarioNuevo;
                }

            }
        }
    }
}
