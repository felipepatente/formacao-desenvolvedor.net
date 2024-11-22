using System.Collections;

namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var arrayTipadoNumero = new int[3] { 1, 2, 3 };

            var arrayTipadoNumero = new int[3];

            arrayTipadoNumero[0] = 5;
            arrayTipadoNumero[1] = 5;
            arrayTipadoNumero[2] = 10;

            //aumentado o array para 100
            Array.Resize(ref arrayTipadoNumero, 7);

            arrayTipadoNumero[6] = 10;

            foreach (var item in arrayTipadoNumero)
            {
                Console.WriteLine(item);
            }
        }
    }
}