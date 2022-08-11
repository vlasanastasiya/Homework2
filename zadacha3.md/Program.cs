//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Random rand = new Random();
int number = rand.Next(1, 8);
Zadacha3(number);

void Zadacha3 (int currentnumber) {
Console.WriteLine(currentnumber);
    if (currentnumber == 1)
        Console.WriteLine("Это день понедельник - рабочий день");
    if (currentnumber == 2)
        Console.WriteLine("Это день вторник - рабочий день");
    if (currentnumber == 3)
        Console.WriteLine("Это день среда - рабочий день");
    if (currentnumber == 4)
    Console.WriteLine("Это день четверг - рабочий день");
    if (currentnumber == 5)
    Console.WriteLine("Это день пятница - рабочий день");
    if (currentnumber == 6)
    Console.WriteLine("Это день суббота - выходной день");
    if (currentnumber == 7)
    Console.WriteLine("Это день воскресенье - выходной день");
}
