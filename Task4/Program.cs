// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

int[] FillArray(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num + 1; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] size)
{
    Console.Write("{ ");
    foreach (int el in size)
    {
        Console.Write($"{el} ");
    }
    Console.Write("}");
    Console.WriteLine();
}

try
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[num];
    PrintArray(FillArray(num));
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}

