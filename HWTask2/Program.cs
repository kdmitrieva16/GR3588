
// Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

//  Проверяем, что бы данные были не пустыми
if (num1Line != null && num2Line != null)
{
    // Парсим введенные числа
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);

    // Сравниваем и выводим максимальное
    if (num1 > num2)
    {
        Console.WriteLine("max=" + num1);
    }
    else
    {
        Console.WriteLine("max=" + num2);
    }

}
