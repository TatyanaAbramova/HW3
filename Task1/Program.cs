// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int n = 0;
do
{
    Console.WriteLine("ВВедите пятизначное число:");
    n = Convert.ToInt32(Console.ReadLine());
}
while (n < 10000 || n > 100000);
char[] n_array = Convert.ToString(n).ToCharArray();
bool result = true;
for (int i = 0; i < n_array.Length/2; i++)
{
    if (n_array[i] != n_array[n_array.Length - i - 1])
    {
        result = false;
    }
}
if (result)
    Console.WriteLine("Это ПАЛИНДРОМ");
else
    Console.WriteLine("Это НЕ ПАЛИНДРОМ");