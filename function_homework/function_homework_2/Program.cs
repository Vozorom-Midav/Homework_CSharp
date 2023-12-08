//Задача 3: Напишите программу, которая перевернёт
//одномерный массив (первый элемент станет
//последним, второй – предпоследним и т.д.)

int[] CreateRandomArray()
{
    int count = new Random().Next(3, 15);
    int[] myArr = new int[count];
    for(int i = 0; i<count; i++)
    {
        myArr[i] = new Random().Next(1, 99);
    }
    return myArr;
}

void PrintArray(string message, int[] myArr)
{
    Console.WriteLine(message);
    for(int i = 0; i<myArr.Length; i++)
    {
        if(i<myArr.Length-1)
            Console.Write(myArr[i] + " ");
        else
            Console.WriteLine(myArr[i]);
    }
}


int[] SwapArray(int[] myArr)
{
    int swapNum;

    for(int i = 0; i<myArr.Length/2; i++)
    {
        swapNum = myArr[i];
        myArr[i] = myArr[myArr.Length-i-1];
        myArr[myArr.Length-i-1] = swapNum;
    }
    return myArr;
}



int[] randArr = CreateRandomArray();
PrintArray("Задан массив: ", randArr);
int[] swapArr = SwapArray(randArr);
PrintArray("Перевернутый массив: ", swapArr);