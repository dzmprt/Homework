namespace Homework.Lesson1;

/// <summary>
/// Входные данные: число, степень числа 
/// Процесс: возвести число в степень (использовать Math.Pow)
/// Результат работы: результат возведения числа в степень
/// </summary>
public class Task2
{
    public void Start()
    {
        // Получение входных данных из консоли
        Console.Write("Введите число: ");
        string strA = Console.ReadLine();

        Console.Write("Введите степень: ");
        string strB = Console.ReadLine();

        // Вызов функции обработки данных
        var result = Process(strA, strB);
        
        // Вывод результата на консоль
        Console.WriteLine("Результат: " + result.ToString());
    }

    // Реализация обработки входных данных
    public double Process(string a, string b)
    {
        double dA = Convert.ToDouble(a);
        double dB = Convert.ToDouble(b);
        double result = 0;
        
        // Присвоить переменной result значение степени 

        return result;
    }
}