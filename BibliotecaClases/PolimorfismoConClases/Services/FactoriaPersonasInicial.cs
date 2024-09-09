using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.PolimorfismoConClases.Services
{
    public class FactoriaPersonasInicial(IPersonaValidador validador) : IFactoriaPersona
    {
        public Persona? DamePersona(sbyte edad, string nombreCompleto)
        {
            Persona PersonaACrear = new() 
            { 
                Edad = edad, 
                NombreCompleto = nombreCompleto 
            };
            if (validador.IsValid(PersonaACrear))
            {
                return PersonaACrear;
            }
            else
            {
                return null;
            }
        }
    }
}
