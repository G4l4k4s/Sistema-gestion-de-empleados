using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerParte1.Models
{
    public static class Interfas
    {
        public static void MostrarTitulo()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Bienvenido a la empresa Chilaquiles");
            Console.WriteLine(new string('-', 40));

        }

        public static void MostrarSeparador()
        {
            Console.WriteLine(new string('-', 40));
        }

        public static void MostrarPie()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string('-', 40));

        }
    }
}