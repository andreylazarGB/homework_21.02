// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();

int[] Array = new int[num.Length];
for (int i = 0; i < num.Length; i++)
{
    Array[i] = int.Parse(num[i] + "");
}

void GetSumValue(int[] Number)
{
    int result = 0;
    for (int i = 0; i < Number.Length; i++)
    {
        result = result + Number[i];
    }
    Console.Write($"Сумма цифр в числе {num} = {result}");
}

GetSumValue(Array);




    