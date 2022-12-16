Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("А теперь давайте проверим как оно делится на число, которое вы введете сейчас: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1%num2==0)
{
  Console.Write("Ура число делится нацело!Но сколько получится я не скажу, потому что меня об этом не просили.") ; 
}
else 
{
Console.Write("очень жаль, но число нацело не делится. Остаток от деления:");
Console.Write(num1%num2);
}

