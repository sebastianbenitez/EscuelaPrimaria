using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaPrimaria.Clases
{
    class Materia : INota
    {
        public Materia(string descripcion)
        {
            Evaluaciones = new List<Evaluacion>();
            Descripcion = descripcion;
        }
        public string Descripcion { get; private set; }
        public List<Evaluacion> Evaluaciones { get; private set; }
        public void GenerarNota()
        {
            // Por cada materia hay 3 evaluaciones
            for (int i = 0; i < 3; i++)
            {
                var evaluacion = new Evaluacion();
                evaluacion.GenerarNota();
                Evaluaciones.Add(evaluacion);
            }
        }
    }
}
