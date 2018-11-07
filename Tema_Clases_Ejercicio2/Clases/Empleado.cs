using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_Clases_Ejercicio2.Clases
{
    class Empleado:Persona
    {
        public double sueldo { set; get; }
        
        //Primer constructor: Empleado con sueldo
        public Empleado(string nombre, DateTime fNac, double sueldo)
        :base(nombre, fNac){
            this.sueldo = sueldo;
        }
        //Segundo constructor: Empleado sin sueldo
        public Empleado(string nombre, DateTime fNac)
        : base(nombre, fNac)
        {
            
        }
        public void AsignarSueldo(double sueldo)
        {
            this.sueldo = sueldo;
        }
    }
}
