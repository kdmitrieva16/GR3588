double numK1 = ReadData("Input k1:");
double numB1 = ReadData("Input b1:");
double numK2 = ReadData("Input k2:");
double numB2 = ReadData("Input b2:");
double numK3 = ReadData("Input k3:");
double numB3 = ReadData("Input b3:");

(double coordX, double coordY) pointA = CoordIntersection(numK1, numB1, numK2, numB2);
(double coordX, double coordY) pointB = CoordIntersection(numK2, numB2, numK3, numB3);
(double coordX, double coordY) pointC = CoordIntersection(numK1, numB3, numK3, numB3);

double lengthAB=CalculateLength(pointA.coordX,pointB.coordX,pointA.coordY,pointB.coordY);
double lengthBC=CalculateLength(pointB.coordX,pointC.coordX,pointB.coordY,pointC.coordY);
double lengthAC=CalculateLength(pointA.coordX,pointC.coordX,pointA.coordY,pointC.coordY);
double area=AreaOfTriangle(lengthAB,lengthBC,lengthAC);

PrintData("Area of Triangle = " + area);

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

//Calculate length side of triange

double CalculateLength(double x1, double  x2, double  y1, double  y2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return res;
}

// Calculate area of ​​a triangle

double AreaOfTriangle(double a, double b, double c)
{
 double p=(a+b+c)/2;
 double s=Math.Sqrt(p*(p-a)*(p-b)*(p-c));
 return s;

}

