using BibliotecaClases.PolimorfismoConClases;
using BibliotecaClases.PolimorfismoConClases.Services;

namespace BibliotecaClases.Test.PolimorfismoConClases
{
    [TestClass]
    public class ValidadorPersonaTest
    {
        [TestMethod]
        public void ValidadorPesonaTestOK()
        {
            ValidadorInicial miValidador = new();
            Persona PersonaDePrueba01 = new()
            {
                NombreCompleto = "Prueba de Persona 01",
                Edad = 18
            };
            Assert.IsNotNull(PersonaDePrueba01);
            Assert.IsTrue(miValidador.IsValid(PersonaDePrueba01));
        }
        [TestMethod]
        public void ValidadorPesonaTestNO()
        {
            ValidadorInicial miValidador = new();
            Persona PersonaDePrueba01 = new()
            {
                NombreCompleto = "Prueba de Persona 01",
                Edad = -1
            };
            Assert.IsNotNull(PersonaDePrueba01);
            Assert.IsFalse(miValidador.IsValid(PersonaDePrueba01));
        }
    }
}
