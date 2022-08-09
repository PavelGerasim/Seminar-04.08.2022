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
if(y > x && y >z)
{
    Console.WriteLine("Наибольшее число второе");
}
else{
    Console.WriteLine("Наибольшее число третье");
}