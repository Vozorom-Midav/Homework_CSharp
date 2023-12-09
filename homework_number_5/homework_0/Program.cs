//Задача 1: Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание,
//что такого элемента нет.

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
    Console.WriteLine(message);

    for(int i = 0; i < printArray.GetLength(0); i++)
    {
        for(int j = 0; j<printArray.GetLength(1); j++)
                Console.Write(printArray[i , j] + "  ");
        Console.WriteLine("");
    }
}

int InformationRequest(string message)
{
    int number;
    while(true)
    {
        Console.WriteLine(message);
        string text = Console.ReadLine() + "";
        if(int.TryParse(text, out number))
            break;
    }
    return number;
}

bool CheckingArray(int[ , ] myArray, int column_number, int line_number)
{
    if(column_number >= myArray.GetLength(0) || line_number >= myArray.GetLength(1))
        return false;
    else if(column_number < 0 || line_number < 0)
        return false;
    else
        return true;
}

void PrintArrayElement(int [ , ] checkArray, int column_number, int line_number, bool check)
{
    if(check == true)
        Console.WriteLine("Найден элемент: " + checkArray[column_number, line_number]);
    else
        Console.WriteLine("Элемент не найден");
}
    

//Начало программы

int[ , ] myArr = CreateArray();
PrintArray("Получили массив: ", myArr);

int n1 = InformationRequest("Введите номер строки(Начинается с 0): ");
int n2 = InformationRequest("Введите номер столбца(Начинается с 0): ");

bool checkArr = CheckingArray(myArr, n1, n2);

PrintArrayElement(myArr, n1, n2, checkArr);

