namespace ProjetoAulas
{
    public class TrabalhandoComStrings
    {
        public void ConverterParaLetrasMinusculas()
        {
            Console.WriteLine("Favor digitar alguma informação: ");
            var linha = Console.ReadLine();
            Console.WriteLine(linha?.ToLower());
        }

        public void ConverterParaLetrasMaiusculas()
        {
            Console.WriteLine("Favor digitar alguma informação: ");
            var linha = Console.ReadLine();
            Console.WriteLine(linha?.ToUpper());
        }

        public void AulaSubstring()
        {
            Console.WriteLine("Favor digitar alguma informação: ");
            var linha = Console.ReadLine();
            Console.WriteLine(linha?.Substring(0,6));
        }
    }
}
