using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Colecciones.Objecto
{
    public class ColeccionDeJarrones(ArrayList almacenJarrones, IComparer comparador) : IColeccionDeJarrones
    {
        public void Adjuntar(object obj) => almacenJarrones.Add(obj as Jarron);
        public void LimpiarColeccion() => almacenJarrones.Clear();
        public void Ordenar() => almacenJarrones.Sort(comparador);
        public bool ExisteJarron(object obj) => almacenJarrones.Contains(obj);
        public Object BuscaJarron(object obj,IComparer Comparador) => almacenJarrones.IndexOf(almacenJarrones.BinarySearch(obj,Comparador));
        public void Eliminar(object obj) => almacenJarrones.Remove(obj as Jarron);
    }
}
