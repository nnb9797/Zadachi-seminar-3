using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СЕМИНАР_3__Задачи
{
    internal class Program
    {
        static void Main(string[] args)

        {
            void Zadacha19()
            {
                //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

                int ones = 0;
                int tens = 0;
                int hundreds = 0;
                int thousands = 0;
                int tensThousands = 0;

                Console.WriteLine("Введите целое пятизначное число: ");
                string a = Console.ReadLine();

                if (double.TryParse(a, out var n))
                {
                    ones = Convert.ToInt32((n / 10 - Math.Truncate(n / 10)) * 10);

                    tens = Convert.ToInt32((n / 100 - Math.Truncate(n / 100)) * 10 - (double)tens / 10);

                    hundreds = Convert.ToInt32((n / 1000 - Math.Truncate(n / 1000)) * 10 - (double)tens / 10 - (double)ones / 100);

                    thousands = Convert.ToInt32((n / 10000 - Math.Truncate(n / 10000)) * 10 - (double)hundreds / 10 - (double)tens / 100 - (double)ones / 1000);

                    tensThousands = Convert.ToInt32((n / 100000 - Math.Truncate(n / 100000)) * 10 - (double)thousands / 10 - (double)hundreds / 100 - (double)tens / 1000 - (double)ones / 10000);


                    if (ones == tensThousands && tens == thousands)
                    {
                        Console.Write("-> число является палиндромом");
                    }
                    else Console.Write("-> число не является палиндромом");

                }
                Console.ReadKey();
            }
            void Zadacha21()
            {
                // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
                // A(3, 6, 8); B(2, 1, -7), -> 15.84
                // A(7, -5, 0); B(1, -1, 9)-> 11.53

                Console.WriteLine("Введите A[x]");
                int numberAx = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Введите A[y]");
                int numberAy = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Введите A[z]");
                int numberAz = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Введите B[x]");
                int numberBx = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Введите B[y]");
                int numberBy = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Введите B[z]");
                int numberBz = Convert.ToInt16(Console.ReadLine());
                double D = Math.Sqrt(Math.Pow(numberAx - numberBx, 2) + Math.Pow(numberAy - numberBy, 2) + Math.Pow(numberAz - numberBz, 2));
                Console.WriteLine("Расстояние между точками: " + Math.Truncate(100 * D) / 100);

                Console.ReadKey();
            }
            void Zadacha23()
            {
                //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
                //3-> 1, 8, 27
                //5-> 1, 8, 27, 64, 125
                Console.WriteLine("Введите число");
                int number = Convert.ToInt16(Console.ReadLine());
                int startnumber = 0;
                while (number != startnumber)
                {
                    startnumber += 1;
                    Console.WriteLine(Math.Pow(startnumber, 3));
                }
                Console.ReadKey();
            }
            //Zadacha23();
            //Zadacha21();
            //Zadacha19();
        }
    }
}
