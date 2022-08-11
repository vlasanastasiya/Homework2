//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine(number);

void Zadacha1 (int currentnumber) 
{
               int a1 = currentnumber / 10;
               int a2 = a1 % 10;
               int result = a2;
               Console.WriteLine($" в числе {number} вторая цифра {result}");
}
Zadacha1(number);
