using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 1. Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числ а с использованием тернарной операции.

            //Random n = new Random();
            //int chislo = n.Next(10, 99);
            //Console.WriteLine($"случайное число {chislo}");
            //string re = chislo % 2 == 0 ? "Четное" : "Нечетное";
            //Console.WriteLine($"{re}");
            //Console.ReadKey();

            //Задание 2 Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.
            //try
            //{
            // Console.WriteLine("Введите номер недели:");
            // int n = int.Parse(Console.ReadLine());
            // switch Нет
            // {
            // case 1:Console.WriteLine("Понедельник");
            // break;
            // case 2:Console.WriteLine("Вторник");
            // break;
            // case 3: Console.WriteLine("Среда");
            // break;
            // case 4:Console.WriteLine("Четверг");
            // break;
            // case 5: Console.WriteLine("Пятница");
            // break;
            // case 6: Console.WriteLine("Суббота");
            // break;
            // case 7:Console.WriteLine("Воскресенье");
            // break;
            // default: Console.WriteLine("Выберите от 1 до 7");
            // break;

            // }
            // Console.ReadKey();//Задание 3 Задача 3. Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.
            //try
            //{
            //Random n = new Random();

            // int ne = n.Next(1, 7);

            // switch(ne)
            // {
            // case 1: Console.WriteLine($"Понедельник{ne}");
            // break;
            // case 2:
            // Console.WriteLine($"Вторник {ne}");
            // break;
            // case 3:
            // Console.WriteLine($"Среда{ne}");
            // break;
            // case 4:
            // Console.WriteLine($"Четверг{ne}");
            // break;
            // case 5:
            // Console.WriteLine($"Пятница{ne}");
            // break;
            // case 6:
            // Console.WriteLine($"Суббота{ne}");
            // break;
            // case 7:
            // Console.WriteLine($"Воскресенье{ne}");
            // break;
            // default:
            // Console.WriteLine("Выберите от 1 до 7");
            // break;
            // }
            //Console.ReadKey();
            //}
            //catch (Exception ex)
            //{
            // Console.WriteLine($"Исключение:{ex.Message}");
            //}
            //Console.ReadKey();
            //Дан признак геом. фигуры на плоскости
            //К - круг ((можем вводить и маленькую и большую)) П - Прямоугольник Т - Треугольник,
            //вывести на экран периметр и площадь фигуры, с учета, что данные необходимые запрашиваются у пользователя
            //Console.WriteLine("выберите фигуру:");
            //char n = char.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 'К':
            //    case 'к':
            //        double pi = Math.PI;
            //        Console.WriteLine($"Вы выбрали Круг!");
            //        Console.WriteLine("Введите радиус:");
            //        int p1 = int.Parse(Console.ReadLine());
            //        double c = 2 * pi * p1;
            //        Console.WriteLine("периметр");
            //        double S = pi * (c * 2);
            //        Console.WriteLine($"радиус = {c}, периметр = {S}");


            //        break;
            //    case 'П':
            //    case 'п':
            //        Console.WriteLine($"Вы выбрали прямоугольник");
            //        Console.WriteLine($"Выберите сторону a:");
            //        int storonaa = int.Parse(Console.ReadLine());
            //        Console.WriteLine($"Выберите сторону b:");
            //        int storonab = int.Parse(Console.ReadLine());
            //        int p = 2 * (storonaa + storonab);

            //        int p3 = storonaa * storonab;
            //        Console.WriteLine($"Периметр: {p} Площадь = {p3}");

            //        break;
            //    case 'Т':
            //    case 'т':
            //        Console.WriteLine($"Вы выбрали треугольник");
            //        Console.WriteLine("Выберите сторону a:");
            //        int a = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Выберите сторону b:");
            //        int b = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Выберите сторону c:");
            //        int c1 = int.Parse(Console.ReadLine());
            //        int pt = a + b + c1;
            //        int ptt = a * pt / 2;
            //        Console.WriteLine($"периметр = {pt} площаль = {ptt}");

            //        break;

            //    default:
            //        Console.WriteLine("выберите к-п-т");
            //        break;
            //}
            //Console.ReadKey();
        }
    }
}
