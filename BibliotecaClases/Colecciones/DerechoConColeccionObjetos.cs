using BibliotecaClases.PolimorfismoConClases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Colecciones
{
    public class DerechoConColeccionObjetos(ArrayList elementos) : ICarrera, ICollectionObject
    {
        public void Add(object obj)
        {
            elementos.Add(obj);
        }
        public Alumno? AlumnoMasBrillante()
        {
            foreach (var item in elementos)
            {
                if (item is Alumno)
                {
                    return (item as Alumno);
                }
            }
            return null;
        }
        public double DameEdadMediaAlumnos()
        {
            double suma = 0;
            foreach (var item in elementos)
            {
                if (item is Alumno alumno)
                {
                    suma += alumno.Edad;
                }
            }
            return suma / NumeroAlumnos();
        }
        public double DameEdadMediaClase()
        {
            double suma = 0;
            foreach (var item in elementos)
            {
                    suma += ((Persona)item).Edad;
            }
            return suma / (NumeroAlumnos() + NumeroProfesores());
        }

        public double DameEdadMediaProfesores()
        {
            double suma = 0;
            foreach (var item in elementos)
            {
                if (item is Profesor profesor)
                {
                    suma += profesor.Edad;
                }
            }
            return suma / NumeroProfesores();
        }

        public int NumeroAlumnos()
        {
            int cantidad = 0;
            foreach (var item in elementos)
            {
                if (item is Alumno)
                {
                    cantidad ++;
                }
            }
            return cantidad;
        }

        public int NumeroProfesores()
        {
            int cantidad = 0;
            foreach (var item in elementos)
            {
                if (item is Profesor)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
    }
}
