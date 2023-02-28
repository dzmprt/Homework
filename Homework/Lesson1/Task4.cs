namespace Homework.Lesson1;

/// <summary>
/// Входные данные: строка, число повторений
/// Процесс: создать новую строку, которая является повторением введенной строки введенное количество раз.
/// В конце каждой строки кроме последней должен быть символ конца строки (“\n”)
/// Результат работы: созданная строка
/// </summary>
public class Task4
{
    public void Start()
    {
        // Получение входных данных из консоли
        Console.Write("Введите строку: ");
        string str = Console.ReadLine();
        
        Console.Write("Введите число повторений: ");
        string sCount = Console.ReadLine();

        // Вызов функции обработки данных
        var result = Process(str, sCount);
        
        // Вывод результата на консоль
        Console.WriteLine("Результат: " + result);
    }

    // Реализация обработки входных данных
    public string Process(string str, string sCount)
    {
        int count = Convert.ToInt32(sCount);
        string result = "";
        
        // Записать в переменную result итоговую строку
        
        // Для реализации подойдет цикл for (int i = 0; i < count; i++)

        return result;
    }
}