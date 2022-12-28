// //Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// //а первый - на последнем и т.д.)

// //[1 2 3 4 5] -> [5 4 3 2 1]
// //[6 7 3 6] -> [6 3 7 6]

// int[] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++) // 4 6 8 1
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }


// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(lenght, min, max);

// ShowArray(newArray);
// newArray = ReverseArray(newArray);
// ShowArray(newArray);


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return myArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// bool CheckTriangle(int x, int y, int z)
// {
//     if ((x < y + z) && (y < x + z) && (z < x + y))
//     {
//         return true;
//     }
//     return false;
// }

// Console.WriteLine("Введите длину стороны a");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину стороны b");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину стороны c");
// int z = Convert.ToInt32(Console.ReadLine());

// //Console.WriteLine($"CheckTriangle(x,y,z)");
// bool res = CheckTriangle(x, y, z);
// if (res == true)
// {
//     Console.WriteLine($"Треугольник со сторонами {x} {y} {z} может существовать ");
// }
// else
//     Console.WriteLine($"Треугольник со сторонами {x} {y} {z} не может существовать ");


// // на лекции как раз было
// // f(n) = f(n-1) + f(n-2)

// // 0 1 1 2 3 4 8

// string result = string.Empty;


// //Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.


// void fibonachi (int num)
// {
//     int a = 0;
//     int b = 1;
//     int result = 0;
//     Console.Write("0 1");
//     for (int i = 3; i <= num; i++ )
//     {
//         result = a + b;
//         a = b;
//         b = result;
//         Console.Write($" {result} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите число N");
// int num = Convert.ToInt32(Console.ReadLine());

// fibonachi (num);




// //числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
// //Задача 4. ****Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// //45 -> 101101
// //3 -> 11
// //2 -> 10


// void dvoichniy (int num1)
// {
//     string result = string.Empty;
//     while (num1 > 0)
//     {
//         int ostatok = num1 % 2;
//         result = ostatok + result;
//         num1 = num1 / 2;

//     }
//     Console.Write(result);
// }

// Console.WriteLine("Введите число N");
// int num1 = Convert.ToInt32(Console.ReadLine());

// dvoichniy (num1);




// //// Вид 4
// // string Method4(int count, string text)
// // {
// //     string result = string.Empty;
// //     for (int i = 0; i < count; i++)
// //     {
// //         result = result + text;
// //     }
// //     return result;
// // }
// // string res = Method4(10, "asdf");
// // Console.WriteLine(res);


// //// Вид 4
// // string Method4(int count, string text)
// // {
// //     string result = string.Empty;
// //     for (int i = 0; i < count; i++)
// //     {
// //         result = result + text;
// //     }
// //     return result;
// // }
// // string res = Method4(10, "asdf");
// // Console.WriteLine(res);




//Домашняя работа 

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int[] CreateArray1(int size)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(-10, 10);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите кличество чисел:");
int lengthN = Convert.ToInt32(Console.ReadLine());


int[] arr1 = CreateArray1(lengthN);
ShowArray(arr1);


int CheckNegativeNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            ++count;
        }
    }
    return count;
}

Console.WriteLine($"Чисела больше 0:  {CheckNegativeNumber(arr1)}");
Console.WriteLine();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine(" ***********Задача 43:**************");

void pointIntersection(int f1b, int f1k, int f2b, int f2k)
{
    double dX = 0.1;
    double x = 0.0;
    double min = 1.0;
    double min1 = 0.0;
    double y1 = (f1k * x + f1b);
    double y2 = (f2k * x + f2b);
    //   (2, 5, 4, 9)
    while ((f1k * x + f1b) != (f2k * x + f2b))
    {

        //min = Math.Round(Math.Abs(y1 -y2), 2);

        if (min-min1 < 0)
        {
            
            x = x + dX;
            y1 = (f1k * x + f1b);
            y2 = (f2k * x + f2b);
            min = Math.Round((y1 - y2), 2);
            Console.WriteLine(min1 + "      min1    " + min);

        }
        else if (min-min1 > 0)
        {
            
            x = x - dX;
            min1 = Math.Round(((f1k * x + f1b) - (f2k * x + f2b)), 2);
            Console.WriteLine(min1 + "      min    " + min);
        }


    }
   Console.WriteLine($" Точка пересечения двух прямых ({x}, {f1k * x + f1b})");
}

pointIntersection(2, 5, 4, 9);




