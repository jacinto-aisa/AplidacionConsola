using BibliotecaClases.PolimorfismoConClases;
using BibliotecaClases.PolimorfismoConClases.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Test.PolimorfismoConClases
{
    [TestClass]
    public class FactoriaPersonasInicialTest
    {
        readonly FactoriaPersonasInicial factoria = new(new Validador01());
        [TestMethod]
        public void FactoriaPersonasInicialOK()
        {
            Persona? PersonaDePrueba = factoria.DamePersona(22, "Jacinto Aisa");
            Assert.IsNotNull(PersonaDePrueba);
        }
        [TestMethod]
        public void FactoriaPersonasInicialEdadMal()
        {
            Persona? PersonaDePrueba = factoria.DamePersona(-9, "Jacinto Aisa");
            Assert.IsNull(PersonaDePrueba);
        }
        [TestMethod]
        public void FactoriaPersonasInicialNombreMall()
        {
            Persona? PersonaDePrueba = factoria.DamePersona(19, "Ja");
            Assert.IsNull(PersonaDePrueba);
        }
        [TestMethod]
        public void FactoriaPersonasInicialNombreEdadMall()
        {
            Persona? PersonaDePrueba = factoria.DamePersona(-19, "Ja");
            Assert.IsNull(PersonaDePrueba);
        }
    }
}
