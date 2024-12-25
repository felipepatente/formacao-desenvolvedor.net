using System.Collections;
using System.Runtime.InteropServices;

namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var diaDaSemana = 0;

            switch (diaDaSemana) 
            { 
                case 0:
                    Console.WriteLine("Hojé domingo");
                    break;
                case 1:
                    Console.WriteLine("Hoje é segunda");
                    break;
                case 2:
                    Console.WriteLine("Hoje é terça");
                    break;
                case 3:
                    Console.WriteLine("Hoje é quarta");
                    break;
                case 4:
                    Console.WriteLine("Hoje é quinta");
                    break;
                case 5:
                    Console.WriteLine("Hoje é sexta");
                    break;
                case 6:
                    Console.WriteLine("Hoje é sábado");
                    break;
                default: 
                    Console.WriteLine("invalido");
                    break;
            }
        }
    }
}