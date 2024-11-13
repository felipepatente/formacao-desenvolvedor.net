namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numero1 = 1;
            var numero2 = 2;

            bool ativo = true;
            string status = ativo ? "Cadastro Ativo" : "Cadastro inativo";            
            Console.WriteLine(status);
        }
    }
}