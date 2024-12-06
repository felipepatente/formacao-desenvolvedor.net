using System.Collections;

namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dicionario = new Dictionary<int, string>() 
            {
                {5, "Luciano"},
                {6, "Luciana"},
            };

            dicionario.Add(100, "Rafael");
            dicionario[50] = "Curso";

            var nome = dicionario[100];
            //Console.WriteLine(nome);

            foreach (var item in dicionario)
            {                
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine("================================");

            Parallel.ForEach(dicionario, dicion =>
            {
                Console.WriteLine($"{dicion.Key} - {dicion.Value}");
            });
        }
    }
}