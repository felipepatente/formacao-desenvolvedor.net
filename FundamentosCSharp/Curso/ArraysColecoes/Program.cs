using System.Collections;

namespace ArraysColecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var generica = new Generica<int>();
            generica.MostrarMensagem(23);

            var generica2 = new Generica<string>();
            generica2.MostrarMensagem("Teste 23");
        }
    }
}