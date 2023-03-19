// 
Console.WriteLine("Введите 4 строки");
string[] stroki = new string[4];
string[] strokiSort = new string[4];
for(int i=0; i<4; i++)
{
    string n;
    n = Console.ReadLine();
    stroki[i]=n;
    int m=0;
    for(int j=0; j<n.Length; j++)
        m++;
    if(m<4)
    {
        strokiSort[i]=n;
    }
}
for(int i=0; i<stroki.Length; i++)
    Console.Write($"{stroki[i]} ");
for(int i=0; i<stroki.Length; i++) 
    Console.Write($"{strokiSort[i]} ");
