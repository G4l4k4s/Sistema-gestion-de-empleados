using TallerParte1.Models;

var Empresa = new Empresa("Chilaquiles", "calle 2 #2233");
var empleado = new Empleado("jose", "zapata", "1152696190", 30, "junnior", 55000000);

var empleado1 = new Empleado("Juan", "Pérez", "12345678", 30, "Desarrollador", 3500.00);
var empleado2 = new Empleado("Ana", "García", "87654321", 28, "Diseñadora", 3200.00);
var empleado3 = new Empleado("Luis", "Martínez", "11223344", 45, "Gerente", 5000.00);
var empleado4 = new Empleado("María", "Lopez", "44332211", 35, "Analista", 4000.00);
var empleado5 = new Empleado("Carlos", "Hernández", "55667788", 40, "Consultor", 4500.00);

Empresa.Empleados = new List<Empleado> { empleado, empleado1, empleado2, empleado3, empleado4, empleado5 };
while (true)
{

    Console.Clear();
    Console.WriteLine("bienvenido empleado");
    Console.WriteLine("que deseas hacer?");
    Console.WriteLine("1. Agregar empleado");
    Console.WriteLine("2. Eliminar empleado");
    Console.WriteLine("3. Mostrar todos los empleados");
    Console.WriteLine("4. Actualizar empleado");
    Console.WriteLine("5. Buscar empleado por CC");
    Console.WriteLine("6. Mostrar empleados por cargo");

    var opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Empresa.AgregarEmpleado();
            break;
        case "2":
            Console.WriteLine("Ingrese el nombre del empleado a eliminar");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del empleado a eliminar");
            var apellido = Console.ReadLine();
            Empresa.EliminarEmpleado(nombre, apellido);
            break;
        case "3":
            Empresa.MostrarTodosLosEmpleados();
            Console.ReadKey();
            break;
        case "4":
            Empresa.ActualizarEmpleado();
            break;
        case "5":
            Empresa.BuscarEmpleado();
            break;
        case "6":
            Empresa.MostrarEmpleadosPorCargo();
            break;
    }
}


