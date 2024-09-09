using BibliotecaClases.Colecciones.Objecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Test.Colecciones.Objecto
{
    [TestClass]
    public class PruebasJarron
    {
        private readonly Jarron[] AlmacenJarrones =
        [ new () {
                Color = "rojo",
                Tamaño = 18,
                Tipo = "Ming"},
          new () {
                Color = "azul",
                Tamaño = 18,
                Tipo = "Ming"},
          new () {
                Color="rojo",
                Tamaño= 18,
                Tipo = "Ming"}
        ];
        [TestMethod]
        public void ProbarEqualsOK()
        {
            Jarron Jarron1 = AlmacenJarrones[0];
            Jarron Jarron2 = AlmacenJarrones[2];
            Assert.IsTrue(Jarron1.Equals(Jarron2));
        }
        [TestMethod]
        public void ProbarEqualsOKCambiado()
        { 
            Jarron Jarron1 = AlmacenJarrones[0];
            Jarron Jarron2 = AlmacenJarrones[1];
            Assert.IsTrue(Jarron1.Equals(Jarron2));
        }

    }
}
