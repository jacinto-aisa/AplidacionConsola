using BibliotecaClases.PolimorfismoConClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Test.PolimorfismoConClases
{
    [TestClass]
    public class PersonaTest
    {
        [TestMethod]
        public void PersonaTestOK()
        {
            Persona PersonaDePrueba01 = new()
            {
                NombreCompleto = "Prueba de Persona 01"
            };
            Persona PersonaDePrueba02 = new()
            {
                NombreCompleto = "Prueba de Persona 02"
            };
            Assert.IsNotNull(PersonaDePrueba01);
            Assert.IsNotNull(PersonaDePrueba02);
        }
        [TestMethod]
        public void PersonaEdadMenorCeroOK()
        {
            Persona PersonaDePrueba01 = new()
            {
                NombreCompleto = "Prueba de Persona 01",
                Edad = -78
            };
            Assert.IsNotNull(PersonaDePrueba01);
            Assert.AreEqual(-78, PersonaDePrueba01.Edad);
        }
        [TestMethod]
        public void PersonaEdadMayorCeroOK()
        {
            Persona PersonaDePrueba01 = new()
            {
                NombreCompleto = "Prueba de Persona 01",
                Edad = 78
            };
            Assert.IsNotNull(PersonaDePrueba01);
            Assert.AreEqual(78, PersonaDePrueba01.Edad);
        }
    }
}
