using BibliotecaClases.Colecciones;
using BibliotecaClases.PolimorfismoConClases;

namespace BibliotecaClases.Test.Colecciones.Objecto
{
    [TestClass]
    public class DerechoConArraysTest
    {
        readonly Alumno[] Alumnos = [
           new () { Edad = 18,
                NombreCompleto ="Manolo Gomez",
                EstudiosAnteriores ="ESO" },
            new () { Edad=22,
                NombreCompleto="Ana María Lopez",
                EstudiosAnteriores="NADA" },
            new () { Edad=26,
                NombreCompleto="Julio Jose Perez",
                EstudiosAnteriores="ESO" },
            new () { Edad=28,
                NombreCompleto="María Gonzalez",
                EstudiosAnteriores="ESO"}
       ];
        readonly Profesor[] Profesores = [
            new () { Edad=56,
                AñosExperiencia=23,
                NombreCompleto="Jacinto Aisa Ibañez" },
            new () { Edad=49,
                AñosExperiencia=24,
                NombreCompleto="Berta Pañar" }
        ];
        DerechoConArrays? PruebaDerecho = null;
        [TestInitialize]
        public void TestInitialize()
        {
            PruebaDerecho = new(Alumnos, Profesores);
        }

        [TestMethod]
        public void ProbarCreacionOK()
        {
            Assert.IsNotNull(PruebaDerecho);
        }
        [TestMethod]
        public void ProbarNumeroDeAlumnos()
        {
            Assert.AreEqual(4, PruebaDerecho?.NumeroAlumnos());
        }
        [TestMethod]
        public void ProbarNumeroDeProfesores()
        {
            Assert.AreEqual(2, PruebaDerecho?.NumeroProfesores());
        }
        [TestMethod]
        public void ProbarAlumnoMasBrillante()
        {
            Assert.IsNotNull(PruebaDerecho);
            Alumno? AlumnoMasBrillante = PruebaDerecho.AlumnoMasBrillante();
            Assert.IsNotNull(AlumnoMasBrillante);
            Assert.AreEqual("Manolo Gomez", AlumnoMasBrillante.NombreCompleto);
        }
        [TestMethod]
        public void ProbarEdadMediaAlumnos()
        {
            Assert.IsNotNull(PruebaDerecho);
            Assert.AreEqual(23.5, PruebaDerecho.DameEdadMediaAlumnos());
        }
        [TestMethod]
        public void ProbarEdadMediaProfesores()
        {
            Assert.IsNotNull(PruebaDerecho);
            Assert.AreEqual(52.5, PruebaDerecho.DameEdadMediaProfesores());
        }
        [TestMethod]
        public void ProbarEdadMediaCurso()
        {
            Assert.IsNotNull(PruebaDerecho);
            Assert.AreEqual(33.16, PruebaDerecho.DameEdadMediaClase(), 0.01);
        }
    }
}
