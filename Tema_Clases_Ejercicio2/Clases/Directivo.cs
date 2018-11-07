using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_Clases_Ejercicio2.Clases
{
    class Directivo:Empleado
    {
        public categorias categoria;
        public List<Empleado> ListaEmpleados;
        public Directivo(string nombre, DateTime fNac, double sueldo, categorias categoria)
        :base(nombre, fNac, sueldo){
            this.categoria = categoria;
            this.ListaEmpleados = new List<Empleado>();
        }
        public Directivo(string nombre, DateTime fNac, categorias categoria)
        : base(nombre, fNac)
        {
            this.categoria = categoria;
            this.ListaEmpleados = new List<Empleado>();
        }
        public void addSubordinado(Empleado empleado)
        {
            this.ListaEmpleados.Add(empleado);
        }
    }
}
