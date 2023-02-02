// 4. По заданному с клавиатуры номеру дня недели вывести его название

int a;
Console.Write("Напишите номер дня недели от 1 до 7: ");
a=Convert.ToInt32(Console.ReadLine());
if (a==1)
    Console.WriteLine("Сегодня понедельник ");
if (a==2)
    Console.WriteLine("Сегодня вторник ");
if (a==3)
    Console.WriteLine("Сегодня среда ");
if (a==4)
    Console.WriteLine("Сегодня четверг ");
if (a==5)
    Console.WriteLine("Сегодня пятница ");
if (a==6)
    Console.WriteLine("Сегодня суббота ");
if (a==7)
    Console.WriteLine("Сегодня воскресенье ");