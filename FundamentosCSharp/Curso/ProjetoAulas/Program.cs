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
            //AulaClasseAbstrata();
            //AulaRecord();
            //AulaInterface();
            //Conversores();
            //TrabalhandoComStrings();
            //TrabalhandoComDatas();
            //TrabalhandoComExcecoes();
            TrabalhandoComArquivos();
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

        private static void AulaRecord() 
        {
            var curso1 = new CursoRecord(){Id = 1, Descricao = "Curso"};
            var curso2 = new CursoRecord(){Id = 1, Descricao = "Curso" };

            Console.WriteLine(curso1 == curso2);
            Console.WriteLine(curso1.Equals(curso2));

            var curso3 = new CursoRecord2(1, "Curso");
            var curso4 = new CursoRecord2(1, "Curso");

            Console.WriteLine(curso3 == curso4);
            Console.WriteLine(curso3.Equals(curso4));

            Console.WriteLine("***************OUTRO EXEMPLO*******************");

            var cursoTeste1 = new CursoTeste() { Id = 1, Descricao = "Curso" };
            var cursoTeste2 = cursoTeste1 with { Descricao = "Teste Novo" };

            Console.WriteLine($"Id: {cursoTeste2.Id}, Descricao: {cursoTeste2.Descricao}");
        }

        private static void AulaInterface()
        {
            var notificacaoCliente = new NotificacaoCliente();
            notificacaoCliente.Notificar();
            notificacaoCliente.NotificarOutros();

            INotificacao notificacao = new NotificacaoFuncionario();
            notificacao.Notificar();            
        }

        private static void Conversores() 
        {
            var conversores = new Conversor();
            //conversores.ConvertAndParse();
            conversores.AulaTryParse();
        }

        private static void TrabalhandoComStrings() 
        {
            var trabalhandoComStrings = new TrabalhandoComStrings();
            //trabalhandoComStrings.ConverterParaLetrasMinusculas();
            //trabalhandoComStrings.ConverterParaLetrasMaiusculas();
            //trabalhandoComStrings.AulaSubstring();
            //trabalhandoComStrings.AulaRange();
            //trabalhandoComStrings.AulaContains();
            //trabalhandoComStrings.AulaTrim();
            //trabalhandoComStrings.AulaStartWithEndsWith();
            //trabalhandoComStrings.AulaReplace();
            trabalhandoComStrings.AulaLength();
        }

        private static void TrabalhandoComDatas() 
        {
            var trabalhandoComDatas = new TrabalhandoComDatas();
            //trabalhandoComDatas.AulaDateTime();
            //trabalhandoComDatas.AulaSubtraindoDatas();
            //trabalhandoComDatas.AulaAdicionandoDiasMesAno();
            //trabalhandoComDatas.AulaAdicionandoHoraMinutoSegundos();
            //trabalhandoComDatas.AulaDiaDaSemana();
            //trabalhandoComDatas.AulaDateOnly();
            trabalhandoComDatas.AulaTimeOnly();
        }

        private static void TrabalhandoComExcecoes() 
        {
            var trabalhandoComExcecoes = new TrabalhandoComExcecoes();
            //trabalhandoComExcecoes.AulaGerandoException();
            trabalhandoComExcecoes.AulaTratandoException();
        }

        private static void TrabalhandoComArquivos()
        {
            var trabalhandoComArquivos = new TrabalhandoComArquivos();
            trabalhandoComArquivos.AulaCriandoArquivo();
        }
    }
}