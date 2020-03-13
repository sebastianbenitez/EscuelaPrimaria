using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaPrimaria.Clases
{
    class Evaluacion : INota
    {
        public void GenerarNota()
        {
            var rnd = new Random();
            var nota = rnd.Next(1, 10);
            Console.WriteLine("Nota: {0}", nota);
        }
    }
}
