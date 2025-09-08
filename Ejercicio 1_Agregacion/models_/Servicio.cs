using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            if (_personas.Count > 0) 
            { 
            return _personas[n];
            }

            return null;
        }

        public Persona VerPersonaPorDNI(int dni)
        {
            foreach(Persona p in _personas)
            {
                if (dni==p.DNI)
                    return p;
            }
            return null; 
        }

        public void EliminarPersona(Persona persona)//REVISAR ACA _ LLEGA BIEN EL OBJETO EN EL PARAMETRO
            //REHACER LA LOGICA PARA BORRAr
        {
            foreach(Persona p in _personas)
            {
                if (p.DNI == persona.DNI) 
                { 
                    _personas.Remove(p);
                }
            }
        }

    }

}
