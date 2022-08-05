// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number;
Console.Write(number);
while(count > -number)
{
    number = number - 1;
    Console.Write(number );
}

// Напишитее программу, которая принимает на вход трехзначное число,
// и на выходе показывает последнюю цифру.

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int digit = num % 10;
Console.WriteLine($"Последняя цифра числа {num} равна {digit}");
