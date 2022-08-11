Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
int y = 3;
int z = 1;

while(y > 1)
{
    z *= 10;
    y--;
}
int x1 = (x % z) + (x / (z * 10)) * z;
Console.WriteLine(x1);