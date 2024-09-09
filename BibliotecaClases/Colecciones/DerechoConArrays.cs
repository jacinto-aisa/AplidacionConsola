using BibliotecaClases.PolimorfismoConClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Colecciones
{
    public class DerechoConArrays(Alumno[] alumnos, Profesor[] profesores) : ICarrera
    {
        readonly Alumno[] Alumnos = alumnos;
        readonly Profesor[] Profesores = profesores;

        public int NumeroAlumnos()
        {
            return this.Alumnos.Length;
        }
        public int NumeroProfesores()
        {
            return this.Profesores.Length;
        }
        public Alumno? AlumnoMasBrillante()
        {
            if (Alumnos[0] is not null)
            {
                return this.Alumnos[0];
            }
            else return null;
        }
        private static double DameSumaArray(Persona[] personas)
        {
            double SumaEdad = 0;
            foreach (var item in personas)
            {
                SumaEdad += item.Edad;
            }
            return SumaEdad;
        }
        public double DameEdadMediaAlumnos()
        {
            return DameSumaArray(this.Alumnos) / NumeroAlumnos();
        }
        public double DameEdadMediaProfesores()
        {
            return DameSumaArray(this.Profesores) / NumeroProfesores();
        }
        public double DameEdadMediaClase()
        {
            return (DameSumaArray(this.Alumnos) + DameSumaArray(this.Profesores))/ (NumeroAlumnos() + NumeroProfesores());
        }
    }
}
