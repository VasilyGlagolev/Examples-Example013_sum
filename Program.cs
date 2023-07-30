// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A (через запятую):");
string[] coordsAStr = Console.ReadLine().Split(',');
double xA = double.Parse(coordsAStr[0]);
double yA = double.Parse(coordsAStr[1]);
double zA = double.Parse(coordsAStr[2]);

Console.WriteLine("Введите координаты точки B (через запятую):");
string[] coordsBStr = Console.ReadLine().Split(',');
double xB = double.Parse(coordsBStr[0]);
double yB = double.Parse(coordsBStr[1]);
double zB = double.Parse(coordsBStr[2]);

double distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
Console.WriteLine($"Расстояние между точками A({xA},{yA},{zA}) и B({xB},{yB},{zB}) равно {distance:F2}");