// See https://aka.ms/new-console-template for more information

using BibliotecaClases;
using BibliotecaClases.Colecciones.Objecto;
using BibliotecaClases.EventosYDelegados;
using BibliotecaClases.PolimorfismoConClases;
using BibliotecaClases.PolimorfismoConClases.Services;
using System.ComponentModel.DataAnnotations;

//FormularioInscripción FormularioJacinto = new()
//{
//    Nombre = "Jacinto",
//    Apellido = "Aisa",
//    Email = "jacinto@desaprendiendo.net",
//    Contraseña = "iajsiasj"
//};

//Console.WriteLine(FormularioJacinto.Nombre + " " + FormularioJacinto.Apellido);

//var FormularioAna = new FormularioInscripción
//{
//    Nombre = "Ana María",
//    Apellido = "Pérez",
//    Email = "aperez@google.es",
//    Contraseña = "iajsiasj"
//};

//Console.WriteLine(FormularioAna.Nombre + " " + FormularioAna.Apellido);

//Persona PersonaJacinto = new() { 
//    NombreCompleto = "Jacinto Aisa", 
//    Edad = 34 
//};
//ValidationContext vc = new ValidationContext(PersonaJacinto);
//ICollection<ValidationResult> results = new List<ValidationResult>(); // Will contain the results of the validation
//bool isValid = Validator.TryValidateProperty(PersonaJacinto.Edad, vc, results); // Validates the property using the previously created context.

//PersonaJacinto.Saludar();

//Alumno AlumnoEmpollon = new() { 
//    NombreCompleto = "Manolo Garcia", 
//    EstudiosAnteriores = "ESO", 
//    Edad = 45 
//};
//AlumnoEmpollon.Saludar();

//Profesor ProfesorExperimentado = new()
//{
//    NombreCompleto = "Einstein Perez",
//    AñosExperiencia = 19
//};
//ProfesorExperimentado.Saludar();
//ProfesorExperimentado.Explica();

Persona PersonaJacinto = new()
{
    NombreCompleto = "Jacinto Aisa",
    Edad = 34
};
ValidadorInicial Validador = new();
Validador.IsValid(PersonaJacinto);

Jarron JarronPrueba = new() 
{ 
    Color = "rojo", 
    Tamaño = 12, 
    Tipo = "Ibero" 
};
Console.WriteLine(JarronPrueba);

PatineteElectrico MiPatinete = new(100);
MiPatinete.Actua();