//Задача 1: Напишите программу, которая бесконечно
//запрашивает целые числа с консоли. Программа
//завершается при вводе символа ‘q’ или при вводе
//числа, сумма цифр которого четная.


bool continuation = true;

bool ConsoleNum(string messege)
{
    string userText = "";
    int sum = 0;

    Console.Write(messege);
    userText = Console.ReadLine() + "";

    if(userText == "q")
        return false;
    else
    {
        int number = 0;
        if(int.TryParse(userText, out number))
        {
            while(number>0)
            {
                sum += number%10;
                number /= 10;
            }
            if(sum%2 == 0)
                return false;
            else
                return true;
        }
        else
            return true;
        
    }
}

while(continuation)
{
    continuation = ConsoleNum("Чтобы выйти, введите q или число сумма цифр, которых четная: ");
}
Console.WriteLine("Завершение программы");