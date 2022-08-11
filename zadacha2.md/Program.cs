// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет3
// 32679 -> 6

Console.WriteLine("Введите число");
string number = Console.ReadLine();
Zadacha2(number);

void Zadacha2(string currentnumber)
{
    if (currentnumber.Length >= 3)
    {
        Console.WriteLine($"Третья цифра числа {number} равна {currentnumber[2]}");
    }
    else {
        Console.WriteLine("третьей цифры нет");
    }
}
