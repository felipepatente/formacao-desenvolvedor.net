﻿namespace ProjetoAulas
{
    public class TrabalhandoComArquivos
    {
        public void AulaCriandoArquivo() 
        {
            //var escrever = new StreamWriter("Cadastro.txt", true);
            var escrever = new StreamWriter("C:\\Users\\Felipe\\Downloads\\Cadastro.txt", true);
        
            Console.Write("Informe o nome: ");
            var nome = Console.ReadLine();

            escrever.WriteLine($"ID....: {Random.Shared.Next(1, 100)}");
            escrever.WriteLine($"Nome: {nome}");
            escrever.WriteLine("----------------------------------------");
            escrever.Close();
        }
    }
}
