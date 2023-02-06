// 20 Дано число. Проверить кратно ли оно 7 и 23

int a, b, c;
Console.Write("Введите число: ");
do
{
  a = Convert.ToInt32(System.Console.ReadLine());
  b = a%23;
  c = a%7;
}
while (b > 1 | c > 1);

Console.WriteLine($"{a} кратно 7 и 23");