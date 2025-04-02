namespace AppClientes
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                Console.ReadKey();
            }
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - Cadastro Cliente");
            Console.WriteLine("2 - Exibir Clientes");
            Console.WriteLine("3 - Editar Cliente");
            Console.WriteLine("4 - Excluir Cliente");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("--------------------");
        }
    }
}