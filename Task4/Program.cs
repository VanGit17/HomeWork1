Console.WriteLine("является ли число чётным?");
Console.Write("введите целое число: ");
int a = int.Parse(Console.ReadLine()!);

if (a%2==0)
{
  Console.Write("Ну конечно! Это число чётное ");

}
else 
{
    Console.Write("Нет, число не чётное");

}
