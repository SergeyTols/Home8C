// Я решил попробовать "квадратный" массив)

int m = InputNumbers("Введите количество строк и столбцов: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[,] array = new int[m, m];

createArray(array);
WriteArray(array);

int SumLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
        
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sumLine += array[i, j];
        }
    return sumLine;
}  
    
int minSumLine = 0;

int sumLine = SumLine(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLine(array, i);
            
            if (sumLine > tempSumLine)
            {
                sumLine = tempSumLine;
                minSumLine = i;
            }
    }

Console.WriteLine($"Cтрокa с наименьшей суммой элементов: {minSumLine + 1}");

void createArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, range);
        }
    }
}

void WriteArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int number = array[i, j];
            Console.Write(number + "  ");
        }
        Console.WriteLine();
    }
}
