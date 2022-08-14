// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int GetSumNumbers(int num)
// {
//     int count = 0; 
//     int sum = 0;
//     int i = num.length;
//     while (count <=i)
//     {
//         sum = sum + num[count];
//         count++;

//     }
//     return sum;
// }


// Console.WriteLine($"Сумма цифр {number} = {GetSumNumbers(number)}");


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

int GetSumNumbers(string num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + num[i];
    }
 
    return sum;
}


Console.WriteLine($"Сумма цифр {number} = {GetSumNumbers(number)}");