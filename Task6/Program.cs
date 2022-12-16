Console.WriteLine("Введите трехзначное целое число: ");
int number = int.Parse(Console.ReadLine()!);
if (Math.Abs(number)>99&Math.Abs(number)<1000)
{
   int a = (number%100 - (number%100)%10)/10; 
    Console.Write("Вторая цифра числа: ");
   Console.WriteLine(Math.Abs(a));
 }
else
Console.WriteLine("извините, но это не трехзначное число, мы так не работаем! ");