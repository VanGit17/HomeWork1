Console.WriteLine("А давайте проверим, является ли первое число квадратом второго! ");
Console.Write("введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if (a==b*b)
{
  Console.Write("Ух ты! Первое число дейcтвительно квадрат второго! бывает же! ");

}
else 
{
    Console.Write("Нет, конечно нет... обычные числа. ");

}
