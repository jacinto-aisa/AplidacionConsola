namespace BibliotecaClases.Test
{
    [TestClass]
    public class FormularioInscripcionTest
    {
        [TestMethod]
        public void FormularioInscripcionTestOK()
        {
            FormularioInscripción Prueba = new() { 
                Nombre = "Pepe", 
                Apellido = "Perez", 
                Email = "Pepe@gmail.com", 
                Contraseña = "xxxx" };
            Assert.IsNotNull(Prueba);
        }
        [TestMethod]
        public void FormularioInscripcionTestError()
        {

        }
    }
}