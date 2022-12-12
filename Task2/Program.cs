// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины
// Теорема о неравестве треугольника: каждая сторона треугольника меньше суммы двух других сторон

void Begin(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) Console.WriteLine($"Треугольник со сторонами равными {a}, {b} и {c} не может существовать");
    else Console.WriteLine($"Треугольник со сторонами равными {a}, {b} и {c} существует");
}

try
{
    Console.WriteLine("Введите длину стороны A");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите длину стороны B");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите длину стороны C");
    int c = Convert.ToInt32(Console.ReadLine());
    Begin(a, b, c);
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}
