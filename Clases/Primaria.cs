using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaPrimaria.Clases
{
    class Primaria : INota
    {
        private Curso _curso;
        private List<Materia> _materias;
        public Primaria(List<Materia> materias)
        {
            _materias = materias;
        }
        public void GenerarNota()
        {
            var nombreCurso = "";

            // La primaria tiene del 1ro al 7mo grado
            for (int i = 0; i < 7; i++)
            {
                nombreCurso =  (i + 1) + "° Grado";
                _curso = new Curso(nombreCurso, _materias);
                _curso.GenerarNota();

                Console.WriteLine();
            }            
        }
    }
}
