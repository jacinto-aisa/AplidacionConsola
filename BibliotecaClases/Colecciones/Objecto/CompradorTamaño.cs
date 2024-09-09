using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Colecciones.Objecto
{
    public class CompradorTamaño : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x != null && y != null)
                return ((Jarron)x).Tamaño - ((Jarron)y).Tamaño;
            else return 0;
        }
    }
}
