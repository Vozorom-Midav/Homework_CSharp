//Задача 3: Задайте массив из вещественных чисел с
//ненулевой дробной частью. Найдите разницу между
//максимальным и минимальным элементов массива.

double[] array = new double[10];

double maxElem = 0, minElem = 0, result;

for(int i = 0; i<array.Length; i++)
{
    array[i] = new Random().NextDouble() * 99.99;
    Console.Write(array[i] + " ");
}

for(int i=0; i<array.Length; i++)
{
    if(i==0)
    {
        maxElem = array[0];
        minElem = array[0];
    }
    else
    {
        if(array[i]>maxElem)
            maxElem = array[i];
        if(array[i]<minElem)
            minElem = array[i];
    }   
}
result = maxElem - minElem;
Console.WriteLine("");
Console.WriteLine("Result: " + result);