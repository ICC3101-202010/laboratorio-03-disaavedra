using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Auxiliar
    {
        public List<List<String>> listaDatosPersonalesAuxiliar = new List<List<String>>();

        public List<List<String>> listaDatosProfesionalesAuxiliar = new List<List<String>>();

        public Auxiliar()
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

            listaDatosPersonalesAuxiliar.Add(listaDatosPersonales);
        }

        public void DatosProfesionalesAuxiliar(Trabajador trabajador)
        {
            List<String> listaDatosProfesionales = new List<String>();

            listaDatosProfesionales.Add(trabajador.rut);

            listaDatosProfesionales.Add(trabajador.puesto);

            listaDatosProfesionales.Add(trabajador.sueldo);

            listaDatosProfesionales.Add(trabajador.horario);

            listaDatosProfesionalesAuxiliar.Add(listaDatosProfesionales);
        }

        public void informacionAuxiliar()
        {
            int contador = 0;

            foreach (var i in listaDatosPersonalesAuxiliar)
            {
                Console.WriteLine($"\nEL Auxiliar numero {contador + 1} es " + i[1]);

                Console.WriteLine("\nRut: " + i[0] + "\nNombre: " + i[1] + "\nApellido: " + i[2] + "\nNacimiento: " + i[3] + "\nNacionalidad: " + i[4]);

                Console.WriteLine("Puesto: " + listaDatosProfesionalesAuxiliar[contador][1] + "\nSueldo: " + listaDatosProfesionalesAuxiliar[contador][2] + "\nHorario: " + listaDatosProfesionalesAuxiliar[contador][3]);

                contador++;
            }

        }
    }
}
