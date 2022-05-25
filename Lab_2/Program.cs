﻿class Program
{
    static void Main(string[] arg)
    {
        try
        {
            RomanNumber number = new RomanNumber(15);
            RomanNumber number2 = new RomanNumber(13);

            Array myArr = Array.CreateInstance(typeof(RomanNumber), 10);
            int lower = myArr.GetLowerBound(0), upper = myArr.GetUpperBound(0);
            for (int i = lower; i <= upper; i++)
            {
                RomanNumber tmp = new RomanNumber((ushort)(i * 10 + 1));
                myArr.SetValue(tmp, i);
            }
            myArr.SetValue(number, 3);

            Print(myArr);

            void Print(Array s)
            {
                Console.Write("RomanMassive : ");
                for (int i = lower; i <= upper; i++)
                {

                    Console.Write($"{s.GetValue(i)} ");
                }
                Console.WriteLine("");
            }

            Array.Sort(myArr);
            Print(myArr);

            Console.WriteLine($"\nn1 - {number}, n2 - {number2}");

            Console.WriteLine($"Add(n1, n2) - {RomanNumber.Add(number, number2).ToString()} ");

            Console.WriteLine($"Div(n1, n2) - {RomanNumber.Div(number, number2).ToString()} ");

            Console.WriteLine($"Sub(n1, n2) - {RomanNumber.Sub(number, number2).ToString()} ");

            Console.WriteLine($"Mul(n1, n2) - {RomanNumber.Mul(number, number2).ToString()} ");

        }
        catch (RomanNumberException e)
        {
            Console.WriteLine($"{e.Message}");
            Console.WriteLine($"Некорректное значение: {e.Value}");
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine($"{e.Message}");
        }
    }
}