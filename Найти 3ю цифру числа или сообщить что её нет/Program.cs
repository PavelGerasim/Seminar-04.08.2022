Console.WriteLine("Укажите число: ");
int x = int.Parse(Console.ReadLine());
int y = x / 10;
int z = y;

if(x > 999)
{
    while(x > 999)
    {
        x = x / 10;
        y = x;
    }
    
    if(y > 99 && y <= 999)
    {
        z = y % 10;
    }
Console.WriteLine(z);
}
else
{
    Console.WriteLine("Число меньше трёхзначного");
}
