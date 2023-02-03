// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = Coordinate("X","A");
int y1 = Coordinate("Y","A");
int z1 = Coordinate("Z","A");
int x2 = Coordinate("X","B");
int y2 = Coordinate("Y","B");
int z2 = Coordinate("X","B");

double Calculator(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double action1 = Math.Pow(x2-x1, 2);
    double action2 = Math.Pow(y2-y1, 2);
    double action3 = Math.Pow(z2-z1, 2);
    double result = Math.Sqrt(action1 + action2 + action3);
    return result;
}
double segmentLength = Calculator(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"Длина отрезка равна > {segmentLength:F3}");
