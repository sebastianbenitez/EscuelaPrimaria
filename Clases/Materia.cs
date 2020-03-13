using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaPrimaria.Clases
{
    class Materia : INota
    {
        private string _descripcion;
        private Evaluacion _evaluacion;
        public Materia(string descripcion)
        {
            _descripcion = descripcion;
        }
        public void GenerarNota()
        {
            Console.WriteLine("Materia: {0}", _descripcion);

            // Por cada materia hay 3 evaluaciones
            for (int i = 0; i < 3; i++)
            {
                _evaluacion = new Evaluacion();
                Console.Write("Evaluacion: {0}, ", i+1);
                _evaluacion.GenerarNota();
            }
        }
    }
}
