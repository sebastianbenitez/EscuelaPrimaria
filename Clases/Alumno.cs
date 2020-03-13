using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaPrimaria.Clases
{
    class Alumno : INota
    {
        private string[] _descMaterias = {"Matematicas","Lengua","Musica","Educacion Fisica"};
        public Alumno()
        {
            Materias = new List<Materia>();
            foreach (var dM in _descMaterias)
            {
                var materia = new Materia(dM);
                Materias.Add(materia);
            }
        }
        public List<Materia> Materias { get; private set; } 
        public void GenerarNota()
        {            
            // Cada alumno cursa 4 materias
            foreach (var materia in Materias)
            {
                materia.GenerarNota();
            }
        }
    }
}
