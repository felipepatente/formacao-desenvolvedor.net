namespace ProjetoAulas
{

    public static class Calculos 
    { 
        public static int SomarNumeros(int a, int b) => a + b; 
    }

    public class Produto
    {
        private int Id;
        public string Descricao { get; set; }

        //public readonly int Estoque;
        public int Estoque { get; }

        public Produto()
        {
            Estoque = 1;
        }

        public void ImprimirDescricao()
        {
            Console.WriteLine($"{GetId()} - {Descricao}");
        }

        public void SetId(int id) 
        { 
            Id = id;
        }
        public int GetId()
        {
            return Id;
        }
    }

    public class Pessoa 
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set;}
        public string Cep { get; set; }

        public void ImprimirDados() 
        {
            Console.WriteLine($"Código: {Id}");
            Console.WriteLine($"Endereco: {Endereco}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Cep: {Cep}");
        }
    }

    public class PessoaFisica : Pessoa 
    { 
        public string CPF { get; set; }

        public void ImprimirCPF()
        {
            Console.WriteLine($"CPF: {CPF}");
        }
    }

    public class Funcionario : PessoaFisica
    {
        public string Matricula { get; set; }
    }

    public sealed class Configuracao
    {
        public string Host { get; set; }
    }

    //A linha abaixo da erro, pois a classe Configuracao é uma claasse sealed, este tipo de classe não é possível ser herdada
    //public class HerdarClasseSelada : Configuracao { }

    public abstract class Animal 
    {
        public string Nome { get; set; }
        public abstract string GetInformacoes();

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome do animal: {Nome}");
            Console.WriteLine($"Informações: {GetInformacoes()}");
        }
    }

    public class Cachorro : Animal
    {
        public override string GetInformacoes()
        {
            return "Cachorro é um bom amigo";
        }
    }
}
