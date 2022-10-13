//Задача 25: опишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//без math.pow

Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for(int i = 1; i < b; i ++)
{
    step = step * a;
}
Console.WriteLine("А в степени В равно: " + step);
