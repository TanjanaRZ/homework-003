// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит
// их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int[] array = new int[8] { 1, 2, 5, 7, 19, 6, 1, 33 };
int i = 0;
while (i < 8)
{
    if (i == 4)
    {
        Console.WriteLine($"{array[i]} ");
    
    }
    else 
    {
        Console.Write($"{array[i]}, ");
    
    }
    i++;
}

Console.WriteLine();

