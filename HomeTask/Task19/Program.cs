// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int invert = 0;

if (num < 100000 && num > 9999)
{
    while (temp != 0)
        {
            invert = invert * 10 + temp % 10;
            temp /= 10;
        }
        if (num == invert)
            Console.WriteLine("Число является полиндромом");
        else
            Console.WriteLine("Число не является полиндромом");
}
else
    Console.WriteLine("Введено неверное количество цифр");