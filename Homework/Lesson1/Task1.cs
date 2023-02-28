namespace Homework.Lesson1;

/// <summary>
/// Входные данные: два числа (могут быть как положительными, так и отрицательными, как дробными, так и целыми)
/// Процесс: вычисление суммы введенных чисел
/// Результат работы: сумма введенных пользователем чисел
/// </summary>
public class Task1
{
    public void Start()
    {
        // Получение входных данных из консоли
        Console.Write("Введите первое число: ");
        string strA = Console.ReadLine();

        Console.Write("Введите второе число: ");
        string strB = Console.ReadLine();

        // Вызов функции обработки данных
        var result = Process(strA, strB);
        
        // Вывод результата на консоль
        Console.WriteLine("Результат: " + result.ToString());
    }

    // Реализация обработки
    public double Process(string a, string b)
    {
        double result = 0;
        
        // Присвоить переменной result результат вычисления 
        
        return result;
    }
}