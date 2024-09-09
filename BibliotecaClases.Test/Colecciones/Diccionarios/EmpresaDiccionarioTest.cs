using BibliotecaClases.Colecciones.Diccionarios;
using BibliotecaClases.Colecciones.Genericos;
using BibliotecaClases.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Test.Colecciones.Genericos
{
    [TestClass]
    public class EmpresaDiccionarioTest
    {
        private readonly SerializacionDiccionario Serializacion = new();
        private EmpresaConIds? miEmpresa;
        [TestInitialize]
        public void CreaElementosEnColeccion()
        {
            miEmpresa = new(Serializacion);
            Producto Acido = new () {
                Id = 1, Coste = 100, Nombre = "Acido Cloridico" };
            MateriaPrima Acero = new () { 
                Id = 2, Coste = 100, Nombre = "Acero galvanizado",IndiceVolativilidad=0.3 };
            Empleado Manolo = new() { 
                Id = 3, Coste = 100, Nombre = "Manolo Caracol", SueldoNeto = 1100 };
            Producto Alcohol = new() { 
                Id = 4, Coste = 100, Nombre = "Alcohol Isopropilico" };
            MateriaPrima Carton = new() { 
                Id = 5, Coste = 100, Nombre = "Cartón de Papel", IndiceVolativilidad = 0.9 };
            Empleado Anabel = new() { 
                Id = 6, Coste = 100, Nombre = "Anabel Garcia", SueldoNeto = 1400 };
            miEmpresa.Add(Acido);
            miEmpresa.Add(Acero);
            miEmpresa.Add(Manolo);
            miEmpresa.Add(Alcohol);
            miEmpresa.Add(Carton);
            miEmpresa.Add(Anabel);
        }
        [TestMethod]
        public void NumeroElementosTest()
        {
            Assert.AreEqual(6, miEmpresa?.NumeroElementos);
        }

        [TestMethod]
        public void CosteTotal()
        {
            Assert.AreEqual(3100, miEmpresa?.CosteTotal);
        }
        [TestMethod]
        public void BorrarOK()
        {
            miEmpresa?.Delete(5);
            Assert.AreEqual(5,miEmpresa?.NumeroElementos);
        }
        [TestMethod]
        public void ProbarGETOK()
        {
            var elemento = miEmpresa?.GetElemento(1);
            Assert.IsNotNull(elemento);
            Assert.AreEqual("Acido Cloridico", elemento.Nombre);
        }
    }
}
