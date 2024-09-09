using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace BibliotecaClases.PolimorfismoConClases
{
    public class Persona
    {
        public required string NombreCompleto { get; set; }
        public sbyte Edad { get; set; }
        public void Saludar()
        {
            Console.WriteLine("Hola soy: " + NombreCompleto);
        }
    }
}
