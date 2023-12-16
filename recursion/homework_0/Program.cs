//Задача 1: Задайте значения M и N. Напишите
//программу, которая выведет все натуральные числа
//в промежутке от M до N. Использовать рекурсию, не
//использовать циклы.

int PrintNumberRecursion(int max, int number)
{
    Console.Write(number + ", ");
    number += 1;
    if(number == max) return number;
    else return PrintNumberRecursion(max, number);
}


int number = new Random().Next(1, 10);
int max = new Random().Next(number + 1, 15);

Console.Write("M = " + number + ", N = " + max + " -> ");

Console.Write(PrintNumberRecursion(max, number));