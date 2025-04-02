namespace AppClientes
{
    public class ClienteRepositorio
    {
        public List<Cliente> clientes = new List<Cliente>();

        public void ImprimirCliente(Cliente cliente)
        {
            Console.WriteLine($"ID....................: {cliente.Id}");
            Console.WriteLine($"Nome..................: {cliente.Nome}");
            Console.WriteLine($"Desconto..............: {cliente.Desconto.ToString("0.00")}");
            Console.WriteLine($"Data Nascimento.......: {cliente.DataNascimento}");
            Console.WriteLine($"Data Cadastro.........: {cliente.CadastradoEm}");
            Console.WriteLine("........................");
        }

        public void ExcluirCliente()
        {
            Console.Clear();
            Console.WriteLine("Informe o código do cliente: ");
            var codigo = Console.ReadLine();

            var cliente = clientes.FirstOrDefault(c => c.Id == int.Parse(codigo));

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado! [Enter]");
                Console.ReadKey();
                return;
            }

            ImprimirCliente(cliente);
            clientes.Remove(cliente);
            Console.WriteLine("Cliente removido com sucesso! [Enter]");
            Console.ReadKey();
        }

        public void ExibirClientes()
        {
            Console.Clear();
            clientes.ForEach(cliente => ImprimirCliente(cliente));
            Console.ReadKey();
        }

        public void CadastrarCliente()
        {
            Console.Write("Nome do cliente: ");
            var nome = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);

            Console.Write("Data de nascimento: ");
            var dataNascimento = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            Console.Write("Desconto: ");
            var desconto = Decimal.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            var cliente = new Cliente();
            cliente.Id = clientes.Count() + 1;
            cliente.Nome = nome;
            cliente.DataNascimento = dataNascimento;
            cliente.Desconto = desconto;
            cliente.CadastradoEm = DateTime.Now;

            clientes.Add(cliente);

            Console.WriteLine("Cliente cadastrado com sucesso! [Enter]");
            ImprimirCliente(cliente);
        }

        public void EditarCliente()
        {
            Console.Clear();
            Console.WriteLine("Informe o código do cliente: ");
            var codigo = Console.ReadLine();

            var cliente = clientes.FirstOrDefault(c => c.Id == int.Parse(codigo));

            if (cliente == null) 
            {
                Console.WriteLine("Cliente não encontrado! [Enter]");
                Console.ReadKey();
                return;
            }

            ImprimirCliente(cliente);

            Console.Write("Nome do cliente: ");
            var nome = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);

            Console.Write("Data de nascimento: ");
            var dataNascimento = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            Console.Write("Desconto: ");
            var desconto = Decimal.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);
            
            cliente.Nome = nome;
            cliente.DataNascimento = dataNascimento;
            cliente.Desconto = desconto;
            cliente.CadastradoEm = DateTime.Now;

            Console.WriteLine("Cliente alterado com sucesso! [Enter]");
            ImprimirCliente(cliente);
            Console.ReadKey();
        }
    }
}
