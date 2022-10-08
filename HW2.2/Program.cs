
Console.Write("Введите первое число ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int numberB = int.Parse(Console.ReadLine());

if (numberA < 0 || numberB < 0)
{
     Console.Writ16eLine($"Одно из чисел отрицательно, корня квадратного не имеет");
}
else
{
        if (numberB != Math.Sqrt(numberA))
        {
              Console.WriteLine($"Число {numberA} является квадратным корнем {numberB}");
        }
        else
        {
                  Console.WriteLine($"Число {numberA} не является квадратным корнем {numberB}");
        }
}
if (numberA < 0 || numberB < 0)
{
     Console.WriteLine($"Одно из чисел отрицательно, корня квадратного не имеет");
}
else
{
        if (numberA != Math.Sqrt(numberB))
        {
              Console.WriteLine($"Число {numberB} является квадратным корнем {numberA}");
        }
        else
        {
                  Console.WriteLine($"Число {numberB} не является квадратным корнем {numberA}");
        }
}