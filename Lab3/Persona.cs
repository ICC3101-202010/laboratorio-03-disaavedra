using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Persona
    {
        public String rut, nombre, apellido, nacimiento, nacionalidad;

        public Persona(String rut, String nombre, String apellido, String nacimiento, String nacionalidad)
        {
            this.rut = rut;

            this.nombre = nombre;

            this.apellido = apellido;

            this.nacimiento = nacimiento;

            this.nacionalidad = nacionalidad;
        }
    }
}
