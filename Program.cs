// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом. Не использовать строки

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt (string message)
{
    Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Vvedite chisla");
int num1 = number / 10000 % 10;
int num2 = number / 1000 % 10;
int rev1 = number / 10 % 10;
int rev2 = number % 10;
int nul = number / 10000;
        
if (nul < 1 || nul > 9)
    {
        Console.WriteLine(number + " -> " + "Not 5-digit number");
    }
else if  (num1 == rev2 && num2 == rev1)
    {
        Console.WriteLine(number + " -> Yes, this is palindrom");
    }
else
    {
        Console.WriteLine(number + " -> No, this is not palindrom");
    }