// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("ведите любое пятизначное целое число: ");
string number = Console.ReadLine();

if (number.Length == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
            {
                Console.WriteLine($"Число {number} является палиндромом");
            }
            else
            {
                Console.WriteLine($"Число {number} не является палиндромом");
            }            
    }
    else
    {
        Console.WriteLine("Это не пятизначное число. Введите пятизначное число!");
    }

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Формула AB = √((xb - xa)2 + (yb - ya)2 + (zb - za)2)

// Console.WriteLine("Введите координату x точки A: ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y точки A: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z точки A: ");
// int za = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату x точки B: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y точки B: ");
// int yb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z точки B: ");
// int zb = Convert.ToInt32(Console.ReadLine());

// double powerOfDifferenceX = Math.Pow(xb-xa, 2);
// double powerOfDifferenceY = Math.Pow(yb-ya, 2);
// double powerOfDifferenceZ = Math.Pow(zb-za, 2);
// double distanceAB = Math.Sqrt(powerOfDifferenceX+powerOfDifferenceY+powerOfDifferenceZ);

// Console.WriteLine($"Расстояние между точками в 3D пространстве составляет {distanceAB}");

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Способ через for:

// Console.WriteLine("ведите число N ");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= N; i++)
// {
//      Console.Write($"{Math.Pow(i, 3)} ");
// }

// Способ через while:

// Console.WriteLine("ведите число N ");
// int N = Convert.ToInt32(Console.ReadLine());

// int i = 1;
// while (i <= N)
// {
//     Console.Write($"{Math.Pow(i, 3)} ");
//     i++;
// }
