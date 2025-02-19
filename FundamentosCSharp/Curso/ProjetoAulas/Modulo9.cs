namespace ProjetoAulas
{
    public class Conversor
    {
        public void ConvertAndParse() 
        {
            int numero = int.Parse("1");
            //int numero = Convert.ToInt32("1");
            Console.WriteLine(numero);

            bool verdadeiro = bool.Parse("true");
            Console.WriteLine(verdadeiro);
        }

        public void AulaTryParse()
        {
            var numero = "13555";

            if (int.TryParse(numero, out int numeroConvertido))
            {
                Console.WriteLine("Número foi convertido com sucesso");
            }

            //Ou

            int numeroConvertido2;

            if (int.TryParse(numero, out numeroConvertido2))
            {
                Console.WriteLine("Número foi convertido com sucesso");
            }

            Console.WriteLine(numeroConvertido);
        }
    }
}
