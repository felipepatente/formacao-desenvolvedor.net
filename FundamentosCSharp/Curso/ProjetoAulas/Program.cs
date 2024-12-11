using System.Collections;

namespace ProjetoAulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            queue.Enqueue("Felipe");
            queue.Enqueue("Patente");

            Console.WriteLine(queue.Peek());

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}