//Задача 2: Напишите программу вычисления функции
//Аккермана с помощью рекурсии. Даны два
//неотрицательных числа m и n. 


int AckermanFunction (int m, int n)
{
    if(m == 0) return n+1;
    else if(m>0 && n == 0) return AckermanFunction(m-1, 1);
    else return AckermanFunction(m-1, AckermanFunction(m, n-1));
}


int m = 3;
int n = 2;

Console.WriteLine("m = " + m + " , n = " + n + ":");

int result = AckermanFunction(m, n);

Console.WriteLine("Результат: " + result);