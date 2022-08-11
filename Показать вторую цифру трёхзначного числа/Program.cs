Console.WriteLine("Введите трёхзначное число: ");
int x = int.Parse(Console.ReadLine());
int y = 3;
int z = 1;
int y1 = 2;
int z1 = 1;

if(x > 99 && x < 1000)
{
    while(y > 1)
    {
        z *= 10;
        y--;
    }
    int x1 = (x % z) + (x / (z * 10)) * z;
    
    while(y1 > 1)
    {
        z1 *= 1;
        y1--;
    }
    int x2 = (x1 % z1) + (x1 / (z1 * 10)) * z1;
    Console.WriteLine(x2);
}
else
{
    Console.WriteLine("Это не трёхзначное число");
}