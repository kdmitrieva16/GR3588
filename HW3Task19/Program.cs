int inputNumber = ReadData("Введите пятизначное число: ");
if (IsNumberFiveDigits(inputNumber) == true)
{
    bool result = PalinTest(inputNumber);
    PrintData("Число " + inputNumber + " палиндром? ", result);
}
else
{
    ErrorMessage("Число " + inputNumber + " не пятизначное");
}


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод выводит результат

void PrintData(string msg, bool result)
{
    Console.WriteLine(msg + result);
}

//Метод выводит сообщение об ошибке

void ErrorMessage(string msg)
{
    Console.WriteLine(msg);
}

//Метод проверяет является ли введенное число пятизначным
bool IsNumberFiveDigits(int numN)
{
    bool result = false;
    result = ((int)Math.Log(numN, 10) + 1 == 5);
    return result;
}


// Метод проверяет является ли число палиндромом
bool PalinTest(int numN)
{
    bool result = false;
    result = (numN / 10000 == numN % 10) && ((numN / 1000) % 10 == (numN / 10) % 10);
    return result;
}
