using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_1_Agregacion
{
    public class Servicio
    {
        public Servicio()
        {
        }

        public List<Persona> _personas = new List<Persona>();

        public bool AgregarPersona(Persona nueva)
        {
            if (nueva != null && nueva.DNI>0)
            { 
                foreach (Persona p in _personas) 
                {
                    if (p.DNI == nueva.DNI)
                    return false;
                }
                _personas.Add(nueva);
                return true;
              
            }
                return false;
        }

        public int VerCantidadPersonas()
        {
            int cant = _personas.Count;
            return cant;
        }

        public Persona VerPersona(int n)
        {
           if (n>0 && n < _personas.Count)
            {
                return _personas[n];
            }
           return null;
        }

        public Persona VerPersonaPorDNI(int dni)
        {
            int idx = -1; // sentinela
            int n = 0;
            while (idx == -1 && n < _personas.Count)
            {
                if (_personas[n].DNI == dni)
                {
                    idx = n; // guardo
                }
                n++;
            }

            if (idx > -1)
                return _personas[idx];
            else
                return null;
        }
        

        public void EliminarPersona(Persona persona)
        {
            Persona encontrada = VerPersonaPorDNI(persona.DNI);

            if (encontrada != null)
            {
                _personas.Remove(persona);
            }
            
        }

       

    }

}
