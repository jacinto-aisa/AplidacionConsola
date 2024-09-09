using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.PolimorfismoConClases
{
    public class Profesor : Persona, IMostrable
    {
        public required sbyte AñosExperiencia { get; set; }
        public void Explica()
        {
            if (AñosExperiencia > 5)
            {
                Console.WriteLine("Explico muy bien");
            }
            else
            {
                Console.WriteLine("No explico demasiado bien");
            }
        }

        public string Muestra()
        {
            return this.NombreCompleto + this.AñosExperiencia.ToString();
        }
    }
}
