namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 33;
            string nomePessoa = "Felipe Patente";
            decimal valor = 200.99m;
            double valorDouble = 200.99;
            float valorFloat = 200.99f;
            var idadeNova = 34;
            char flag = 'Y';
            bool ativo = true;

            Console.WriteLine("Hello, World!");
            Console.WriteLine(idade);
            Console.WriteLine(nomePessoa);
            Console.WriteLine(valor);
            Console.WriteLine(valorDouble);
            Console.WriteLine(valorFloat);
            Console.WriteLine(flag);
            Console.WriteLine(ativo);

            const string descricao = "Curso CSHARP";
            Console.WriteLine(descricao);
        }
    }
}