using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.PolimorfismoConClases.Services
{
    public class Validador01 : IPersonaValidador
    {
        public bool IsValid(Persona personaAValidar)
        {
            return (personaAValidar.Edad >= 18 && personaAValidar.NombreCompleto.Length >= 8);
        }
    }
}
