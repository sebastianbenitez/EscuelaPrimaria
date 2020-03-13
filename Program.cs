using System;
using System.Collections.Generic;
using EscuelaPrimaria.Clases;

namespace EscuelaPrimaria
{
    class Program
    {
        static void Main(string[] args)
        {
            var primaria = new Primaria();
            primaria.GenerarNota();

            foreach (var curso in primaria.Cursos)
            {
                foreach (var alumno in curso.Alumnos)
                {
                    foreach (var materia in alumno.Materias)
                    {
                        foreach (var evaluacion in materia.Evaluaciones)
                        {
                            Console.WriteLine(evaluacion.Nota);
                        }
                    }
                }
            }
        }
    }
}
