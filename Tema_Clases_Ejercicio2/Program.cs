using System;
using Tema_Clases_Ejercicio2.Clases;
namespace Tema_Clases_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Directivo directivo = new Directivo("Daniel Isaías Cabana", DateTime.Now, 2000, categorias.Gerente);
            Empresa empresa = new Empresa("CochesFast", "123456789", directivo);
            Empleado empleado = new Empleado("Empleado A", DateTime.Now, 1000);
            directivo.addSubordinado(empleado);
        }
    }
}
