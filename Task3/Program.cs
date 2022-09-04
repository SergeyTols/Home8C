int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы и строк 2-й: ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[,] firstMartrix = new int[m, n];

createArray(firstMartrix);
Console.WriteLine("Первая матрица:");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[n, p];

createArray(secondMartrix);
Console.WriteLine("Вторая матрица:");
WriteArray(secondMartrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);

Console.WriteLine("Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for(int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
                for(int k = 0; k < firstMartrix.GetLength(1); k++)
                {
                    sum += firstMartrix[i, k] * secondMartrix[k, j];
                }
                resultMatrix[i, j] = sum;
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