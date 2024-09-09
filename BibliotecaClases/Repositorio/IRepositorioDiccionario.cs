using BibliotecaClases.Colecciones.Genericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Repositorio
{
    public interface IRepositorioDiccionario
    {
        Dictionary<int,IElemento>? DameLista();
        void GuardaLista(Dictionary<int, IElemento> lista);
    }
}
