using System;

namespace MyApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x:");
            int x = int.Parse(Console.ReadLine()!);
            MyClass.ToDiv(x);
        }
    }

    public class  MyClass
    {
        public static bool ToDiv(int x)
        {
            for (int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    Console.Write(i + " ");
                    return true;
                }
            }
            if (x == 1 || x == x)
            {
                Console.WriteLine("У числа нет делителей, кроме 1 и самого себя.");
            }
            return false;
        }
    }
}

