using BibliotecaClases.Colecciones.Objecto;
using BibliotecaClases.PolimorfismoConClases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Test.Colecciones.Objecto
{
    [TestClass]
    public class ColeccionMixtaTest
    {
        private  readonly ArrayList lista = [];
        [TestInitialize]
        public void Inicia()
        {
            lista.Add(new Profesor() { 
                AñosExperiencia = 10, Edad = 25, NombreCompleto = "Julio Manero" });
            lista.Add(new Jarron() { 
                Color = "rojo", Tamaño = 25, Tipo = "Ming" });
            lista.Add(new Alumno() { 
                Edad = 25, EstudiosAnteriores = "ESO", NombreCompleto = "Ana Maria Lopez" });
            lista.Add(new Jarron() { 
                Color = "verde", Tamaño = 22, Tipo = "Iberico" });
            lista.Add(new Persona() { 
                Edad = 25, NombreCompleto = "Ambrosio Lopez" });
        }
        [TestMethod]
        public void CompruebaNumeroOK()
        {
            ColeccionMixta coleccionMixta = new(lista);
            int numero =  coleccionMixta.DameNumeroElementos();
            Assert.AreEqual(5, numero);
        }
        [TestMethod]
        public void CompruebaNumeroJarrones()
        {
            ColeccionMixta coleccionMixta = new(lista);
            int numero = coleccionMixta.DameNumeroJarrones();
            Assert.AreEqual(2, numero);
        }
        [TestMethod]
        public void CompruebaNumeroPersonas()
        {
            ColeccionMixta coleccionMixta = new(lista);
            int numero = coleccionMixta.DameNumeroPersonas();
            Assert.AreEqual(3, numero);
        }
        [TestMethod]
        public void CompruebaEdadTotalPersonas()
        {
            ColeccionMixta coleccionMixta = new(lista);
            int numero = coleccionMixta.DameEdadTotalPersonas();
            Assert.AreEqual(75, numero);
        }
        [TestMethod]
        public void CompruebaTamañoSumadoJarron()
        {
            ColeccionMixta coleccionMixta = new(lista);
            int numero = coleccionMixta.DameTamañoSumadoJarron();
            Assert.AreEqual(47, numero);
        }
    }
}
