Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int z = int.Parse(Console.ReadLine());
if(x > y && x > z)
{
    Console.WriteLine("Наибольшее число первое" );
}
if(y > x && y > z)
{
    Console.WriteLine("Наибольшее число второе");
}
if(z > x && z > y)
{
    Console.WriteLine("Наибольшее число третье");
}
if(x == y && x > z)
{
    Console.WriteLine("Наибольшие числа первое и второе");
}
if(x == z && x > y)
{
    Console.WriteLine("Наибольшие числа первое и третье");
}
if(y == z && y > x)
{
    Console.WriteLine("Наибольшие числа второе и третье");
}
if(x == y && x == z)
{
    Console.WriteLine("Числа равны");
}