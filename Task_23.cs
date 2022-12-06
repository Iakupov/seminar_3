void Third(int Length)
{
    Console.WriteLine("Таблица кубов:");
    int index=1;
    while (index < Length)
    {
        Console.WriteLine(index + "-" + Math.Pow(index,3));
        index++;
    }
} 
Console.WriteLine("Введите число N");
int N=int.Parse(Console.ReadLine()!);
Third(N);
