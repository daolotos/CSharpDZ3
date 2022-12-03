using System;

Console.WriteLine("Введите 2 точки:");
int x1 = ReadInt("x1 = ");
int y1 = ReadInt("y1 = ");
int z1 = ReadInt("z1 = ");
int x2 = ReadInt("x2 = ");
int y2 = ReadInt("y2 = ");
int z2 = ReadInt("z2 = ");

double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Дистанция:" + distance);

int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int dx = x1 - x2;
    int dy = y1 - y2;
    int dz = z1 - z2;
    return Math.Sqrt(dx * dx + dy * dy + dz * dz);
}
