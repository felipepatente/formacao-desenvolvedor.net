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

        public void AulaRange()
        {
            string nomeArquivo = "2022_12_01_backup.bak";

            string ano = nomeArquivo[..4];
            Console.WriteLine(ano);

            string extensao = nomeArquivo[^3..];
            Console.WriteLine(extensao);

            string nome = nomeArquivo[11..^4];
            Console.WriteLine(nome);

            string apenasNome = nomeArquivo[..^4];
            Console.WriteLine(apenasNome);
        }

        public void AulaContains()
        {
            string nomeArquivo = "2022_12_01_backup.bak";
            //Console.Write($"Contem nome: {nomeArquivo.Contains("backup")}");

            if(nomeArquivo.Contains("backup"))
                Console.WriteLine("Encontrou");
            else
                Console.WriteLine("Não encontrou");

        }

        public void AulaTrim()
        {
            string teste = "**RAFAEL ALMEIDA**";

            Console.WriteLine($"TOTAL: {teste.Trim('*')}");
            Console.WriteLine($"INICIO: {teste.TrimStart('*')}");
            Console.WriteLine($"FINAL: {teste.TrimEnd('*')}");
        }

        public void AulaStartWithEndsWith()
        {
            string teste = "Curso Csharp";

            Console.WriteLine($"INICIO: {teste.StartsWith("Curso")}");
            Console.WriteLine($"FINAL: {teste.EndsWith("Csharp2")}");
        }

    }
}
