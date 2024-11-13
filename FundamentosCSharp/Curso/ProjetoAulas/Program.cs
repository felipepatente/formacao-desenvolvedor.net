namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numero1 = 1;
            var numero2 = 2;

            bool igual = numero1 == numero2;
            Console.WriteLine(igual);

            bool maior = numero2 > numero1;
            Console.WriteLine(maior);

            bool menor = numero2 < numero1;
            Console.WriteLine(menor);

            bool menorOuIgual = numero2 <= numero1;
            Console.WriteLine(menorOuIgual);

            bool maiorOuIgual = numero2 >= numero1;
            Console.WriteLine(maiorOuIgual);

            bool diferente = numero2 != numero1;
            Console.WriteLine(diferente);
        }
    }
}