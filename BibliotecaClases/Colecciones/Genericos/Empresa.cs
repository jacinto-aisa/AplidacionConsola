using BibliotecaClases.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Colecciones.Genericos
{
    public class Empresa (IRepositorioColeccionDiccionario? Repositorio): IEmpresa
    {
        public List<IElemento> elementos = [];
        public double CosteTotal { get; set; } = 0;
        public int NumeroElementos { get; set; } = 0;
        public void Add(IElemento elemento)
        {
            elementos.Add(elemento);
            NumeroElementos++;
            if (elemento is ICostable costable)
                CosteTotal += costable.Coste;
            if (elemento is IEmpleado empleado)
                CosteTotal +=empleado.SueldoNeto;
        }
        public IElemento? GetElemento(int id)
        {
            return elementos.Find(x => x.Id == id);
        }
        public void Delete(int id)
        {
            IElemento? elemento = GetElemento(id);
            if (elemento != null)
            {
                elementos.Remove(elemento);
                NumeroElementos--;
                if (elemento is ICostable costable)  
                    CosteTotal-=costable.Coste;
                if (elemento is IEmpleado empleado)
                    CosteTotal-=empleado.SueldoNeto;
            }
        }
        public void Grabar()
        {
            Repositorio?.GuardaLista(elementos);
        }
        public void Cargar()
        {
            List<IElemento>? lista = Repositorio?.DameLista();
            elementos = lista ?? [];
        }

    }
}
