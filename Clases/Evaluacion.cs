using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaPrimaria.Clases
{
    class Evaluacion : INota
    {
        public int Nota { get; private set; }
        public void GenerarNota()
        {
            // Cada evaluacion genera 1 nota
            var rnd = new Random();
            Nota = rnd.Next(1, 10);
        }
    }
}
