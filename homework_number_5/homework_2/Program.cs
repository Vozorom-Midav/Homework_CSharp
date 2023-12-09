//Задача 3: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с
//наименьшей суммой элементов.

//Объявление функций
int[ , ] CreateArray()
{
    int n1 = new Random().Next(2, 5);
    int n2 = new Random().Next(n1, 10);

    int[ , ] newArray = new int[n1 , n2];

    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j<newArray.GetLength(1); j++)
        {
            newArray[i,j] = new Random().Next(1, 15);
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

int ResultNumberElement(int[,] myArray)
{
    int[] summLine = new int[myArray.GetLength(0)];
    int result = 0;

    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        summLine[i] = 0;
        for(int j = 0; j<myArray.GetLength(1); j++)
            summLine[i] += myArray[i,j];
    }

    Console.WriteLine("");
    Console.WriteLine("Массив сумм: ");
    for(int i=0; i<summLine.Length; i++)
        Console.WriteLine(summLine[i]);

    Console.WriteLine("");
    for(int i = 1; i<summLine.Length; i++)
    {
        if(summLine[i]<summLine[i-1])
            result = i;
    }

    return result;
}


//Начало программы

int[ , ] myArr = CreateArray();
PrintArray("Исходный массив: ", myArr);

int result = ResultNumberElement(myArr);
Console.WriteLine("Минимальная сумма в строке с индексом: " + result);