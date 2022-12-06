string Proverka(string arg)
{
    int number1=int.Parse(arg);    
    int count=0;
    int ostatok=number1;
    //считаем количество цифр
   while (ostatok>0)
        {
            ostatok=number1/((int) Math.Pow(10,count));
            count++;
        }
    int[] array=new int[count];
    count=count-1;
    //разбиваем на массив
    for (int i=0; i<count; i++)
        {
            array[i]=number1/((int) Math.Pow(10, i))-(number1/((int) Math.Pow(10, i+1)))*10;
        }
    //проверяем на палиндромность
    int razmer=count-1;
    count=0;
        while (count<=razmer/2)
    {
        if (array[count]==array[razmer-count])
        {
            count=count+1;
            arg="Палиндром";
        }
        else
        {
            arg="Не палиндром";
            break;
        }
    }
    return arg;
}
Console.WriteLine("Введите число:");
string number=Console.ReadLine()!;
Console.WriteLine(Proverka(number));
