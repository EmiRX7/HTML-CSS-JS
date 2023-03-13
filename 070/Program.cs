// Показать натуральные числа от n до 1

void WriteAll(int i)
{
    Console.Write(i);
    i=i-1;
    if (i > 0)
    WriteAll(i);
}

WriteAll(10);
Console.ReadLine();
