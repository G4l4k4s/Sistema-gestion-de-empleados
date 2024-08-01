using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerParte1.Models
{
    public class Persona
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

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Informacion de la persona\n Nombre Completo: {Nombre} {Apellido}\n Edad: {Edad}");
        }

        
    }
}