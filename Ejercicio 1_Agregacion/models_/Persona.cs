using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Agregacion
{
    public class Persona
    {
        public int DNI { get; }
        public string Nombre;

        public Persona(int dni, string nombre) // dni luego de asignarse en el constructor no se puede modificar
        {
            DNI = dni;
            Nombre = nombre;
        }

        public string Describir()
        {

        }

    }

}
