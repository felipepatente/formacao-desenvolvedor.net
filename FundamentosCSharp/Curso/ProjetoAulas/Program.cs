using System.Collections;

namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Rafael");
            arrayList.Add(true);

            //Console.WriteLine(arrayList[1]);

            arrayList.RemoveAt(0);
            arrayList.Clear();

            foreach (var item in arrayList) 
            {
                Console.WriteLine(item);
            }
        }
    }
}