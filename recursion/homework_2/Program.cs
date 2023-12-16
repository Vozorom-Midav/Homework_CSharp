//Задача 3: Задайте произвольный массив. Выведете
//его элементы, начиная с конца. Использовать
//рекурсию, не использовать циклы.


int [] CreateRandomArray ()
{
    int lengthArr = new Random().Next(3, 10);
    int [] myArr = new int[lengthArr];

    Console.Write("Исходный массив:");
    for(int i = 0; i<lengthArr; i++)
    {
        myArr[i] = new Random().Next(1, 100);
        Console.Write(" " + myArr[i]);
    }

    return myArr;
}

void PrintArrayElements (int[] myArr, int index)
{
    if(index>=0)
    {
        Console.Write(" " + myArr[index]);
        PrintArrayElements(myArr, index-1);
    }
}

int[] newArr = CreateRandomArray();

int index = newArr.Length - 1;

Console.WriteLine("");
Console.Write("Результат:");

PrintArrayElements(newArr, index);