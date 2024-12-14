using System.Collections;
using System.Runtime.InteropServices;

namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            stack.Push("Felipe");
            stack.Push("Patente");

            var nome  = stack.Pop();
            var sobreNome = stack.Pop();

            Console.WriteLine(nome);
            Console.WriteLine(sobreNome);

            Console.WriteLine("----------");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}