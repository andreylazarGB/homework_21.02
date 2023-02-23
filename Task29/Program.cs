// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] collection)
{
    int num = collection.Length;
    int index = 0;
    while (index < num)
    {
        collection[index] = new Random().Next(1, collection.Length);
        index++;
    }
}


void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int [] Array = new int [num];

FillArray(Array);
PrintArray(Array);