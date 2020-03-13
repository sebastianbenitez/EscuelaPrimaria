using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaPrimaria.Clases
{
    class Curso : INota
    {
        public Curso()
        {
            Alumnos = new List<Alumno>();
        }
        public List<Alumno> Alumnos { get; private set; }
        public void GenerarNota()
        {
            // Cada curso tiene 20 alumnos
            for (int i = 0; i < 20; i++)
            {
                var alumno = new Alumno();
                alumno.GenerarNota();
                Alumnos.Add(alumno);
            }
        }
    }
}
