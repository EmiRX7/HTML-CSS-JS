// 10 Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
int N, ost;
Console.Write("Введите число: ");
N=Convert.ToInt32(System.Console.ReadLine());
ost= N%10;
System.Console.WriteLine(ost);