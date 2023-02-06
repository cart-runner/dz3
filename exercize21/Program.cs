// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

System.Console.WriteLine("введите координату x1");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите координату x2");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите координату y1");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите координату y2");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите координату z1");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите координату z2");
int z2 = Convert.ToInt32(Console.ReadLine());


double A = Math.Pow(x2 - x1, 2);
double B = Math.Pow(y2 - y1, 2);
double C = Math.Pow(z2 - z1, 2);

double num = Math.Sqrt(A + B + C);
Console.WriteLine($"расстояние {num}");




