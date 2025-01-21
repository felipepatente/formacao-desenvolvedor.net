using System.Collections;
using System.Runtime.InteropServices;

namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AulaClasses();
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
    }
}