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
    }
}
