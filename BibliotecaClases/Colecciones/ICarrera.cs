using BibliotecaClases.PolimorfismoConClases;

namespace BibliotecaClases.Colecciones
{
    public interface ICarrera
    {
        Alumno? AlumnoMasBrillante();
        double DameEdadMediaAlumnos();
        double DameEdadMediaClase();
        double DameEdadMediaProfesores();
        int NumeroAlumnos();
        int NumeroProfesores();
    }
}