namespace ProjetoAulas
{
    public class TrabalhandoComLinq
    {
        public void AulaWhere()
        {
            var nomeCompleto = "RAFAEL ALMEIDA";

            Func<char, bool> filtro = c => c == 'A';

            //var resultado = nomeCompleto.Where(p => p == 'A');
            //var resultado = nomeCompleto.Where(filtro);
            var resultado = from c in nomeCompleto
                            where c == 'A'
                            select c;

            resultado.ToList().ForEach(p => { Console.WriteLine(p); });

            var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

            var resultadoNumeros = numeros.Where(n => n >= 10);

            resultadoNumeros.ToList().ForEach(n => Console.WriteLine(n));
        }

        public void AulaOrdenacao()
        {
            var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
            var resultado = numeros.OrderBy(n => n);

            resultado.ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine("------------------------");
            numeros.OrderBy(n => n).ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine("------------------------");
            numeros.OrderByDescending(n => n).ToList().ForEach(n => Console.WriteLine(n));
        }

        public void AulaTake()
        {
            var numeros = new int[] { 10, 6, 5, 50, 15, 2, 40 };
            var resultado = numeros.Where(n => n >= 10).Take(4).OrderBy(n => n);

            resultado.ToList().ForEach(n => Console.WriteLine(n));
        }

        public void AulaCount()
        {
            var numeros = new int[] { 10, 6, 5, 50, 15, 2, 40 };

            //var resultado = numeros.Count();
            var resultado = numeros.Count(n => n > 10);

            Console.WriteLine(resultado);
        }
    }
}
