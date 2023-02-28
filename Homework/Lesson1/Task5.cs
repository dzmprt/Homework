namespace Homework.Lesson1;

// Входные данные: число
// Процесс: если число отрицательное, вернуть bool переменную со значением false, если положительное или 0, вернуть true.
// Использовать оператор if.
// Результат работы: значение переменной
public class Task5
{
    public void Start()
    {
        // Получение входных данных из консоли
        Console.Write("Введите число: ");
        string n = Console.ReadLine();

        // Вызов функции обработки данных
        var result = Process(n);
        
        // Вывод результата на консоль
        Console.WriteLine("Результат: " + result.ToString());
    }

    // Реализация обработки входных данных
    public bool Process(string n)
    {
        bool result = false;
        
        // Записать в переменную result результат

        return result;
    }
}