using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void bai1()
        {
            Console.WriteLine("Nhap vao a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao c: ");
            float c = float.Parse(Console.ReadLine());

            if (a == 0)
                if (b == 0)
                    if (c == 0)
                        Console.WriteLine("Phuong trinh co vo so nghiem nha ba");
                    else Console.WriteLine("Phuong trinh vo nghiem nha ba");
                else Console.WriteLine("Nghiem x = {0}" + (-c/b));
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0) Console.WriteLine("Vo nghiem nha ba");
                else if (delta == 0) Console.WriteLine("Pt co nghiem kep: x1 = x2 = " + (-b / (2 * a)));
                    else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x1 = {0} va x2 = {1}", x1, x2);
                }

            }
        }
        static void bai2()
        {
            Console.Write("Nhap ten vo di: ");
            string name = Console.ReadLine();
            bool a = name.Contains("Thi");
            if (a)
                Console.Write("Nu");
            else
                Console.Write("Nam");
        }
        static void bai3()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("May tinh kieu C#");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Nhap A: ");
            float a = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Nhap B: ");
            float b = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ket qua ta co duoc nhu sau: ");
            Console.WriteLine("A + B = " + (a + b));
            Console.WriteLine("A - B = " + (a - b));
            Console.WriteLine("A * B = " + (a * b));
            Console.WriteLine("A / B = " + (a / b));
            Console.WriteLine("Can bac 2 cua A la: " + (Math.Sqrt(a)));
            Console.WriteLine("Can bac 2 cua B la: " + (Math.Sqrt(b)));
        }
        static void bai6()
        {
            Console.Write("Nhap 4 so: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int max = a, min = a;
            if (max < b) max = b;
            if (max < c) max = c;
            if (max < d) max = d;
            if (min > b) min = b;
            if (min > c) min = c;
            if (min > d) min = d;
            Console.WriteLine("So lon nhat la: {0}", max);
            Console.Write("So nho nhat la: {0}", min);
        }
        static void bai7()
        {
            int[] a = new int[4];
            Console.Write("Nhap 4 so: ");
            for (int i = 0; i <= 3; i++)
                a[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
                for (int j = i + 1; j <= 3; j++)
                    if (a[i] < a[j]) (a[i], a[j]) = (a[j], a[i]);

            foreach (int i in a) Console.Write("{0} ", i);
        }
        static void bai8()
        {
            Console.Write("Nhap so nguyen N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("{0} la so ", n);
            if (n % 2 == 0) Console.Write("chan"); else Console.Write("le");
        }
        static void bai9()
        {
            Console.Write("Nhap so N: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 3 == 0 && n % 5 == 0) Console.Write($"{n} la boi so cua 3 va 5");
            else Console.Write($"{n} khong phai la boi so cua 3 va 5");
        }
        static void bai11()
        {
            Console.Write("Nhap thang: ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Thang {0} co 31 ngay", month);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang {0} co 30 ngay", month);
                    break;
                case 2:
                    Console.WriteLine("Thang {0} co 28 hoac 29 ngay", month);
                    break;
                default:
                    Console.WriteLine("Khong co thang nay");
                    break;
            }
        }
        static void bai12()
        {
            Console.Write("Nhap nam ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0) Console.Write("{0} la nam nhuan", year);
            else if (year % 400 == 0) Console.Write("{0} la nam nhuan", year);
            else Console.Write("{0} khong phai la nam nhuan", year);
        }
        static void bai14()
        {
            Console.Write("Nhap 1 chu bat ky tu A den G ");
            char a = char.Parse(Console.ReadLine());
            switch ((int)a)
            {
                case 65: Console.Write("Am tuong ung voi {0} la La", a); break;
                case 66: Console.Write("Am tuong ung voi {0} la Si", a); break;
                case 67: Console.Write("Am tuong ung voi {0} la Do", a); break;
                case 68: Console.Write("Am tuong ung voi {0} la Re", a); break;
                case 69: Console.Write("Am tuong ung voi {0} la Mi", a); break;
                case 70: Console.Write("Am tuong ung voi {0} la Fa", a); break;
                case 71: Console.Write("Am tuong ung voi {0} la Sol", a); break;

            }
        }
        static void Main(string[] args)
        {
            //bai1();
            //bai2();
            //bai3();
            //bai6();
            //bai7();
            //bai8();
            //bai9();
            //bai11();
            //bai12();
            //bai14();
        }
    }
}
