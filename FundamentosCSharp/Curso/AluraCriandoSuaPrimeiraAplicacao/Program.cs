using FormacaoAluraProgramandoComOrientacaoObjetos.DominandoOrientacaoObjeto;
using static System.Net.WebRequestMethods;

namespace FormacaoAluraProgramandoComOrientacaoObjetos
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MostrandoTextoEstiloso();
            //MostrandoListaSemUsoDeLoop();
            ExecutandoMenu();

        }

        static void MostrandoTextoEstiloso()
        {
            //https://fsymbols.com/pt/geradores/
            Console.WriteLine
             (@"
                
                    ███╗░░░███╗██╗░░░██╗██╗████████╗░█████╗░  ████████╗░█████╗░██████╗░
                    ████╗░████║██║░░░██║██║╚══██╔══╝██╔══██╗  ╚══██╔══╝██╔══██╗██╔══██╗
                    ██╔████╔██║██║░░░██║██║░░░██║░░░██║░░██║  ░░░██║░░░██║░░██║██████╔╝
                    ██║╚██╔╝██║██║░░░██║██║░░░██║░░░██║░░██║  ░░░██║░░░██║░░██║██╔═══╝░
                    ██║░╚═╝░██║╚██████╔╝██║░░░██║░░░╚█████╔╝  ░░░██║░░░╚█████╔╝██║░░░░░
                    ╚═╝░░░░░╚═╝░╚═════╝░╚═╝░░░╚═╝░░░░╚════╝░  ░░░╚═╝░░░░╚════╝░╚═╝░░░░░
             ");
        }
    
        static void MostrandoListaSemUsoDeLoop()
        {
            var nomes = new List<string>() { "Felipe", "Roberto", "Rose", "Jennie", "Tzui", "Mono" };

            Console.WriteLine(string.Join(", ", nomes));
        }

        static void ExecutandoMenu() 
        {
            var menu = new MenuFilho();
            menu.Executar();
        }
    }
}