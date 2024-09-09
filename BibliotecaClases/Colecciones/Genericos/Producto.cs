using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Colecciones.Genericos
{
    [Serializable]
    public class Producto : IElemento, ICostable, IProducto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public double Coste { get; set; }
        public string DameEtiqueta()
        {
            return $"{Nombre} ({Id})";
        }
    }
}
