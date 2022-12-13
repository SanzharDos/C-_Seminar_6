// Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

try
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    // PrintArray(CreateArray(num));
    string res = "";
    while (num > 0)
    {
        res = Convert.ToString(value: num % 2) + res;
        num = num / 2;
    }
    Console.Write($"{res}");
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}