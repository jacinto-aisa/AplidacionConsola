using BibliotecaClases.PolimorfismoConClases;
using BibliotecaClases.ReflexionInstrospeccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Test.ReflexionInstrospeccion
{
    [TestClass]
    public class ReflexionInstrospeccionTest
    {

        [TestMethod]
        public void ClasePersona01OK()
        {
            Persona miPersona = new() { NombreCompleto = "Manolo Lopez", Edad = 34 };
            ExploradorDePersonal Introspeccion = new (miPersona);
            Assert.AreEqual("Persona", Introspeccion.DameClase());
        }
        [TestMethod]
        public void ClaseProfesor01OK()
        {
            Profesor miProfesor = new() { NombreCompleto = "Manolo Lopez", Edad = 34, AñosExperiencia = 9  };
            ExploradorDePersonal Introspeccion = new(miProfesor);
            Assert.AreEqual("Profesor", Introspeccion.DameClase());
        }
        [TestMethod]
        public void ClaseAlumno01OK()
        {
            Alumno miAlumno = new() { NombreCompleto = "Manolo Lopez", Edad = 34, EstudiosAnteriores = "ESO" };
            ExploradorDePersonal Introspeccion = new(miAlumno);
            Assert.AreEqual("Alumno", Introspeccion.DameClase());
        }
        [TestMethod]
        public void ClaseProfesorMetodos()
        {
            Profesor miProfesor = new() { NombreCompleto = "Manolo Lopez", Edad = 34, AñosExperiencia = 9 };
            ExploradorDePersonal Introspeccion = new(miProfesor);
            var resultado = Introspeccion.DameMetodos();
            Assert.AreEqual(13, resultado.Count);
            Assert.AreEqual("Profesor", Introspeccion.DameClase());
        }

        [TestMethod]
        public void ClaseProfesorPropiedadesPublicasInstancia()
        {
            Profesor miProfesor = new() { NombreCompleto = "Manolo Lopez", Edad = 34, AñosExperiencia = 9 };
            ExploradorDePersonal Introspeccion = new(miProfesor);
            var resultado = Introspeccion.DamePropiedadesPublicasInstancia();
            Assert.AreEqual(3, resultado.Count);
            Assert.AreEqual("Profesor", Introspeccion.DameClase());
        }
        [TestMethod]
        public void ClaseProfesorPropiedadesPublicas()
        {
            Profesor miProfesor = new() { NombreCompleto = "Manolo Lopez", Edad = 34, AñosExperiencia = 9 };
            ExploradorDePersonal Introspeccion = new(miProfesor);
            var resultado = Introspeccion.DamePropiedadesPublicas();
            Assert.AreEqual(0, resultado.Count);
            Assert.AreEqual("Profesor", Introspeccion.DameClase());
        }
        [TestMethod]
        public void ClaseProfesorBaseOK()
        {
            Profesor miProfesor = new() { NombreCompleto = "Manolo Lopez", Edad = 34, AñosExperiencia = 9 };
            ExploradorDePersonal Introspeccion = new(miProfesor);
            var resultado = Introspeccion.DameClaseBase();
            Assert.AreEqual("Persona", resultado?.Name);
            Assert.AreEqual("Profesor", Introspeccion.DameClase());
        }
        [TestMethod]
        public void ClaseProfesorInterfaceOK()
        {
            Profesor miProfesor = new() { NombreCompleto = "Manolo Lopez", Edad = 34, AñosExperiencia = 9 };
            ExploradorDePersonal Introspeccion = new(miProfesor);
            var resultado = Introspeccion.ImplementaInterface(typeof(IMostrable));
            Assert.IsTrue(resultado);
            Assert.AreEqual("Profesor", Introspeccion.DameClase());
        }
    }
}
