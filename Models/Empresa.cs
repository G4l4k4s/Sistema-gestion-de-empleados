using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerParte1.Models
{
    public class Empresa
    {
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public List<Empleado>? Empleados { get; set; }


        public Empresa(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        public void AgregarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("ingresa el nombre del empleado");
            var Nombre = Console.ReadLine();
            Console.WriteLine("ingresa el Apellido");
            var Apellido = Console.ReadLine();
            Console.WriteLine("ingrese el numero de documento");
            var NumeroCC = Console.ReadLine();
            Console.WriteLine("ingrese el edad");
            var Edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("ingrese el cargo");
            var Cargo = Console.ReadLine();
            Console.WriteLine("ingrese el salario");
            var Salario = Convert.ToDouble(Console.ReadLine());
            Empleado coder1 = new Empleado(Nombre, Apellido, NumeroCC, Edad, Cargo, Salario);
            Empleados.Add(coder1);
        }

        public void EliminarEmpleado(string Nombre, string Apellido)
        {
            Empleados.RemoveAll(e => e.Nombre == Nombre && e.Apellido == Apellido);
        }
        
        public void MostrarTodosLosEmpleados()
        {
            foreach (var empleado in Empleados)
            {
                empleado.MostrarInformacion();
            }
        }

        public void ActualizarEmpleado()
        {
            Console.WriteLine(" ingrese la cc del empleado");
            var IdCoder = Console.ReadLine();
            foreach (var item in Empleados)
            {
                if (item.NumeroDeIdentificacion == IdCoder)
                {
                    Console.WriteLine("nuevo nombre del coder");
                    string? newNombre = Console.ReadLine();
                    item.Nombre = newNombre;
                    Console.WriteLine("nuevo apellido del coder");
                    string? newApellido = Console.ReadLine();
                    item.Apellido = newApellido;
                    Console.WriteLine("nuevo numero del documento del coder");
                    string? newEmail = Console.ReadLine();
                    item.NumeroDeIdentificacion = newEmail;
                    Console.WriteLine("nueva edad del empleado");
                    byte newTelefono = Convert.ToByte(Console.ReadLine());
                    item.Edad = newTelefono;
                    Console.WriteLine("nuevo nombre del coder");
                    string? newPosicion = Console.ReadLine();
                    item.Posicion = newPosicion;
                    Console.WriteLine("nuevo salario");
                    double newSalario = Convert.ToDouble(Console.ReadLine());
                    item.Salario = newSalario;                   
                    Console.WriteLine("datos actualizador con exito!");
                    Console.ReadKey();
                    break;
                }
            }
        }

        public void BuscarEmpleado()
        {
            Console.WriteLine("ingrese la cc del empleado");
            var IdCoder = Console.ReadLine();
            foreach (var item in Empleados)
            {
                if (item.NumeroDeIdentificacion == IdCoder)
                {
                    item.MostrarInformacion();
                }
            }
            Console.ReadKey();
        }

        public void MostrarEmpleadosPorCargo()
        {
            Console.WriteLine("ingrese el cargo del empleado");
            var cargo = Console.ReadLine();
            foreach (var item in Empleados)
            {
                if (item.Posicion == cargo) 
                {
                    item.MostrarInformacion();
                }
            }
            Console.ReadKey();
        }
    }
}