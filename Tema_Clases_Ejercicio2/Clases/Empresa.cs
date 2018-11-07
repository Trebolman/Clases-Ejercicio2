using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_Clases_Ejercicio2.Clases
{
    class Empresa
    {
        public string nombre { get; set; }
        public string RUC { get; set; }
        public Directivo directivo;
        public List<Directivo> ListaDirectivos;
        public Empresa(string nombre, string RUC, Directivo directivo)
        {
            this.nombre = nombre;
            this.RUC = RUC;
            this.ListaDirectivos = new List<Directivo>();
            ListaDirectivos.Add(directivo); //Se agrega apenas se crea la empresa un directivo
        }
        public void addDirectivo(Directivo directivo)
        {
            ListaDirectivos.Add(directivo);
        }
    }
}
