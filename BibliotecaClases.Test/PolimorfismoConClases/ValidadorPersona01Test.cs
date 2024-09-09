using BibliotecaClases.PolimorfismoConClases.Services;
using BibliotecaClases.PolimorfismoConClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Test.PolimorfismoConClases
{
    [TestClass]
    public class ValidadorPersona01Test
    {
        [TestMethod]
        public void ValidadorPesona01TestOK()
        {
            Validador01 miValidador = new();
            Persona PersonaDePrueba01 = new()
            {
                NombreCompleto = "Prueba de Persona 01",
                Edad = 18
            };
            Assert.IsNotNull(PersonaDePrueba01);
            Assert.IsTrue(miValidador.IsValid(PersonaDePrueba01));
        }
        [TestMethod]
        public void ValidadorPesona01TestNO()
        {
            Validador01 miValidador = new();
            Persona PersonaDePrueba01 = new()
            {
                NombreCompleto = "hola",
                Edad = -1
            };
            Assert.IsNotNull(PersonaDePrueba01);
            Assert.IsFalse(miValidador.IsValid(PersonaDePrueba01));
        }
    }
}
