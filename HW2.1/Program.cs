    public enum DayOfWeek
    {
        Понедельник = 0,
        Вторник = 1,
        Среда = 2,
        Четверг = 3,
        Пятница = 4,
        Суббота = 5,
        Воскресенье = 6
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("n=");
            var n = int.Parse(Console.ReadLine());
             Console.WriteLine((DayOfWeek)((n - 1) % Enum.GetValues(typeof(DayOfWeek)).Length));

             if (n > 5)
{
    Console.Write("выходной");
}
else
{
    Console.Write("будний");
}
        }
    }
