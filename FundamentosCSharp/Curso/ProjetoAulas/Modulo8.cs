namespace ProjetoAulas
{

    public static class Calculos 
    { 
        public static int SomarNumeros(int a, int b) => a + b; 
    }

    public class Produto
    {
        private int Id;
        public string Descricao { get; set; }

        //public readonly int Estoque;
        public int Estoque { get; }

        public Produto()
        {
            Estoque = 1;
        }

        public void ImprimirDescricao()
        {
            Console.WriteLine($"{GetId()} - {Descricao}");
        }

        public void SetId(int id) 
        { 
            Id = id;
        }
        public int GetId()
        {
            return Id;
        }
    }
}
