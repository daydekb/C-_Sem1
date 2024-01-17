// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num} -> {num * num}");

// Напишите программу, которая на вход
// принимает ва целых числа и проверяет,
// является ли первое число квадратом второго.

// Console.WriteLine("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2 * num2)
// {
//     Console.WriteLine($"{num1} is quad of {num2}");
// }
// else
// {
//     Console.WriteLine($"{num1} is not quad of {num2}");
// }

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.

Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = -n; i <= n; i++)
{
    Console.Write(i + " ");
}

///Напишите программу, которая принимает на вход
///трёхзначное целое число и на выходе показывает сумму
///первой и последней цифры этого числа.

Console.WriteLine("input number N:");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 999 && num >= 100)
{
    int one = num / 100;
    int three = num % 10;
    Console.WriteLine($"sum = {one + three}");
}
else
{
    Console.WriteLine("Введено не трёхзначное число");
}