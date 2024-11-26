class Program
{
    // Метод сортировки массива по возрастанию
    public static void SortAscending(int[] array)
    {
        Array.Sort(array);
    }

    // Метод сортировки массива по убыванию
    public static void SortDescending(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
    }

    // Метод объединения двух массивов в один
    public static int[] MergeArrays(int[] array1, int[] array2)
    {
        int[] mergedArray = new int[array1.Length + array2.Length];
        Array.Copy(array1, mergedArray, array1.Length);
        Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length);
        return mergedArray;
    }
    public static int CalculateDifference(int n)
    {
        int absoluteDifference = Math.Abs(n - 123);
        if (n > 123)
        {
            return absoluteDifference * 3; // Тройная абсолютная разность
        }
        else
        {
            return absoluteDifference; // Обратная разность
        }
    }

    static void Main()
    {
        int[] array1 = { 5, 3, 8, 1, 4 };
        int[] array2 = { 10, 7, 2 };

        // Сортировка по возрастанию
        SortAscending(array1);
        Console.WriteLine("Сортированный массив по возрастанию: " + string.Join(", ", array1));

        // Сортировка по убыванию
        SortDescending(array2);
        Console.WriteLine("Сортированный массив по убыванию: " + string.Join(", ", array2));

        // Объединение двух массивов
        int[] mergedArray = MergeArrays(array1, array2);
        Console.WriteLine("Объединенный массив: " + string.Join(", ", mergedArray));
        Console.Write("Введите целое число n: ");
        int n;
        if (int.TryParse(Console.ReadLine(), out n))
        {
            int result = CalculateDifference(n);
            Console.WriteLine("Результат: " + result);
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректное целое число.");
        }
    }
}
