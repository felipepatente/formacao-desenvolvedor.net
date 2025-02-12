using System.Collections;
using System.Runtime.InteropServices;

namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AulaClasses();
            //AulaPropriedadeSomenteLeitura();
            //AulaHeranca();
            //AulaClasseSelada();
            AulaClasseAbstrata();
        }

        private static void AulaClasses() 
        {
            var produto = new Produto();
            produto.SetId(1);
            produto.Descricao = "Teclado";

            produto.ImprimirDescricao();
            Console.WriteLine(produto.GetId());

            Console.WriteLine(Calculos.SomarNumeros(10, 20));
        }

        private static void AulaPropriedadeSomenteLeitura()
        {
            var produto = new Produto();
            produto.Descricao = "Mouse";
            //produto.Estoque = 1;
            Console.WriteLine(produto.Estoque);
        }

        private static void AulaHeranca() 
        { 
            var pessoaFisica = new PessoaFisica();
            pessoaFisica.Id = 1;
            pessoaFisica.Endereco = "Endereço Teste";
            pessoaFisica.Cidade = "Cidade Teste";
            pessoaFisica.Cep = "123456858";
            pessoaFisica.CPF = "405611008886";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCPF();

            Console.WriteLine("####################################");

            var funcionario = new Funcionario();
            funcionario.Id = 10;
            funcionario.Endereco = "Endereço Test";
            funcionario.Cidade = "Cidade Test";
            funcionario.Cep = "123456858";
            funcionario.CPF = "405611008886";
            
            funcionario.ImprimirDados();
            funcionario.ImprimirCPF();
        }

        private static void AulaClasseSelada()
        {
            var configuracao = new Configuracao()
            {
                Host = "localhost"
            };

            Console.WriteLine(configuracao.Host);
        }

        private static void AulaClasseAbstrata()
        {
            var cachorro = new Cachorro();
            cachorro.Nome = "Dog";
            cachorro.ImprimirDados();
        }
        
    }
}