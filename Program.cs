//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.WriteLine("Введите размер матрицы");
int arraySize = int.Parse(Console.ReadLine()!);
int[,] spiralArray = new int[arraySize, arraySize];
int number = 1;
int i = 0;
int j = 0;
while (number <= arraySize * arraySize)
{
    spiralArray[i, j] = number;
    if (i <= j + 1 && i + j < arraySize - 1)
        j++;
    else if (i < j && i + j >= arraySize - 1)
        i++;
    else if (i >= j && i + j > arraySize - 1)
        j--;
    else
        i--;
    number++;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintArray(spiralArray);