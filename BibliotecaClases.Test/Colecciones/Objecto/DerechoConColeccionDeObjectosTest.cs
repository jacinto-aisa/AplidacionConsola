using BibliotecaClases.Colecciones;
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
    public class DerechoConColeccionDeObjectosTest
    {
        private readonly ArrayList lista = [];
        private DerechoConColeccionObjetos? ColeccionObjetos;
        [TestInitialize]
        public void Inicializar()
        {
            lista.Add(new Alumno()
            {
                Edad = 18,
                NombreCompleto = "Manolo Gomez",
                EstudiosAnteriores = "ESO"
            });
            lista.Add(new Alumno()
            {
                Edad = 22,
                NombreCompleto = "Ana María Lopez",
                EstudiosAnteriores = "NADA"
            });
            lista.Add(new Alumno()
            {
                Edad = 26,
                NombreCompleto = "Julio Jose Perez",
                EstudiosAnteriores = "ESO"
            });
            lista.Add(new Alumno()
            {
                Edad = 28,
                NombreCompleto = "María Gonzalez",
                EstudiosAnteriores = "ESO"
            });
            lista.Add(new Profesor()
            {
                Edad = 56,
                AñosExperiencia = 23,
                NombreCompleto = "Jacinto Aisa Ibañez"
            });
            lista.Add(new Profesor()
            {
                Edad = 49,
                AñosExperiencia = 24,
                NombreCompleto = "Berta Pañar"
            });
            ColeccionObjetos = new DerechoConColeccionObjetos(lista);
        }
        [TestMethod]
        public void ProbarCreacionOK()
        {
            Assert.IsNotNull(ColeccionObjetos);
        }
        [TestMethod]
        public void ProbarNumeroDeAlumnos()
        {
            Assert.AreEqual(4, ColeccionObjetos?.NumeroAlumnos());
        }
        [TestMethod]
        public void ProbarNumeroDeProfesores()
        {
            Assert.AreEqual(2, ColeccionObjetos?.NumeroProfesores());
        }
        [TestMethod]
        public void ProbarAlumnoMasBrillante()
        {
            Assert.IsNotNull(ColeccionObjetos);
            Alumno? AlumnoMasBrillante = ColeccionObjetos.AlumnoMasBrillante();
            Assert.IsNotNull(AlumnoMasBrillante);
            Assert.AreEqual("Manolo Gomez", AlumnoMasBrillante.NombreCompleto);
        }
        [TestMethod]
        public void ProbarEdadMediaAlumnos()
        {
            Assert.IsNotNull(ColeccionObjetos);
            Assert.AreEqual(23.5, ColeccionObjetos.DameEdadMediaAlumnos());
        }
        [TestMethod]
        public void ProbarEdadMediaProfesores()
        {
            Assert.IsNotNull(ColeccionObjetos);
            Assert.AreEqual(52.5, ColeccionObjetos.DameEdadMediaProfesores());
        }
        [TestMethod]
        public void ProbarEdadMediaCurso()
        {
            Assert.IsNotNull(ColeccionObjetos);
            Assert.AreEqual(33.16, ColeccionObjetos.DameEdadMediaClase(), 0.01);
        }
        [TestMethod]
        public void ProbarAñadirNuevoElemento()
        {
            ColeccionObjetos?.Add(new Profesor() { NombreCompleto = "Señor añadido", Edad = 67, AñosExperiencia = 29 });
            Assert.AreEqual(3, ColeccionObjetos?.NumeroProfesores());
        }
    }
}
