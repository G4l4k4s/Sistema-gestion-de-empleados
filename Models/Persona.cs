using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerParte1.Models
{
    public abstract class Persona
    {
        protected Guid Id { get; set; }
        protected string? Nombre { get; set; }
        protected string? Apellido { get; set; }
        protected int Edad { get; set; }

        protected Persona(string nombre, string apellido, int edad)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public abstract void MostrarInformacion();



    }
}