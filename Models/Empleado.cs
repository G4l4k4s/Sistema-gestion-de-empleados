using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace TallerParte1.Models
{
    public class Empleado : Persona
    {
        public Guid Id { get; set; }
        public string? NumeroDeIdentificacion { get; set; }
        public string? Posicion { get; set; }
        public double Salario { get; set; }



        public Empleado(string nombre, string apellido, int edad, string numerodeidentificacion, string posicion, double salario) : base(nombre, apellido, edad)
        {
            NumeroDeIdentificacion = numerodeidentificacion;
            Posicion = posicion;
            Salario = salario;
        }

        private double CalcularBonificaion()
        {
            var Bonificacion = Salario * 0.1;
            return Bonificacion;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Informacion del empleado\n Id: {Id}\n Nombre: {Nombre}\n Apellido: {Apellido}\n Numero Cc: {NumeroDeIdentificacion}\n Edad: {Edad}\n Cargo: {Posicion}\n Salario: {CalcularBonificaion()}");
            Console.WriteLine();
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

        public int GetEdad()
        {
            return Edad;
        }

        public void SetEdad(int edad)
        {
            Edad = edad;
        }
    }
}