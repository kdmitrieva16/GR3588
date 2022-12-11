int quarter = ReadData("ВВедите номер четверти");

PrintCoord(quarter);


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод определяет четверть по координатам точки
void PrintCoord(int num)

{
    if (num > 0 && num < 5)
    {
        if (num == 1) Console.WriteLine("x>0 and y>0");
        if (num == 2) Console.WriteLine("x>0 and y<0");
        if (num == 3) Console.WriteLine("x<0 and y<0");
        if (num == 4) Console.WriteLine("x<0 and y>0");
    }
    else
    {
        Console.WriteLine("Введен не номер четверти");
    }
}