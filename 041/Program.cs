// 41 Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран


Console.Write("Введите числа: ");
int[] num = new int[8] {1, 0, 0, 0, 0, 1, 0, 1};
foreach (int i in num)
{
System.Console.Write($"{i} ");
}