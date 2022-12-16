int number = new Random().Next(10,100);
Console.WriteLine("Мы задумали число: ");
Console.WriteLine(number);

int a = (number - number%10)/10; //определим количество десятков в числе
int b = number - a*10; //определим количество единиц в числе

if (a>b)
{
Console.Write("Наибольшая цифра числа: ");
   Console.Write(a);
}
else  
{
Console.Write("Наибольшая цифра числа: ");
   Console.Write(b);
}
   