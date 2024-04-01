using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем размер массива
        Console.WriteLine("Введите размер массива:");
        int size = int.Parse(Console.ReadLine());

        // Создаем массив заданного размера
        string[] inputArray = new string[size];

        // Заполняем массив элементами, введенными с клавиатуры
        Console.WriteLine($"Введите {size} элементов массива:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            inputArray[i] = Console.ReadLine();
        }

        // Считаем количество строк, удовлетворяющих условию
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужного размера
        string[] resultArray = new string[count];

        // Заполняем новый массив строками, удовлетворяющими условию
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        // Выводим результат
        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }
}
