using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Trabajador : Persona
    {
        public String puesto, sueldo, horario;

        

        public Trabajador(String rutTrabajador, String nombreTrabajador, String apellidoTrabajador, String nacimientoTrabajador, String nacionalidadTrabajador) : base(rutTrabajador, nombreTrabajador, apellidoTrabajador, nacimientoTrabajador, nacionalidadTrabajador)
        {
            //
        }

        public void DatosTrabajo(String puesto, String sueldo, String horario)
        {
            this.puesto = puesto;

            this.sueldo = sueldo;

            this.horario = horario;
        }


    }
}
