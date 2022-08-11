Console.WriteLine("Укажите трёхзначное число: ");
int x = int.Parse(Console.ReadLine());
int y = x;

if(x > 99)
{
    y = x % 11;

    Console.WriteLine(y);
}
else
{
    Console.WriteLine("Это число меньше трёхзначного");
}