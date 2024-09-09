using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Colecciones.Objecto
{
    public class ComparadorTipo : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x != null && y != null)
                return ((Jarron)x).Tipo.CompareTo(((Jarron)y).Tipo);
            else return 0;
        }
    }
}
