Console.WriteLine("Укажите трёхзначное число: ");
int x = int.Parse(Console.ReadLine());

if(x > 99 && x < 1000)
{
    Console.WriteLine(x % 10);
}
else
{
    Console.WriteLine("Это не трёхзначное число");
}