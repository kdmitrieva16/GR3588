
int coordX1 = ReadData("Введите координату Х первой точки: ");
int coordX2 = ReadData("Введите координату Х второй точки: ");
int coordY1 = ReadData("Введите координату Y первой точки: ");
int coordY2 = ReadData("Введите координату Y второй точки: ");
int coordZ1 = ReadData("Введите координату Z первой точки: ");
int coordZ2 = ReadData("Введите координату Z второй точки: ");

PrintData("Расстояние между точками ", CalculateLength(coordX1, coordX2, coordY1, coordY2, coordZ1, coordZ2));

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод рассчитывает расстояние между точками с заданными координатами
double CalculateLength(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)+Math.Pow((z1 - z2), 2) );
    return res;
}

// Метод выводит результат
void PrintData(string msg, double result)
{
    Console.WriteLine(msg + result);
}


