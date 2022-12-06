Console.WriteLine("Введите коодинаты x,y,z первой точки через пробел:");
double[] point1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
Console.WriteLine("Введите коодинаты x,y,z второй точки через пробел:");
double[] point2 = Console.ReadLine().Split().Select(double.Parse).ToArray();
double L=Math.Pow((point1[0]-point2[0]),2)+Math.Pow((point1[1]-point2[1]),2)+Math.Pow((point1[2]-point2[2]),2);
Console.WriteLine("Расстояние между точками: "+Math.Sqrt(L));
