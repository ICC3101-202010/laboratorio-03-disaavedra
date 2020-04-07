using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Supervisor
    {
        public List<List<String>> listaDatosPersonalesSupervisor = new List<List<String>>();

        public List<List<String>> listaDatosProfesionalesSupervisor = new List<List<String>>();

        public Supervisor()
        {
            //
        }

        public void DatosPersonalesSupervisor(Trabajador trabajador)
        {
            List<String> listaDatosPersonales = new List<String>();

            listaDatosPersonales.Add(trabajador.rut);

            listaDatosPersonales.Add(trabajador.nombre);

            listaDatosPersonales.Add(trabajador.apellido);

            listaDatosPersonales.Add(trabajador.nacimiento);

            listaDatosPersonales.Add(trabajador.nacionalidad);

            listaDatosPersonalesSupervisor.Add(listaDatosPersonales);
        }

        public void DatosProfesionalesSupervisor(Trabajador trabajador)
        {
            List<String> listaDatosProfesionales = new List<String>();

            listaDatosProfesionales.Add(trabajador.rut);

            listaDatosProfesionales.Add(trabajador.puesto);

            listaDatosProfesionales.Add(trabajador.sueldo);

            listaDatosProfesionales.Add(trabajador.horario);

            listaDatosProfesionalesSupervisor.Add(listaDatosProfesionales);
        }

        public void informacionSupervisores()
        {
            int contador = 0;

            foreach (var i in listaDatosPersonalesSupervisor)
            {
                Console.WriteLine($"\nEL supervisor numero {contador + 1} es " + i[1]);

                Console.WriteLine("\nRut: " + i[0] + "\nNombre: " + i[1] + "\nApellido: " + i[2] + "\nNacimiento: " + i[3] + "\nNacionalidad: " + i[4]);

                Console.WriteLine("Puesto: " + listaDatosProfesionalesSupervisor[contador][1] + "\nSueldo: " + listaDatosProfesionalesSupervisor[contador][2] + "\nHorario: " + listaDatosProfesionalesSupervisor[contador][3]);

                contador++;
            }
           
        }
    }
}
