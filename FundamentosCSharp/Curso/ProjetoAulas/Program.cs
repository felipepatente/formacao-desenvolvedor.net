namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numero1 = 1;
            var numero2 = 2;

            var soma = numero1 + numero2;
            Console.WriteLine(soma);

            var subtracao = numero2 + numero1;
            Console.WriteLine(subtracao);

            var multiplicacao = (numero2 * numero1) * 10;
            Console.WriteLine(multiplicacao);

            var divisao = numero2 / numero1;
            Console.WriteLine(divisao);
        }
    }
}