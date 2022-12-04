// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int Prompt (string message)
{
    Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Vvedite chislo");
int start = 1;
while (start <= number)
{
    int cube = start * start * start;
    System.Console.WriteLine(cube);
    start += 1;
}
