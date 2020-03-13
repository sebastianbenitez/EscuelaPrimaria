using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaPrimaria.Clases
{
    class Alumno : INota
    {
        private string _nombre;
        private List<Materia> _materias;
        public Alumno(string nombre, List<Materia> materias)
        {
            _nombre = nombre;
            _materias = materias;
        }
        public void GenerarNota()
        {
            Console.WriteLine("Alumno: {0}", _nombre);
            
            foreach (var materia in _materias)
            {
                materia.GenerarNota();
            }
        }
    }
}
