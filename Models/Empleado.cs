using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerParte1.Models
{
    public class Empleado
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NumeroDeIdentificacion { get; set; }
        public byte Edad { get; set; }
        public string? Posicion { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre, string apellido, string numerodeidentificacion, byte edad, string posicion, double salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            NumeroDeIdentificacion = numerodeidentificacion;
            Edad = edad;
            Posicion = posicion;
            Salario = salario;
        }

        private double CalcularBonificaion()
        {
            var Bonificacion = Salario * 0.1;
            return Bonificacion;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Informacion del empleado\n Id: {Id}\n Nombre: {Nombre}\n Apellido: {Apellido}\n Numero Cc: {NumeroDeIdentificacion}\n Edad: {Edad}\n Cargo: {Posicion}\n Salario: {CalcularBonificaion()}");
            Console.WriteLine();
        }
    }
}