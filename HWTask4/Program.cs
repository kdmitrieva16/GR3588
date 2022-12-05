// Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();

//  Проверяем, что бы данные были не пустыми
if (num1Line != null && num2Line != null && num3Line != null)
{
    // Парсим введенные числа
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    int num3 = int.Parse(num3Line);

    // Сравниваем и выводим максимальное
    int outLine = Math.Max(num1, Math.Max(num2, num3));
    Console.WriteLine("max=" + outLine);

}