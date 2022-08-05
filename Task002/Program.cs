// Напишите программу, которая на вход принимает два числа и прверяет, 
// является ли первое число квадратом второго.

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Ваши числа являются - ");
if (numberA*numberA == numberB)
Console.WriteLine("True");
else
{
    Console.WriteLine("False");
}

// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1) Console.WriteLine("Понедельник");
if (number == 2) Console.WriteLine("Вторник");
if (number == 3) Console.WriteLine("Среда");
if (number == 4) Console.WriteLine("Четверг");
if (number == 5) Console.WriteLine("Пятница");
if (number == 6) Console.WriteLine("Суббота");
if (number == 7) Console.WriteLine("Воскресенье");
else if (number > 7) Console.WriteLine("Неправильное число, введите число от 1 до 7");