Console.WriteLine("Укажите первое число диапазона");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите второе число диапазона");
int y = int.Parse(Console.ReadLine());
int count = x;
Console.WriteLine(" ");

while(count <= y)
{
    if(count <= y)
    {
        Console.Write(count + " ");
        count++;
    }
    if(count > y)
    {
        Console.WriteLine("Представлены все числа диапазона");
    }
}
Console.WriteLine(" ");