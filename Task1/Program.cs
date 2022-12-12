// Задача 39. Напишите программу, которая перевернет зеркально одномерный массив,
// первый элемент станет последним и так далее

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

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(-20, 21);
//     return array;
// }

void FillArray1(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(-20, 21);
}

void Reverse(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n / 2; i++)
    {
        int temp = 0;
        temp = array[i];
        array[i] = array[n - i - 1];
        array[n - i - 1] = temp;
    }
}

try
{
    // Console.WriteLine("Введите размерность массива");
    // int size = Convert.ToInt32(Console.ReadLine());
    // int[] array = FillArray(size);
    int[] array = new int[5];
    Console.WriteLine($"Сгенерирован массив из {5} элементов:");
    FillArray1(array);
    PrintArray(array);
    Console.WriteLine($"Первоначальный массив будет перевернут:");
    Reverse(array);
    PrintArray(array);
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}