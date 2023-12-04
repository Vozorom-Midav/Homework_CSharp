//Задача 2: Задайте массив заполненный случайными
//трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в
//массиве.


int[] RandomArr (string message)
{
    int count = new Random().Next(2, 15);
    int[] arr = new int[count];

    Console.WriteLine(message);

    for(int i = 0; i<count; i++)
    {
        arr[i] = new Random().Next(100, 999);
        Console.Write(" " + arr[i]);
    }
    Console.WriteLine("");
    return arr;
}

int EvenNum (int[] RandomArray, string message)
{
    int counter = 0;

    Console.WriteLine(message);

    for(int i = 0; i<RandomArray.Length; i++)
    {
        if(RandomArray[i]%2 == 0)
            counter++;
    }
    Console.Write(counter);
    return counter;
}

int[] myArray = RandomArr("Случайный массив:");
int counter = EvenNum(myArray, "Количество четных чисел в массиве: ");

