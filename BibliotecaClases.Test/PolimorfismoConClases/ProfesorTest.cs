using BibliotecaClases.PolimorfismoConClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Test.PolimorfismoConClases
{
    [TestClass]
    public class ProfesorTest
    {
        [TestMethod]
        public void ProfesorTestOK()
        {
            Profesor ProfesorDePrueba01 = new()
            {
                NombreCompleto = "Prueba de Persona 01",
                AñosExperiencia = 5
            };
            Assert.IsNotNull(ProfesorDePrueba01);
        }
    }
}
