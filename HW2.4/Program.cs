Console.Write("Введите пятизначное число ");
int numberA = int.Parse(Console.ReadLine());

int numberA_5 = numberA % 10;
int numberA_4 = numberA/10 % 10;
int numberA_2 = numberA/1000 % 10;
int numberA_1 = numberA/10000 % 10;

if ((numberA_2==numberA_4) && (numberA_1==numberA_5))
{
Console.WriteLine("Число палиндром");
}
else
{
Console.WriteLine("Число не палиндром");
}