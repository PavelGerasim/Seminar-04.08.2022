Console.WriteLine("Введите первое число для проверки: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число для проверки: ");
int y = int.Parse(Console.ReadLine());
if(x*x == y) {
    Console.WriteLine("Yes");
}
else {
    Console.WriteLine("No");
}