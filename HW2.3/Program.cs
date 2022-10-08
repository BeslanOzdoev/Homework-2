    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четверть на координатной плоскости: ");
            double quarter = Convert.ToDouble(Console.ReadLine());
 
            if (quarter == 1)
                Console.WriteLine("И абсцисса, и ордината больше нуля");
            else
            {
                if (quarter == 2)
                Console.WriteLine("Абсцисса меньше нуля, ордината больше нуля");
                else
                {
                if (quarter == 3)
                Console.WriteLine("И абсцисса, и ордината меньше нуля");
                    else
                    {
                    if (quarter == 4)
                    Console.WriteLine("Абсцисса больше нуля, ордината меньше нуля");
                    }
                    
                }
            }
        }
    }
