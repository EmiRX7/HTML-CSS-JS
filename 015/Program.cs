// 15  С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

int a, ost;
Console.Write("Введите число: ");
a=Convert.ToInt32(System.Console.ReadLine());
if(a>100)
{
    if(a<1000)
    {
        ost= a/100;
        System.Console.WriteLine(ost); 
    }
    else
    {
        ost=a/100;
        ost=ost%10;
        System.Console.WriteLine(ost);
    }
}
else
System.Console.WriteLine("NO");