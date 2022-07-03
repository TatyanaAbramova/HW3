// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int j = 1;

while (j <= n)
{
    Console.Write ($"{j*j*j},");
    j++;
}
Console.Write("\b \b");