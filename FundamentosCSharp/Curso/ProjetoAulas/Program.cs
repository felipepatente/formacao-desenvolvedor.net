using System.Collections;

namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<string>(10)
            {
                "João",
                "Jose",
                "Maria"
            };

            lista.Add("Rafael");
            lista.Add("Almeida");
            lista.Add("Curso");

            var nome = lista[0];
            Console.WriteLine(nome);

            lista.RemoveAt(0);
            lista.ForEach(l => Console.WriteLine(l));
        }
    }
}