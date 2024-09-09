using BibliotecaClases.PolimorfismoConClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Test.PolimorfismoConClases
{
    [TestClass]
    public class AlumnoTest
    {
        [TestMethod]
        public void AlumnoTestOK()
        {
            Alumno AlumnoDePrueba01 = new()
            {
                NombreCompleto = "Prueba de Persona 01",
                EstudiosAnteriores = "ESO"
            };
            Assert.IsNotNull(AlumnoDePrueba01);
        }
    }
}
