double numK1 = ReadData("Input k1:");
double numB1 = ReadData("Input b1:");
double numK2 = ReadData("Input k2:");
double numB2 = ReadData("Input b2:");
(double coordX, double coordY) crossPoint = CoordIntersection(numK1, numB1, numK2, numB2);
PrintData("x: " + crossPoint.coordX + ", y: " + crossPoint.coordY);

//Input data
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Print Result

void PrintData(string res)
{
    Console.WriteLine(res);
}

//Find coord x,y  for intersection point

(double x, double y) CoordIntersection(double k1, double b1, double k2, double b2)
{
    double x;
    double y;
    if (k1 != k2)
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * (b2 - b1) / (k1 - k2) + b1;
    }
    else
    {
        Console.Write("No intersection point ");
        x = 0;
        y = 0;
    }

    return (x, y);
}

