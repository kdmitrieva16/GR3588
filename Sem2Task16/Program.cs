// Метод проверяет является ли одно число квадратом другого
void NumberIsSQRT(int i, int j)
{
    bool result = (i / j == j);
    if (result == true) Console.WriteLine("Число " + i + " является квадратом числа " + j);
    else Console.WriteLine("Число " + i + " не является квадратом числа " + j);
}

// Считываем данные с консоли  проверяем на 0 и парсим
int number1 = int.Parse(Console.ReadLine() ?? "0");
int number2 = int.Parse(Console.ReadLine() ?? "0");


//Проверяем являются ли введенные числа квадратами
NumberIsSQRT(number1, number2);
NumberIsSQRT(number2, number1);