Console.WriteLine("Введите трехзначное целое число: ");
int number = int.Parse(Console.ReadLine()!);
if (Math.Abs(number)>99&Math.Abs(number)<1000)
{
   int a = (number - number%100)/100; //определим сколько сотен в числе
   int b = ((number - a*100)-(number - a*100)%10)/10; //определим сколько десятков в числе
   int c = number - a*100 - b*10; //определим количество единиц в числе
   
   Console.Write("Последняя цифра числа: ");
   Console.WriteLine(Math.Abs(c));
 }
else
Console.WriteLine("извините, но это не трехзначное число, мы так не работаем! ");


