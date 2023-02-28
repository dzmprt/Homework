namespace Homework.Lesson1;

/// <summary>
/// Входные данные: имя (строка)
/// Процесс: создать строку типа “Привет {имя}!” (восклицательный знак на конце)
/// Результат: Новая строка вида “Привет {имя}!”, например “Привет Дима!”
/// </summary>
public class Task3
{
    public void Start()
    {
        // Получение входных данных из консоли
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();

        // Вызов функции обработки данных
        var result = Process(name);
        
        // Вывод результата на консоль
        Console.WriteLine("Результат: " + result);
    }

    // Реализация обработки входных данных
    public string Process(string name)
    {
        string result = "";
        
        // Записать в переменную result итоговую строку

        return result;
    }
}