using System;
using System.Collections.Generic;
using EscuelaPrimaria.Clases;

namespace EscuelaPrimaria
{
    class Program
    {
        static void Main(string[] args)
        {
            var materias = new List<Materia>();
            var matematicas = new Materia("Matematicas");
            var lengua = new Materia("Lengua");
            var musica = new Materia("Musica");
            var edfisica = new Materia("Educacion Fisica");                        
            materias.Add(matematicas);
            materias.Add(lengua);
            materias.Add(musica);
            materias.Add(edfisica);

            var primaria = new Primaria(materias);
            primaria.GenerarNota();
        }
    }
}
