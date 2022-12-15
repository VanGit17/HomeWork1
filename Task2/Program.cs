

Console.Write("введите номер дня недели: ");
int a = int.Parse(Console.ReadLine()!);
//Console.Write("введите второе число: ");
//nt b = int.Parse(Console.ReadLine()!);

if(a<8&a>0)
{
          if (a==1)
                 {  Console.Write("Это понедельник");
                    }
        if (a==2)
                 {  Console.Write("Это вторник");
                  }
         if (a==3)
         {  Console.Write("Это среда");
          }
         if (a==4)
         {  Console.Write("Это четверг");
         }
        if (a==5)
        {  Console.Write("Это пятница. Хороший всё-таки день!");
          }
       if (a==6)
          {  Console.Write("Это суббота");
            }
        if (a==7)
        {  Console.Write("Это воскресение. Раньше вообще неделя начиналась с него! Но если бы я так считал проверяющий решил бы, что программа не работает");
          }
}
else
   Console.Write("Да никакой это не день недели! Не морочьте голову!");      