//Задача 2: Задайте массив на 10 целых чисел.
//Напишите программу, которая определяет
//количество чётных чисел в массиве.

int[] array = new int[10];
int result = 0;

for(int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(1, 99999);
    Console.Write(array[i] + " ");
    if(array[i]%2 == 0)
        result++;
}

Console.Write("=> " + result);