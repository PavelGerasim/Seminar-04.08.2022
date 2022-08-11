Console.WriteLine("Случайно нашёл способ не использовать сложные формулы, но первый вариант оставлю (я так долго его делал)");
Console.WriteLine("Введите трёхзначное число: ");
int x = int.Parse(Console.ReadLine());
int y = x % 10;

if(x > 99 && x < 1000)
{
    y = x / 10;
    int z = y;
    
    if(y > 9 && y < 100)
    {
        z = y % 10;
    }
Console.WriteLine(z);
}

else
{
    Console.WriteLine("Это число не трёхзначное");
}