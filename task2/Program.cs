//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int promt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int x1 = promt("Введите координату x1");
int y1 = promt("Введите координату y1");
int z1 = promt("Введите координату z1");
int x2 = promt("Введите координату x2");
int y2 = promt("Введите координату y2");
int z2 = promt("Введите координату z2");

double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double S = ((x2 - x1)*(x2 - x1)) + ((y2 - y1)*(y2 - y1)) + ((z2 - z1)*(z2 - z1));
    double result = Math.Sqrt(S);
    return result;
}
Console.WriteLine($"Расстояние между точками равно {Dist(x1, y1, z1, x2, y2, z2)}");


