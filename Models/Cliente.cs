using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerParte1.Models
{
    public class Cliente : Persona
    {
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nombre, string apellido, int edad,string email, string telefono):base(nombre, apellido, edad)
        {
            Email = email;
            Telefono = telefono;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Informacion del cliente\n Nombre Completo: {Nombre} {Apellido}\n Edad: {Edad}\n Email: {Email}\n Telefono: {Telefono}");
        }

        public string GetNombre()
        {
            return Nombre;            
        }
        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }

        public string GetApellido()
        {
            return Apellido;
        }

        public void SetApellido(string apellido)
        {
            Apellido = apellido;
        }
    }
}