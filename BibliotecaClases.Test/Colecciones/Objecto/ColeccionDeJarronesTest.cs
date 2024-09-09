using BibliotecaClases.Colecciones.Objecto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Test.Colecciones.Objecto
{
    [TestClass]
    public class ColeccionDeJarronesTest
    {
        private readonly ArrayList almacenJarrones = [];
        private readonly Jarron JarronInicial = new () 
        { 
            Color = "rojo", 
            Tamaño = 18, 
            Tipo = "Ming" 
        };
        private readonly Jarron SegundoJarron = new()
        {
            Color = "azul",
            Tamaño = 20,
            Tipo = "Ibero"
        };
        private readonly Jarron TercerJarron = new()
        {
            Color = "verde",
            Tamaño = 16,
            Tipo = "Clasico"
        };

        public required ColeccionDeJarrones Coleccion; 

        [TestInitialize]
        public void Iniciar()
        {
            almacenJarrones.Add(JarronInicial);
            almacenJarrones.Add(SegundoJarron);
            almacenJarrones.Add(TercerJarron);

        }
        [TestMethod]
        public void ComparadorTipoOK()
        {
            IComparer Comparador = new ComparadorTipo();
            Coleccion = new(almacenJarrones, Comparador);
            Coleccion.Ordenar();
            if (almacenJarrones[0] is not null)
            if ((Jarron?) almacenJarrones[0] is not null)
                Assert.AreEqual("Clasico",(almacenJarrones[0] as Jarron)?.Tipo);
        }
    
        [TestMethod]
        public void ComparadorTamañoOK()
        {
        IComparer Comparador = new CompradorTamaño();
        Coleccion = new(almacenJarrones, Comparador);
        Coleccion.Ordenar();
        if (almacenJarrones[0] is not null)
            if ((Jarron?)almacenJarrones[0] is not null)
                Assert.AreEqual(16, (almacenJarrones[0] as Jarron)?.Tamaño);
        }
        [TestMethod]
        public void PruebaExistenciaOK()
        {
            IComparer Comparador = new ComparadorTipo();
            Coleccion = new(almacenJarrones, Comparador);
            Jarron JarronPrueba = new() { 
                Color = "rojo", Tamaño = 18, Tipo = "Ming" };
            Assert.IsTrue(Coleccion.ExisteJarron(JarronPrueba));
        }
        [TestMethod]
        public void PruebaExistenciaNo()
        {
            IComparer Comparador = new ComparadorTipo();
            Coleccion = new(almacenJarrones, Comparador);
            Jarron JarronPrueba = new() {
                Color = "verde", Tamaño = 22, Tipo = "Ming" };
            Assert.IsFalse(Coleccion.ExisteJarron(JarronPrueba));
        }

    }
}
