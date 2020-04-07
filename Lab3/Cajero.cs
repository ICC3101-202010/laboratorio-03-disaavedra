using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Cajero
    {
        public List<List<String>> listaDatosPersonalesCajero = new List<List<String>>();

        public List<List<String>> listaDatosProfesionalesCajero = new List<List<String>>();

        public Cajero()
        {
            //
        }

        public void DatosPersonalesAuxiliar(Trabajador trabajador)
        {
            List<String> listaDatosPersonales = new List<String>();

            listaDatosPersonales.Add(trabajador.rut);

            listaDatosPersonales.Add(trabajador.nombre);

            listaDatosPersonales.Add(trabajador.apellido);

            listaDatosPersonales.Add(trabajador.nacimiento);

            listaDatosPersonales.Add(trabajador.nacionalidad);

            listaDatosPersonalesCajero.Add(listaDatosPersonales);
        }

        public void DatosProfesionalesAuxiliar(Trabajador trabajador)
        {
            List<String> listaDatosProfesionales = new List<String>();

            listaDatosProfesionales.Add(trabajador.rut);

            listaDatosProfesionales.Add(trabajador.puesto);

            listaDatosProfesionales.Add(trabajador.sueldo);

            listaDatosProfesionales.Add(trabajador.horario);

            listaDatosProfesionalesCajero.Add(listaDatosProfesionales);
        }

        public void informacionCajero()
        {
            int contador = 0;

            foreach (var i in listaDatosPersonalesCajero)
            {
                Console.WriteLine($"\nEL Cajero numero {contador + 1} es " + i[1]);

                Console.WriteLine("\nRut: " + i[0] + "\nNombre: " + i[1] + "\nApellido: " + i[2] + "\nNacimiento: " + i[3] + "\nNacionalidad: " + i[4]);

                Console.WriteLine("Puesto: " + listaDatosProfesionalesCajero[contador][1] + "\nSueldo: " + listaDatosProfesionalesCajero[contador][2] + "\nHorario: " + listaDatosProfesionalesCajero[contador][3]);

                contador++;
            }

        }
    }
}
