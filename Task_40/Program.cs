// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int c = Convert.ToInt32(Console.ReadLine());

bool ExistTriangle (int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}
bool result = ExistTriangle(a, b, c);
if (result) Console.WriteLine($"Triangle can exist");
else Console.WriteLine($"Triangle can not exist");
