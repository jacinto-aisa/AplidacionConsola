using BibliotecaClases.Colecciones.Genericos;
using BibliotecaClases.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Colecciones.Diccionarios
{
    public class EmpresaConIds(IRepositorioDiccionario? Repositorio):IEmpresa
    {
        private Dictionary<int, IElemento> elementos = [];
        public double CosteTotal { get; set; }
        public int NumeroElementos { get; set; }
        public void Add(IElemento elemento)
        {
            elementos.Add(elemento.Id, elemento);
            NumeroElementos++;
            if (elemento is ICostable costable)
                CosteTotal += costable.Coste;
            if (elemento is IEmpleado empleado)
                CosteTotal += empleado.SueldoNeto;
        }
        public void Delete(int id)
        {
            IElemento? elemento = GetElemento(id);
            if (elemento != null)
            {
                elementos.Remove(id);
                NumeroElementos--;
                if (elemento is ICostable costable)
                    CosteTotal -= costable.Coste;
                if (elemento is IEmpleado empleado)
                    CosteTotal -= empleado.SueldoNeto;
            }
        }
        public IElemento? GetElemento(int id)
        {
           return elementos[id];
        }
        public void Grabar()
        {
            Repositorio?.GuardaLista(elementos);
        }
        public void Cargar()
        {
            elementos = Repositorio?.DameLista();
        }
    }
}
