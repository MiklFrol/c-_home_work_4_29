// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();

int [] generateArray (int lenght, int start, int end)
{
    int [] result = new int [lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}

void printArray(int[] array)
{
     Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write($"[");
    Console.ResetColor();
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length -1)
        {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write($"{array[i]},");
        Console.ResetColor();
        }
        else
        {
           Console.ForegroundColor = ConsoleColor.DarkCyan;
           Console.Write($"{array[i]}]"); 
           Console.ResetColor();
        }
    }
}

int[] array =  generateArray(8, 1, 99);
printArray(array);

