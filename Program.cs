
using TallerParte1.Models;

var Empresa = new Empresa("Chilaquiles", "calle 2 #2233");
var empleado = new Empleado("jose", "zapata",  30,"1152696190", "junnior", 55000000);

var empleado1 = new Empleado("Juan", "Pérez", 30, "12345678", "Desarrollador", 3500.00);
var empleado2 = new Empleado("Ana", "García",  28,"87654321", "Diseñadora", 3200.00);
var empleado3 = new Empleado("Luis", "Martínez",  45,"11223344", "Gerente", 5000.00);
var empleado4 = new Empleado("María", "Lopez",  35,"44332211", "Analista", 4000.00);
var empleado5 = new Empleado("Carlos", "Hernández",  40,"55667788", "Consultor", 4500.00);

Cliente cliente1 = new Cliente("Juan", "Pérez", 30, "juan.perez@example.com", "123-456-7890");
Cliente cliente2 = new Cliente("María", "García", 23, "maria.garcia@example.com", "123-456-7891");
Cliente cliente3 = new Cliente("Elena", "Ramírez", 23, "elena.ramirez@example.com", "123-456-7899");

Empresa.Empleados = new List<Empleado> { empleado, empleado1, empleado2, empleado3, empleado4, empleado5 };
Empresa.Clientes = new List<Cliente> { cliente1, cliente2, cliente3 };

Console.WriteLine("Bienvenido a la empresa Chilaquiles");
while (true)
{

    Console.Clear();
    Interfas.MostrarTitulo();
    Console.WriteLine("que deseas hacer?");
    Interfas.MostrarSeparador();
    Console.WriteLine("1. Agregar empleado");
    Console.WriteLine("2. Eliminar empleado");
    Console.WriteLine("3. Mostrar todos los empleados");
    Console.WriteLine("4. Actualizar empleado");
    Console.WriteLine("5. Buscar empleado por CC");
    Console.WriteLine("6. Mostrar empleados por cargo");
    Console.WriteLine("7. Agregar cliente");
    Console.WriteLine("8. Mostrar todos los cliente");
    Console.WriteLine("9. Eliminar clientes");
    Interfas.MostrarPie();

    var opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Empresa.AgregarEmpleado();
            break;
        case "2":
            Empresa.EliminarEmpleado();
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
        case "7":
            Empresa.AgregarCliente();
            break;
        case "8":
            Empresa.MostrarTodosLosClientes();
            break;
        case "9":
            Empresa.EliminarCliente();
            break;

        default:
        Console.WriteLine("Opcion no valida");
        Console.ReadKey();
        break;


        
    }
}


