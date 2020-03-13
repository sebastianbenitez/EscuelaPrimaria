using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaPrimaria.Clases
{
    class Primaria : INota
    {
        public Primaria()
        {
            Cursos = new List<Curso>();
        }
        public List<Curso> Cursos { get; private set; }
        public void GenerarNota()
        {
            // La primaria tiene del 1ro al 7mo grado
            for (int i = 0; i < 7; i++)
            {
                var curso = new Curso();
                curso.GenerarNota();
                Cursos.Add(curso);
            }            
        }
    }
}
