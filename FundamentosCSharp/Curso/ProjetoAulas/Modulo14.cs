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
    }
}
