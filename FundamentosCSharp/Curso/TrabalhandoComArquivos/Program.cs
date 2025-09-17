using System.Text;

namespace TrabalhandoComArquivos
{
    public class Program
    {
        static void Main(string[] args)
        {
            var enderecoDoArquivo = "contas.txt";
            var numeroDeBytesLidos = -1;
            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
            var buffer = new byte[1024];

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            Console.WriteLine("Hello, World!");
        }

        static void EscreverBuffer(byte[] buffer)
        {
            var utf8 = new UTF8Encoding();

            var texto = utf8.GetString(buffer);
            Console.Write(texto);
        }
    }
}
