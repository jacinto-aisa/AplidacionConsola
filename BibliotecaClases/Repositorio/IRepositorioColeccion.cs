using BibliotecaClases.Colecciones.Genericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Repositorio
{
    public interface IRepositorioColeccionDiccionario
    {
        List<IElemento>? DameLista();
        void GuardaLista(List<IElemento> lista);
    }
}
