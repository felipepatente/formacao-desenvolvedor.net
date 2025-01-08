using System.Collections;
using System.Runtime.InteropServices;

namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<string>() { "Rafael", "Curso", "Csharp" };

            foreach(string item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------");

            foreach (var letra in "Felipe Patente")
            {
                Console.WriteLine(letra);
            }
        }
    }
}