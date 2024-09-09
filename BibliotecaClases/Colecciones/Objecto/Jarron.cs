using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Colecciones.Objecto
{
    public class Jarron
    {
        public required string Tipo { set; get; }
        public required int Tamaño { set; get; }
        public required string Color { set; get; }
        public override bool Equals(Object? obj)
        {
            Jarron? recibido = obj as Jarron;
            return this.Tipo == recibido?.Tipo
                   && this.Tamaño == recibido.Tamaño;
        }
        public override int GetHashCode()
        {
            return (this.Tipo+this.Tamaño+this.Color).GetHashCode();
        }
        public override string? ToString()
        {
            return $"Nuestro Jarron, de estilo {this.Tipo}, tiene un color: {this.Color}, con un tamaño de: {this.Tamaño}"; 
        }
    }
}
