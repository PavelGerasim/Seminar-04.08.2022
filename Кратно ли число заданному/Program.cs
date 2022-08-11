Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число для проверки кратности: ");
int y = int.Parse(Console.ReadLine());

if(y % x == 2)
{
    Console.WriteLine("Да, второе число кратно первому");
}
else
{
    Console.WriteLine("Нет, кратности не наблюдается");
}