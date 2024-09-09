using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Colecciones.Genericos
{
    [Serializable]
    public class Empleado : IElemento, ICostable, IEmpleado
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public double Coste { get; set; }
        public double SueldoNeto { get; set; }
    }
}
