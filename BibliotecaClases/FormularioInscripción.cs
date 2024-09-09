using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaClases
{
    public class FormularioInscripción
    {
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Email { get; set; }
        public required string Contraseña { get; set; }


    }
}
