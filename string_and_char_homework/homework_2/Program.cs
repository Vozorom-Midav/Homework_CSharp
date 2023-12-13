//Задача 3: Задайте произвольную строку. Выясните,
//является ли она палиндромом.

void ReversString (string myStr)
{
    string revStr = "";

    for(int i = 1; i <= myStr.Length; i++)
        revStr += myStr[myStr.Length - i];
    
    if(revStr == myStr)
        Console.WriteLine("Строка является палиндромом");
    else
        Console.WriteLine("Строка не является палиндромом");
}


string str = "Шалаш";

Console.WriteLine("Исходная строка: " + str);
ReversString(str.ToLower());
