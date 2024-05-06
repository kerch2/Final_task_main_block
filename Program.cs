// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// void WriteNumbersMtoN(int m, int n)
// {
//     if (n >= m)
//     {
//         WriteNumbersMtoN(m, n-1);
//         System.Console.Write($"{n} ");
//     }
    
// }


// System.Console.Write("Input number M -->");
// int numberM = Convert.ToInt32(System.Console.ReadLine());
// System.Console.Write("Input number N -->");
// int numberN = Convert.ToInt32(System.Console.ReadLine());
// if (numberM < numberN)
// {
//     WriteNumbersMtoN(numberM, numberN);
// }
// else
// {
//     WriteNumbersMtoN(numberN, numberM);
// }

// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.    m = 2, n = 3 -> A(m,n) = 29 (???)
// Замечание:
// !!! при m = 2, n =3  A(m,n) = 9 !!!  При m = 3, n = 2 -> A(m,n) = 29 !!!

long Akkerman(long m, long n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m != 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

System.Console.Write("Input number M -->");
int numberM = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Input number N -->");
int numberN = Convert.ToInt32(System.Console.ReadLine());
//if (numberM < numberN)
if (numberM < 0 && numberN < 0)
{
    System.Console.Write("Negative number!!!");
}
else
{
    System.Console.WriteLine(Akkerman(numberM, numberN));
}


// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// void PrintArray(int[] array, int i)
// {
//     if (i >= 0)
//     {
//         System.Console.Write($"{array[i]} ");
//         PrintArray(array, i-1);
//     }
// }

// int [] someArray= {-1, 3, 45, 45, 76, 38, 123};

// PrintArray(someArray, someArray.Length-1);