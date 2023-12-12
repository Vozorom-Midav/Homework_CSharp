//Задача 1: Задайте двумерный массив символов (тип char[,]).
//Создать строку из символов этого массива.

string GetCharString(char[,] myChar)
{
    string str = string.Empty;

    for(int i = 0; i<myChar.GetLength(0); i++)
        for(int j = 0; j<myChar.GetLength(1); j++)
        {
            str += myChar[i,j];
        }
    return str;
}


char[,] myChar = {{'a', 'b', 'c'},{'d', 'e', 'f'}};

string myText = GetCharString(myChar);

Console.WriteLine(myText);