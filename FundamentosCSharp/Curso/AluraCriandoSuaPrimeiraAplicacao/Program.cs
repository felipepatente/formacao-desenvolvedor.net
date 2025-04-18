using static System.Net.WebRequestMethods;

namespace FormacaoAluraProgramandoComOrientacaoObjetos
{
    public class Program
    {
        static void Main(string[] args)
        {
            MostrandoTextoEstiloso();
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
    }
}