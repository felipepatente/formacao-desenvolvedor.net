using System.Collections;
using System.Runtime.InteropServices;

namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var diaDaSemana = 4;
            

            if(diaDaSemana == 1)
                Console.WriteLine("Domingo");
            if (diaDaSemana == 2)
                Console.WriteLine("Segunda");
            if (diaDaSemana == 3)
                Console.WriteLine("Terça");
            if (diaDaSemana == 4)
                Console.WriteLine("Quarta");
            if (diaDaSemana == 5)
                Console.WriteLine("Quinta");
            if (diaDaSemana == 6)
                Console.WriteLine("Sexta");
            if (diaDaSemana == 7)
                Console.WriteLine("Sabado");

            //DICIONARIO
            var diasSemana = new Dictionary<int, string>();
            diasSemana.Add(1, "Domingo");
            diasSemana.Add(2, "Segunda");
            diasSemana.Add(3, "Terça");
            diasSemana.Add(4, "Quarta");
            diasSemana.Add(5, "Quinta");
            diasSemana.Add(6, "Sexta");
            diasSemana.Add(7, "Sabado");

            Console.WriteLine(diasSemana[diaDaSemana]);
        }
    }
}