int m = InputNumbers("Введите число строк (m): ");
int n = InputNumbers("Введите число столбцов (n): ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[,] array = new int[m, n];

createArray(array);
WriteArray(array);

Console.WriteLine();

NewArray(array);
WriteArray(array);

void NewArray(int[,] array)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            for(int num = 0; num < n - 1; num++)
            {
                if(array[i, num + 1] > array[i, num])
                {
                    int temporary = array[i, num + 1];
                    array[i, num + 1] = array[i, num];
                    array[i, num] = temporary;
                }
            }
        }
    }
}

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

void WriteArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}