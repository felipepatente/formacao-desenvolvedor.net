namespace ProjetoAulas
{
    public class TrabalhandoComDatas
    {
        public void AulaDateTime()
        {
            var date1 = new DateTime(2012, 12, 02, 19, 22, 23);
            var date2 = DateTime.Parse("2022/12/22 19:25:23");
            var date3 = DateTime.Now;
            var date4 = DateTime.Today;

            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
            Console.WriteLine(date4);

            Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));

            var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
            Console.WriteLine(dateOffset1.LocalDateTime);
            Console.WriteLine(dateOffset1.UtcDateTime);
        }

        public void AulaSubtraindoDatas()
        {
            var date1 = DateTime.Now;
            var date2 = DateTime.Parse("2025-02-20");

            //var diff = date1 - date2;
            var diff = date1.Subtract(date2);

            Console.WriteLine(diff.TotalDays);
            Console.WriteLine(diff.TotalHours);

            //mostrando valor independentemente se é negativo ou positivo
            Console.WriteLine(Math.Abs(diff.TotalDays).ToString("f0"));
            Console.WriteLine(Math.Abs(diff.TotalHours).ToString("f0"));
        }

        public void AulaAdicionandoDiasMesAno()
        {
            var date1 = DateTime.Now;

            Console.WriteLine(date1.AddDays(10).ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine(date1.AddMonths(3).ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine(date1.AddYears(3).ToString("dd-MM-yyyy HH:mm:ss"));

            Console.WriteLine(date1.AddDays(10));
            Console.WriteLine(date1.AddMonths(3));
            Console.WriteLine(date1.AddYears(3));
        }
    }
}
