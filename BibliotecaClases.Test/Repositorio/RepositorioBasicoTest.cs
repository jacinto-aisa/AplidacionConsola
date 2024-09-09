using BibliotecaClases.Colecciones.Genericos;
using BibliotecaClases.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Test.Repositorio
{
    [TestClass]
    public class RepositorioBasicoTest
    {
        private readonly SerializacionBasica serializacion = new();
        private Empresa? miEmpresa;
        [TestInitialize]
        public void CreaElementosEnColeccion()
        {
            miEmpresa = new(serializacion);
            Producto Acido = new()
            {
                Id = 1,
                Coste = 100,
                Nombre = "Acido Cloridico"
            };
            MateriaPrima Acero = new()
            {
                Id = 2,
                Coste = 100,
                Nombre = "Acero galvanizado",
                IndiceVolativilidad = 0.3
            };
            Empleado Manolo = new()
            {
                Id = 3,
                Coste = 100,
                Nombre = "Manolo Caracol",
                SueldoNeto = 1100
            };
            Producto Alcohol = new()
            {
                Id = 4,
                Coste = 100,
                Nombre = "Alcohol Isopropilico"
            };
            MateriaPrima Carton = new()
            {
                Id = 5,
                Coste = 100,
                Nombre = "Cartón de Papel",
                IndiceVolativilidad = 0.9
            };
            Empleado Anabel = new()
            {
                Id = 6,
                Coste = 100,
                Nombre = "Anabel Garcia",
                SueldoNeto = 1400
            };
            miEmpresa.Add(Acido);
            miEmpresa.Add(Acero);
            miEmpresa.Add(Manolo);
            miEmpresa.Add(Alcohol);
            miEmpresa.Add(Carton);
            miEmpresa.Add(Anabel);
        }
        [TestMethod]
        public void GuardaTestOK()
        {
            miEmpresa?.Grabar();
            Assert.IsTrue(File.Exists(@"C:\datos\path.json"));
        }
        [TestMethod]
        public void LeeTestOK()
        {
            miEmpresa?.Cargar();
            Assert.AreEqual(6, miEmpresa?.NumeroElementos);
        }
    }
}
