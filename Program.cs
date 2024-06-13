// See https://aka.ms/new-console-template for more information

//Легкие задания


using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using static System.Runtime.InteropServices.JavaScript.JSType;


double n;
double m;
int a;
int b;
string str;

////Написание простой функции для сложения двух чисел.
//Console.WriteLine("Введите 1 число (для сложения двух чисел):");

//n = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите 2 число (для сложения двух чисел):");
//m = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"Сумма {n} + {m} = {Sum(n, m)}");

//double Sum(double n, double m)
//{
//    return n + m;
//}

////Создание функции, возвращающей квадрат числа.
//Console.WriteLine("Введите число a(для возведения в квадрат):");
//n = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Квадрат {n}: {Sqr(n)}");
//double Sqr(double a)
//{
//    return a * a;
//}

////Написание функции для проверки, является ли число четным.
//Console.WriteLine("Введите число (для проверки четности):");

//a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(IsEvenNumber(a) ? $"{a} - четное число." : $"{a} - не четное число.");

//bool IsEvenNumber(int n)
//{
//    return n % 2 == 0;
//}
////Создание функции для перевода температуры из Цельсия в Фаренгейты.
//Console.WriteLine("Введите число температуры в Цельсия (для перевода температуры в Фаренгейты");
//n = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"Перевод температуры из шкалы Цельсия в шкалу Фаренгейта: {n}C =  {TemperatureConversion(n)}F");
//double TemperatureConversion(double n)
//{
//    return n * 9 / 5 + 32;
//}
////Функция для нахождения максимального из двух чисел.
//Console.WriteLine("Введите 1 число для нахождения максимального из двух чисел");
//n = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите 2 число для нахождения максимального из двух чисел");
//m = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Максимальное из чисел {n} и {m}:  {Max(n, m)}");

//double Max(double n, double m)
//{
//    if (n > m) return n;
//    return m;
//}
////Написание функции, возвращающей длину строки.
//Console.WriteLine("Введите строку");
//str = Console.ReadLine();

//Console.WriteLine($"Длина строки:  {Lenght(str)}");
//int Lenght(string str)
//{
//    return str.Length;
//}
////Функция для проверки, является ли строка пустой.
//Console.WriteLine("Введите строку (на проверку является ли строка пустой)");
//str = Console.ReadLine();

//Console.WriteLine(IsEmpty(str) ? "Строка пустая." : "Строка не пустая.");
//bool IsEmpty(string str)
//{
//    return string.IsNullOrEmpty(str);
//}

////Создание функции для вычисления факториала числа.
//Console.WriteLine("Введите число (для вычисления факториала):");
//a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Факториал числа {a}:  {Factorial(a)}");
//int Factorial(int a)
//{
//    int factorial = 1;
//    for (int i = 1; i <= a; i++)
//    {
//        factorial *= i;
//    }
//    return factorial;
//}
////Написание функции для вычисления среднего значения массива чисел.

//int[] mas = { 1, 2, 3, 4, 5, 6 };

//Console.WriteLine($"Среднее значение массива чисел :  {AverageValueOfMas(mas)}");

//double AverageValueOfMas(int[] mas)
//{
//    int t = mas.Length;
//    double sum = 0;
//    for (int i = 0; i < t; i++)
//    {
//        sum += mas[i];
//    }
//    return sum / t;
//}

////Функция для проверки, является ли число отрицательным.
//Console.WriteLine("Введите число (для проверки является ли число отрицательным):");
//a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(IsNegativeNumber(a) ? $"{a} - отрицательное число." : $"{a} - не отрицательное число.");

//bool IsNegativeNumber(int n)
//{
//    return n < 0;
//}




//Задания средней сложности

//Написание функции для нахождения наибольшего общего делителя (НОД) двух чисел.

//Console.WriteLine("Введите 1 число (для нахождения наибольшего общего делителя (НОД)):");
//a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите 2 число (для нахождения наибольшего общего делителя (НОД)):");
//b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"НОД чисел {a} и {b} :  {NSD(a,b)}");
//int NSD(int n,int m)
//{
//    while (n != 0 && m != 0)
//    {
//        if (Math.Abs(n) > Math.Abs(m))
//        {
//            n = Math.Abs(n) % Math.Abs(m);
//        }
//        else
//            m = Math.Abs(m) % Math.Abs(n);
//    }
//    return Math.Abs(n + m);
//}


//Создание функции для проверки, является ли строка палиндромом.

//Console.WriteLine("Введите строку (на проверку является ли строка палиндромом)");
//str = Console.ReadLine();

//Console.WriteLine(IsPalindrome(str) ? "Строка палиндром." : "Строка не палиндром.");
//bool IsPalindrome(string str)
//{
//    str = str.ToLower();
//    str = str.Replace(" ", "");
//    str = str.Replace(".", "");
//    str = str.Replace(",", "");
//    str = str.Replace("!", "");
//    str = str.Replace("?", "");

//    int l = str.Length;
//    for (int i = 0; i < l / 2; i++)
//    {
//        if (str[i] != str[(l - 1) - i])
//        {
//            return false;
//        }
//    }
//    return true;
//}
//Функция для сортировки массива чисел по возрастанию.

//int[] mas1 = { -100, 20, 131, -4, 25, 79 };

//Console.WriteLine("Отсортированнй массив :");
//SortMas(mas1);

//void SortMas(int[] mas)
//{
//    int p = mas.Length;
//    for (int i = 0; i < p; i++)
//    {
//        for (int j = p - 1; j > i; j--)
//        {
//            if (mas[j] < mas[j - 1])
//            {
//                int k = mas[j];
//                mas[j] = mas[j - 1];
//                mas[j - 1] = k;
//            }
//        }
//        Console.Write($"{mas[i]}\t");
//    }

//}
//Написание функции для вычисления числа Фибоначчи по индексу.
//Console.WriteLine("Введите  число (для вычисления числа Фибоначчи):");
//a = Convert.ToInt32(Console.ReadLine());
//Fibonachi(a);
//void Fibonachi(int n)
//{
//    int num1 = 1;
//    int num2 = 0;
//    int num_fibonachi = 0;
//    for (int i = 0; i < n; i++)
//    {
//        num_fibonachi += num1;
//        num1 = num2;
//        num2 = num_fibonachi;
//        if (num2 > n)
//            break;
//        Console.Write($"{num2}\t");
//    }
//}


//int Fibonachi2(int n)
//{
//    if (n == 1 || n == 2)
//        return 1;
//    return Fibonachi2(n - 1) + Fibonachi2(n - 2);
//}
//Создание функции для перевода десятичного числа в двоичное.
//a = 14;
//Console.WriteLine($"{Decimal_num(a)}");
//string Decimal_num(int n)
//{
//    string str2 = "";

//    while (n > 0)
//    {
//        int num = n % 2;
//        str2 = num.ToString() + str2;
//        n /= 2;
//    }

//    return str2;
//}
//Функция для поиска минимального и максимального значения в массиве.

//int[] mas2 = { -100, 21010, 131, -1044, 25, 79 };

//int NumMax;
//int NumMin;
//MaxMinMas(mas2, out NumMax, out NumMin);
//PrintMas(mas2);
//Console.WriteLine($"Max: {NumMax}\nMin: {NumMin}");

//void PrintMas(int[] mas)
//{
//    int p = mas.Length;
//    for (int i = 0; i < p; i++)
//    {
//        Console.Write($"{mas[i]}\t");

//    }
//    Console.WriteLine();
//}
//void MaxMinMas(int[] mas, out int max, out int min)
//{
//    int p = mas.Length;
//    max = mas[0];
//    min = mas[0];
//    for (int i = 0; i < p; i++)
//    {
//        if (mas[i]>max)
//        {
//            max = mas[i];
//        }
//        if (mas[i] < min)
//        {
//            min = mas[i];
//        }
//    }
//}
//Написание функции для нахождения второго по величине числа в массиве.

//int[] mas3 = { -170, 0, 789, 471, -1354, 5, 789 };
//int secondMax;
//PrintMas(mas3);

//SecondMaxMas(mas3, out secondMax);
//Console.WriteLine($"secondMax: {secondMax}");
//void SecondMaxMas(int[] mas, out int secondMax)
//{
//    int p = mas.Length;
//    int max = mas[0];
//    secondMax = mas[0];
//    for (int i = 0; i < p; i++)
//    {
//        if (mas[i] > max)
//        {
//           secondMax = max;
//           max = mas[i];
//        }
//        else if (mas[i] > secondMax && mas[i] != max)
//        {
//            secondMax = mas[i];
//        }
//    }
//}

//Функция для подсчета количества вхождений символа в строку.

//Console.WriteLine("Введите строку:\n");
//str = Console.ReadLine();

//Console.WriteLine("Введите символ для поиска в строке:\n");
//char symb = Convert.ToChar(Console.ReadLine());

//Console.WriteLine($"Количество символов {symb}: {CountSymb(str,symb)}");

//int CountSymb(string str, char symb)
//{
//    var countA = str.Count(x=> x=='a');

//        int kol = 0;
//    foreach (char ch in str)
//    {
//        if (ch == symb)
//            kol++;
//    }
//    return kol;
//}

//или 
//Console.WriteLine("Введите строку:\n");
//str = Console.ReadLine();

//Console.WriteLine($"Количество символов, которые втречаються в строке:");
//CountSymb2(str);

//void CountSymb2(string str)
//{
//    var dict = new Dictionary<char, int>();
//    foreach (char ch in str)
//    {
//        if (!dict.ContainsKey(ch))
//            dict.Add(ch, 0);
//        dict[ch]++;
//    }
//    foreach (char ch in dict.Keys)
//        Console.WriteLine($"{ch} - {dict[ch]}");
//}

//Создание функции для генерации случайного пароля заданной длины.

//Написание функции для проверки, является ли число простым.

//Console.WriteLine("Введите число:\n");

//while (!Int32.TryParse(Console.ReadLine(), out a))
//    Console.WriteLine("Не верный ввод.Введите число:");

//if (NumberIsPrime(a))
//{
//    Console.WriteLine($"Число {a} - простое.");
//}
//else
//{
//    Console.WriteLine($"Число {a} - не простое.");
//}
//bool NumberIsPrime(int num)
//{
//    if (num == 0) return false;
//    if (num == 1 || num == 2) return true;
//    num = Math.Abs(num);
//        for (int i = 2; i <= Math.Sqrt(num);i++)
//        {
//            if (num % i == 0) return false;
//        }
//    return true;
//}






//Сложные задания
//Создание функции для нахождения всех простых чисел до заданного числа.
//Console.WriteLine("Введите число:\n");
//while (!Int32.TryParse(Console.ReadLine(), out a))
//    Console.WriteLine("Не верный ввод.Введите число:");

//PrimeNumbers(a);
//void PrimeNumbers(int num)
//{
//    num = Math.Abs(num);
//    for (int i = 1; i<=num; i++)
//    {
//        var lenght = Math.Sqrt(i);
//        var flag = false;
//        for (int j = 2; j <= lenght; j++)
//        {

//            if (i % j == 0)
//            {
//                flag = true;
//                break;
//            }

//        }
//        if(!flag) Console.Write($"{i}\t");
//    }

//}



//Написание функции для решения квадратного уравнения.
//Console.WriteLine("Введите коофициенты квадратного уравнения (a*x*x + b *x + c = 0)");
//Console.Write("a = ");
//while (!Int32.TryParse(Console.ReadLine(), out a))
//{
//    Console.WriteLine("Не верный ввод.Введите число:");
//    Console.Write("a = ");
//}

//Console.Write("b = ");
//while (!Int32.TryParse(Console.ReadLine(), out b))
//{
//    Console.WriteLine("Не верный ввод.Введите число:");
//    Console.Write("b = ");
//}

//int c;
//Console.Write("c = ");
//while (!Int32.TryParse(Console.ReadLine(), out c))
//{
//    Console.WriteLine("Не верный ввод.Введите число:");
//    Console.Write("c = ");
//}

//SolutionsToQuadraticEquations(a, b, c);
//void SolutionsToQuadraticEquations(int a, int b,int c)
//{
//    double x;
//    double x1;
//    double x2;
//    if (a == 0)
//    {
//        if (b != 0)
//        {
//            x = (double)-c / b;
//            Console.WriteLine($"x = {x}");
//            return;
//        }
//        else
//        {
//            Console.WriteLine($"бесконечное число решений");
//            return;
//        }
//    }

//    if (b == 0)
//    {
//        if (c / a > 0)
//        {
//            Console.WriteLine("нет решения.");
//        }
//        else
//        {
//            x1 = Math.Sqrt((double)-c / a);
//            x2 = -Math.Sqrt((double)-c / a);
//            Console.WriteLine($"x1 = {x1}");
//            Console.WriteLine($"x2 = {x2}");
//        }
//    }
//    if (c == 0)
//    {
//        Console.WriteLine($"x = {(double)-b / a}");
//        Console.WriteLine("x = 0");
//    }
//    if ((a != 0) && (b != 0) &&  (c != 0))
//    {
//        double D = b * b - 4 * a * c;
//        x1 = (-b + Math.Sqrt(D)) / (2 * a);
//        x2 = (-b - Math.Sqrt(D)) / (2 * a);
//        Console.WriteLine($"x1 = {x1}, x2 = {x2}");
//    }
//}




//Функция для нахождения всех подстрок в строке.



//Console.WriteLine("Введите строку:\n");
//str = Console.ReadLine();

//Console.WriteLine("Введите подстроку для поиска в строке:\n");
//string symb = Console.ReadLine();

//Console.WriteLine("Количество вхождений подстроки в строке: {CountSubstring(str, symb)}");

//int CountSubstring(string str, string symb)
//{
//    int count = 0;
//    int minIndex = str.IndexOf(symb, 0);
//    while (minIndex != -1)
//    {
//        minIndex = str.IndexOf(symb, minIndex + symb.Length);
//        count++;
//    }
//    return count;
//}




//Создание функции для перевода римских цифр в арабские.


//Console.WriteLine("Введите римскую цифру:\n");
//str = Console.ReadLine();
//str = str.ToUpper();

//Dictionary<char, int> RomanNum = new Dictionary<char, int>
//    {
//        {'I', 1},
//        {'V', 5},
//        {'X', 10},
//        {'L', 50},
//        {'C', 100},
//        {'D', 500},
//        {'M', 1000}
//    };

//ConvertToArabicMsg(str);

//int ConvertToArabic(string roman)
//{
//    if (string.IsNullOrEmpty(roman))
//        return -1;

//    int result = 0;
//    int previousValue = 0;

//    for (int i = roman.Length - 1; i >= 0; i--)
//    {
//        int value = RomanNum[roman[i]];

//        if (value < previousValue)
//            result -= value;
//        else
//            result += value;

//        previousValue = value;
//    }

//    return result;
//}
//void ConvertToArabicMsg (string str)
//{
//    int p = ConvertToArabic(str);
//    if (p == -1)
//        Console.WriteLine("Невозможно конвертировать число.");
//    else
//        Console.WriteLine($"{str} = {p}" );
//}










//Написание функции для проверки валидности адреса электронной почты.


//Console.WriteLine("Введите строку:\n");
//str = Console.ReadLine();

//ValidMsg(str);

//bool IsValidMail(string str)
//{
//    var countSymb = str.Count(x => x == '@');
//    return countSymb == 1;
//}

//void ValidMsg(string str)
//{
//if (IsValidMail(str))
//        Console.WriteLine("Адрес электронной почты - верный");
//    else
//        Console.WriteLine("Адрес электронной почты - не верный");
//}






//Функция для нахождения суммы цифр числа.

//Console.WriteLine("Введите число:");
//Console.Write("num = ");
//while (!Int32.TryParse(Console.ReadLine(), out a))
//{
//    Console.WriteLine("Не верный ввод.Введите число:");
//    Console.Write("num = ");
//}
//Console.WriteLine($"Сумма цифр числа {a}: {SumCifr(a)}");
//int SumCifr(int num)
//{
//    int sum = 0;
//    num = Math.Abs(num);
//    do
//    {
//        sum += num % 10;
//        num /= 10;
//    }
//    while (num != 0);
//    return sum;
//}





//Создание функции для вычисления корня n-ой степени числа.

//Console.WriteLine("Введите число:");
//Console.Write("number = ");
//while (!Double.TryParse(Console.ReadLine(), out m))
//{
//    Console.WriteLine("Не верный ввод.Введите число:");
//    Console.Write("number = ");
//}

//Console.WriteLine("Введите степень корня:");
//Console.Write("n = ");
//while (!Int32.TryParse(Console.ReadLine(), out a))
//{
//    Console.WriteLine("Не верный ввод.Введите степень корня:");
//    Console.Write("n = ");
//}

//CalcSqrtMsg(m, a);
//double CalcSqrt(double number, int n)
//{
//    if (n == 0)
//    {
//       return 1;
//    }

//    if (number < 0 && n % 2 == 0)
//    {
//       return -1;
//    }

//    return Math.Pow( number, 1.0/ n);
//}
//void CalcSqrtMsg(double number, int n)
//{
//    double num = CalcSqrt(number, n);
//    if (num == -1)
//        Console.WriteLine($"Невозможно взять корень {n} степени из отрицательного числа.");
//    else
//        Console.WriteLine($"Корень {n}-степени из числа {number} = {num}");
//}







//Функция для нахождения наибольшей общей подстроки в двух строках.
//Написание функции для вычисления количества слов в строке.


//Console.WriteLine("Введите строку:\n");
//str = Console.ReadLine();


//Console.WriteLine($"Количество слов: {CountWord(str)}");

//int CountWord(string str)
//{
//    if (str.Length != 0)
//    {
//        int kol = 1;
//        foreach (char ch in str)
//        {
//            if (ch == ' ')
//                kol++;
//        }
//        return kol;
//    }
//    return 0;
//}


//Функция для нахождения всех возможных перестановок символов в строке.





//                                  Очень сложные задания
//Создание функции для реализации алгоритма сортировки слиянием.

//Console.WriteLine("Исходный массив:");
//int[] mas = { 21, 1, 54, -5, -18, 0 , 54, 0};
//PrintMas2(mas);
//SortMas(mas, 0, mas.Length - 1);
//Console.WriteLine("Отсортированный массив:");
//PrintMas2(mas);


//void SortMas(int[] mas, int leftIndex, int rightIndex)
//{
//    if (leftIndex < rightIndex)
//    {
//        int middleIndex = (leftIndex + rightIndex) / 2;

//        SortMas(mas, leftIndex, middleIndex);
//        SortMas(mas, middleIndex + 1, rightIndex);

//        MergeSubMas(mas, leftIndex, middleIndex, rightIndex);
//    }
//}

//void MergeSubMas(int[] mas, int leftIndex, int middleIndex, int rightIndex)
//{
//    int leftLength = middleIndex - leftIndex + 1;
//    int rightLength = rightIndex - middleIndex;

//    int[] mas1 = new int[leftLength];
//    int[] mas2 = new int[rightLength];

//    for (int i = 0; i < leftLength; i++)
//        mas1[i] = mas[leftIndex + i];
//    for (int i = 0; i < rightLength; i++)
//        mas2[i] = mas[middleIndex + 1 + i];

//    int k = leftIndex;
//    int n = 0;
//    int j = 0;
//    while (n < leftLength && j < rightLength)
//    {
//        if (mas1[n] <= mas2[j])
//        {
//            mas[k] = mas1[n];
//            n++;
//        }
//        else
//        {
//            mas[k] = mas2[j];
//            j++;
//        }
//        k++;
//    }

//    while (n < leftLength)
//    {
//        mas[k] = mas1[n];
//        n++;
//        k++;
//    }

//    while (j < rightLength)
//    {
//        mas[k] = mas2[j];
//        j++;
//        k++;
//    }
//}

//void PrintMas2(int[] mas)
//{
//    int p = mas.Length;
//    for (int i = 0; i < p; i++)
//    {
//        Console.Write($"{mas[i]}\t");

//    }
//    Console.WriteLine();
//}


//Написание функции для решения задачи о рюкзаке.
//Функция для реализации алгоритма Дейкстры для поиска кратчайшего пути.

CalculateShortestPath();
int MinArg(List<double> T, List<int>S)
{
    int MinIndex = -1;
    double max = Double.PositiveInfinity;
    for(int i=0; i < T.Count; i++)
    {
        if (T[i] < max && !S.Contains(i))
        {
            max = T[i];
            MinIndex = i;
        }
    }
    return MinIndex;
}

void CalculateShortestPath()
{
    double[,] D = { { 0, 3, 1, 3, Double.PositiveInfinity, Double.PositiveInfinity },
    { 3, 0, 4, Double.PositiveInfinity, Double.PositiveInfinity, Double.PositiveInfinity },
    { 1, 4, 0, Double.PositiveInfinity, 7, 5 },
    {3, Double.PositiveInfinity, Double.PositiveInfinity, 0, Double.PositiveInfinity, 2 },
    { Double.PositiveInfinity, Double.PositiveInfinity, 7, Double.PositiveInfinity, 0, 4},
    {Double.PositiveInfinity, Double.PositiveInfinity, 5, 2, 4, 0 } };

    int kol = D.GetLength(0);
    List<double> T = new List<double>(new double[kol]); ;
    for (int i = 0; i < kol; i++)
    {
        T[i] = Double.PositiveInfinity;
    }
    int Vertex = 0;
    T[0] = 0;
    var S = new List<int>();
    S.Add(Vertex);
    int[] M = new int[kol];
    while (Vertex != -1)
    {
        for (int j = 0; j < kol; j++)
        {
            if (!S.Contains(j))
            {
                double w = T[Vertex] + D[Vertex, j];
                if (w < T[j])
                {
                    T[j] = w;
                    M[j] = Vertex;
                }
            }
        }
        Vertex = MinArg(T, S);
        if (Vertex >= 0)
        {
            S.Add(Vertex);
        }
    }
    PrintList(T);

}

void PrintList(List<double> T)
{
    int p = T.Count;
    for (int i = 0; i < p; i++)
    {
        Console.Write($"0 -> {i}:\t{T[i]}\n");

    }
    Console.WriteLine();
}


//Создание функции для нахождения всех возможных комбинаций чисел, сумма которых равна заданному числу.

// Метод для нахождения всех комбинаций чисел, сумма которых равна заданному числу
//Написание функции для реализации алгоритма Левенштейна для вычисления расстояния между строками.
//Функция для нахождения всех уникальных подмножеств заданного множества.








//Создание функции для реализации алгоритма быстрой сортировки.

//List<int> L = new List<int> { 7, 6, 41, 5, 9, 5, 19, 0 };

//var rez = QuickSort(L);
//PrintListInt(rez);
//List<int> QuickSort(List<int>L)
//{
//    if (L.Count <= 1)
//        return L;
//    int elem = L[0];
//    var left = new List<int>();
//    var centr = new List<int>();
//    var right = new List<int>();
//    foreach (var item in L)
//    {
//        if (item < elem)
//            left.Add(item);
//        else if (item > elem)
//            right.Add(item);
//        else centr.Add(item);
//    }
//    var l = QuickSort(left);
//    var r = QuickSort(right);

//    l.AddRange(centr);
//    l.AddRange(r);

//    return l;
//}

//void PrintListInt(List<int> L)
//{
//    int p = L.Count;
//    for (int i = 0; i < p; i++)
//    {
//        Console.Write($"{L[i]}\t");

//    }
//    Console.WriteLine();
//}






//Написание функции для нахождения максимальной подматрицы в матрице чисел.

//Функция для реализации алгоритма Кнута-Морриса-Пратта для поиска подстроки.
//Создание функции для нахождения кратчайшего пути в лабиринте.

//char[,] Field = {
//{' ','X','X','X','X','X','X',' ',' ',' ' },
//{' ','X',' ',' ',' ',' ',' ','X','X',' ' },
//{' ','X',' ','X','X',' ','X',' ',' ',' ' },
//{' ',' ',' ','X','X',' ','X','X','X','X' },
//{'X','X',' ','X','X',' ',' ',' ',' ','X' },
//{'X','X',' ','X','X','X','X','X',' ','X' },
//{'X','X',' ','X','X','X',' ','X',' ','X' },
//{'X','X',' ',' ',' ','X',' ',' ',' ','X' },
//{'X','X','X','X',' ','X','X','X','X','X' },
//{'X','X','X','X',' ',' ',' ',' ',' ',' ' },
//};
//PrintField(Field);
//FindWay(Field);
//void PrintField(char[,] Field)
//{
//    int p = Field.GetUpperBound(0);
//    int k = Field.GetUpperBound(1);
//    for (int i = 0; i <= p; i++)
//    {
//        for (int j = 0; j <= k; j++)
//        {
//            Console.Write($"{Field[i, j]}");
//        }
//        Console.WriteLine();
//    }
//}
//void PrintWay(int[,] way)
//{
//    int p = Field.GetUpperBound(0);
//    int k = Field.GetUpperBound(1);
//    for (int i = 0; i <= p; i++)
//    {
//        for (int j = 0; j <= k; j++)
//        {
//            Console.Write($"{way[i,j]}     ");
//        }
//        Console.WriteLine();
//    }
//}

//int FindWay(char[,] Field)
//{
//    int p = Field.GetUpperBound(0);
//    int k = Field.GetUpperBound(1);
//    int[,] way = new int[p+1, k+1];
//    for (int i = 0; i <= p; i++)
//    {
//        for (int j = 0; j <= k; j++)
//        {
//            if (Field[i, j] == 'X')
//                way[i, j] = -1;
//            else
//                way[i, j] = 0;
//        }
//    }
//    way[0, 0] = 1;


//    for (int n = 2; n <= 100; n++)
//    { 
//        for (int i = 0; i <= p; i++)
//        {
//            for (int j = 0; j <= k; j++)
//            {
//                if (way[i, j] == n - 1)
//                {
//                    if ((i - 1) >= 0 && way[i - 1, j] == 0)
//                        way[i - 1, j] = n;
//                    if ((j - 1) >= 0 && way[i, j - 1] == 0)
//                        way[i, j - 1] = n;
//                    if ((i + 1) <= p && way[i + 1, j] == 0)
//                        way[i + 1, j] = n;
//                    if ((j + 1) <= k && way[i, j + 1] == 0)
//                        way[i, j + 1] = n;

//                }
//            }
//        }
//    }
//    if (way[p - 1, k - 1] == 0)
//    {
//        Console.WriteLine("клетка недостежима");
//        return -1;
//    }

//                return 1;
//}