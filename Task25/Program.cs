// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();

Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int GetDegreeOf(int num1, int num2)
{
    int result = 1;
    for(int i = 0; i < num2; i++)
    {
        result = result*num1;
    }
    return result;
}

Console.WriteLine($"Число {a} в степени {b} = {GetDegreeOf(a, b)}");
