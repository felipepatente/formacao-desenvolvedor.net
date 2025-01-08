using System.Collections;
using System.Runtime.InteropServices;

namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 10;

            while (i < 10) 
            { 
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("--------------");

            var j = 10;

            do
            {
                Console.WriteLine(j);
                j++;

            }while(j < 10);
        }
    }
}