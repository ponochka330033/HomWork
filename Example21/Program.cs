Console.Write ("Variable x1");
int x1 = int.Parse (Console.ReadLine () ??"");
Console.Write ("Variable y1");
int y1 = int.Parse (Console.ReadLine () ??"");
Console.Write ("Variable z1");
int z1 = int.Parse (Console.ReadLine () ??"");
Console.Write ("Variable x2");
int x2 = int.Parse (Console.ReadLine () ??"");
Console.Write ("Variable y2");
int y2 = int.Parse (Console.ReadLine () ??"");
Console.Write ("Variable z2");
int z2 = int.Parse (Console.ReadLine () ??"");

double distance = GetDistance (x1, y1, z1, x2, y2, z2);

Console.WriteLine (distance);


static double GetDistance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    int resultx = x2 - x1;
    int resulty = y2 -y1;
    int resultz = z2 - z1;
    double distance = Math.Sqrt(resultx * resultx +resulty * resulty + resultz * resultz);
    return distance;
}
