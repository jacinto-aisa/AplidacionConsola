using BibliotecaClases.PolimorfismoConClases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Colecciones.Objecto
{
    public class ColeccionMixta (ArrayList elementos)
    {
        public int DameNumeroElementos()
        {
            return elementos.Count;
        }
        public int DameNumeroJarrones()
        {
            int num = 0;
            foreach (object i in elementos)
            {
                if (i is Jarron)
                    num++;
            }
            return num;
        }

        public int DameNumeroPersonas()
        {
            int num = 0;
            foreach (object i in elementos)
            {
                if (i is Persona)
                    num++;
            }
            return num;
        }

        public int DameEdadTotalPersonas()
        {
            int num = 0;
            foreach (object i in elementos)
            {
                if (i is not null && i is Persona persona)
                {
                    num += persona.Edad;
                }
            }
            return num;
        }
        public int DameTamañoSumadoJarron()
        {
            int num = 0;
            foreach (object i in elementos)
            {
                if (i is not null && i is Jarron jarron)
                {
                    num += jarron.Tamaño;
                }
            }
            return num;
        }
    }
}
