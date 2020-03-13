using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaPrimaria.Clases
{
    class Curso : INota
    {
        private string _descripcion;
        private Alumno _alumno;
        private List<Materia> _materias;
        public Curso(string descripcion, List<Materia> materias)
        {
            _descripcion = descripcion;
            _materias = materias;
        }

        public void GenerarNota()
        {
            Console.WriteLine("Curso: {0}", _descripcion);
            var nombreAlumno = "";

            // Cada curso tiene 20 alumnos
            for (int i = 0; i < 20; i++)
            {
                nombreAlumno = "Alumno " + (i+1);
                _alumno = new Alumno(nombreAlumno, _materias);
                _alumno.GenerarNota();

                Console.WriteLine();
            }
        }
    }
}
