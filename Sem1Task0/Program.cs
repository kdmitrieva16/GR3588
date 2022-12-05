
// Считываем данные с консоли
string? inputLine =Console.ReadLine();

//  Проверяем, что бы данные были не пустыми
if(inputLine!=null)
{
    // Парсим введенное число
    int inpunNumber=int.Parse(inputLine);

    // Находим квадрат числа 
    int outResult=(int)Math.Pow(inpunNumber,2);
    
    // Выводим данные в консоль
    Console.WriteLine(outResult);
}
