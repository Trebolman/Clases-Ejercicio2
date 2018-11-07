using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_Clases_Ejercicio2.Clases
{
    class Persona
    {
        //public string nombre;
        //public string fechaNacimiento;
        public string nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        //CONTRUCTOR
        public Persona(string nombre, DateTime fNac)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fNac;
        }
        public int calcEdad()
        {
            return DateTime.Now.Year - this.fechaNacimiento.Year;
        }
    }
}
