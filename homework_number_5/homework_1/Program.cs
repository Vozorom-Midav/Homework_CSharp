//Задача 2: Задайте двумерный массив. Напишите
//программу, которая поменяет местами первую и
//последнюю строку массива.


//Объявление функций
int[ , ] CreateArray()
{
    int n1 = new Random().Next(2, 10);
    int n2 = new Random().Next(2, 10);

    int[ , ] newArray = new int[n1 , n2];

    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j<newArray.GetLength(1); j++)
        {
            newArray[i,j] = new Random().Next(1, 999);
        }      
    }
    return newArray;
}

void PrintArray(string message, int [ , ] printArray)
{
    Console.WriteLine("");
    Console.WriteLine(message);

    for(int i = 0; i < printArray.GetLength(0); i++)
    {
        for(int j = 0; j<printArray.GetLength(1); j++)
                Console.Write(printArray[i , j] + "  ");
        Console.WriteLine("");
    }
}

int[ , ] SwapLinesInArray(int[ , ] myArray)
{
    int[ , ] swapArray = new int[myArray.GetLength(0), myArray.GetLength(1)];
    for(int i = 0; i < myArray.GetLength(0); i++)
        for(int j = 0; j <myArray.GetLength(1); j++)
            {
                if(i == 0)
                    swapArray[i , j] = myArray[myArray.GetLength(0)-1, j];
                else if(i == myArray.GetLength(0) - 1)
                    swapArray[i , j] = myArray[0, j];
                else
                    swapArray[i, j] = myArray[i, j];
            }
            return swapArray;
}


//Начало программы

int[ , ] myArr = CreateArray();
PrintArray("Исходный массив: ", myArr);

int [ , ] newArr = SwapLinesInArray(myArr);
PrintArray("Новый массив: ", newArr);