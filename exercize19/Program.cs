//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void palindrom()
{
    Console.WriteLine("Введите число пятизначное число ");
    string number = Console.ReadLine();
    int len = number.Length;

    if (len == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
        {
            Console.WriteLine($"число {number} является палиндром");
        }
        else
        {
            Console.WriteLine($"число {number} не является палиндром");
        }
    }
    int num1 = Convert.ToInt32(number);
}
palindrom();