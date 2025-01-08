using System.Collections;
using System.Runtime.InteropServices;

namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<string>() { "Rafael", "Curso", "Csharp" };

            for(var i=0; i < lista.Count; i++)
            {
                var nome = lista[i];
                Console.WriteLine(nome);
            }
        }
    }
}