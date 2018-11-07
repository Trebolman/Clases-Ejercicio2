using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_Clases_Ejercicio2.Clases
{
    class Cliente:Persona
    {
        public string telefono { get; set; }    
        public Cliente(string nombre, DateTime fNac, string telefono)
        :base(nombre, fNac){
            this.telefono = telefono;
        }
    }
}
