// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число (А): ");
int A = Convert.ToInt32(Console.ReadLine()); ;
Console.WriteLine("Введите степень (В): ");
int B = Convert.ToInt32(Console.ReadLine());

int DegreeNumbers(int number, int degree)
{
    int result = 1;
    int i = 1;
    while (i <= degree)
    {
        result = result * number;
        i++;
    }
    return result;
}

Console.WriteLine($"Число {A} в степени {B} равно {DegreeNumbers(A, B)}");
