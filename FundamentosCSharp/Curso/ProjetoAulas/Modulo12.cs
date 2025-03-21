namespace ProjetoAulas
{
    public class TrabalhandoComExcecoes
    {
        public void AulaGerandoException()
        {
            while(true)
            {
                Console.Write("Informe um número: ");
                var numero = Console.ReadLine();
                var resultado = 500 / int.Parse(numero);
                Console.WriteLine($"Resultado: {resultado}");
            }
        }

        public void AulaTratandoException()
        {
            while (true)
            {
                try
                {
                    Console.Write("Informe um número: ");
                    var numero = Console.ReadLine();
                    var resultado = 500 / int.Parse(numero);
                    Console.WriteLine($"Resultado: {resultado}");

                }catch(DivideByZeroException ex)
                {
                    Console.WriteLine($"Ocorreu um erro de divisão: {ex.Message}");
                    Console.WriteLine($"Div Stack: {ex.StackTrace}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                    Console.WriteLine($"Stack: {ex.StackTrace}");
                }
            }
        }
    }
}
