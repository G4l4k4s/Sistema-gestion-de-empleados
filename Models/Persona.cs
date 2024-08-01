using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerParte1.Models
{
    public abstract class Persona
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public abstract void MostrarInformacion();        
    }
}