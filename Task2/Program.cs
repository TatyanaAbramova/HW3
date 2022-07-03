// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки А:");
int ax = int.Parse(Console.ReadLine());
int ay = int.Parse(Console.ReadLine());
int az = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
int bx = int.Parse(Console.ReadLine());
int by = int.Parse(Console.ReadLine());
int bz = int.Parse(Console.ReadLine());

void printGipotenuza (double ax, double ay, double az, double bx, double by, double bz)
{
    double dx = ax - bx;
    double dy = ay - by;
    double dz = az - bz;
    double c = Math.Sqrt(dx * dx + dy * dy + dz * dz);
    System.Console.WriteLine(c);
}
printGipotenuza (ax, ay, az, bx, by, bz);