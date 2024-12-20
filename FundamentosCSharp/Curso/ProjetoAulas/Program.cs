using System.Collections;
using System.Runtime.InteropServices;

namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var diaDaSemana = 1;
            var diaDeTrabalho = true;

            if (diaDaSemana == 0 && diaDeTrabalho)
                Console.WriteLine("Hoje é domingo");
            else if (diaDaSemana == 0 && !diaDeTrabalho)
                Console.WriteLine("Hoje é domingo, mas não é dia de trabalho");
            else
                Console.WriteLine("Hoje não é domingo");
        }
    }
}