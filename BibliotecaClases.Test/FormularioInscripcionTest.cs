namespace BibliotecaClases.Test
{
    [TestClass]
    public class FormularioInscripcionTest
    {
        [TestMethod]
        public void FormularioInscripcionTestOK()
        {
            FormularioInscripci�n Prueba = new() { 
                Nombre = "Pepe", 
                Apellido = "Perez", 
                Email = "Pepe@gmail.com", 
                Contrase�a = "xxxx" };
            Assert.IsNotNull(Prueba);
        }
        [TestMethod]
        public void FormularioInscripcionTestError()
        {

        }
    }
}