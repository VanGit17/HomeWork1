Console.WriteLine("давайте найдем максимальное из трех чисел ");
Console.Write("введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

if (a>b)
{
  if (a>c)
       { 
        Console.Write("наибольшее число: ");
        Console.Write(a);
        }
        else
        { Console.Write("наибольшее число: ");
        Console.Write(c);}
}
else
{
  if (b>c)
       { 
        Console.Write("наибольшее число: ");
        Console.Write(b);
        }
        else
        { Console.Write("наибольшее число: ");
        Console.Write(c);}  
}
//else 
//{
    //Console.Write("большее число: ");
//Console.WriteLine(b); 
////Console.Write("меньшее число: ");
//Console.WriteLine(a);  
//}
