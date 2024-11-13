namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var soma = SomaValores(3, 5);
            Console.WriteLine(soma);

            var nome = NomeEIdade("Felipe", 31);
            Console.WriteLine(nome);
        }

        static int SomaValores(int a, int b)
        {
            return a + b;
        }

        static string NomeEIdade(string nome, int idade)
        {
            return "Meu nome é "+ nome +" e tenho "+ idade +" anos";
        }
    }
}