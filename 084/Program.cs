// 84 Проверить на число и найти сумму цифр числа

string chislo = Console.ReadLine();
int sum=0;
for(int i = 0; i < chislo.Length; i++)
{
    if(char.IsDigit(chislo[i]))
    {
        sum += chislo[i] - 48;
        Console.WriteLine(sum);
    }
    else 
    Console.WriteLine("Ne chislo");
}