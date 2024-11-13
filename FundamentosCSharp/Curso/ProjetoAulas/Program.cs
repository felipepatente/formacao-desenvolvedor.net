namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numero1 = 1;
            var numero2 = 2;

            var valido = numero2 > numero1 && 6 > 7;
            Console.WriteLine(valido);

            var valido2 = numero2 > 10 || 6 > 7;
            Console.WriteLine(valido2);

            var valido3 = !(numero2 > 10);
            Console.WriteLine(valido3);
        }
    }
}