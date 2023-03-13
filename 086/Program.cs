// 86 Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

Console.WriteLine("Напишите текст");
string text = Console.ReadLine();
int kol=0;
for(int i = 0; i < text.Length; i++)
{
    if(text[i] == 'a')
    {
        kol++;
    }
}
System.Console.WriteLine("Буква a встречается " + kol + " раз" );
