namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EscreverNome();
        }

        static string NomeCompleto() 
        {
            string primeiroNome = "Felipe";
            string segundoNome = "Patente";

            return primeiroNome + " " + segundoNome;
        }

        static int SomaValores()
        {
            return 8 + 2;
        }

        static void EscreverNome()
        {
            var nome = NomeCompleto();
            var soma = SomaValores();

            Console.WriteLine(nome);
            Console.WriteLine(soma);
        }
    }
}