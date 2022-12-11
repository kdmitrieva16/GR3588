int inputNumber = ReadData("Введите N: ");
string outLine = LineBuilder(inputNumber, 1);
PrintData("Исходная строка ", outLine);
string outLineSquare = LineBuilder(inputNumber, 2);
PrintData("Значения квадратов", outLineSquare);


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод выводит результат

void PrintData(string msg, string result)
{
    Console.WriteLine(msg + result);
}

// Метод конструирует строку

string LineBuilder(int numberN, int degree)
{
    string line = string.Empty;
    for (int i = 1; i < numberN; i++)
    {
        line = line + Math.Pow(i, degree) + " ";
    }
    line = line + Math.Pow(numberN, degree);
    return line;
}