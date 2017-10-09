using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("From Phuong\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(52, 1);
            Console.WriteLine("To Sen:\n");
            string hpbd = "Happy Birthday To You!";
            for (int i = 10; i < 30; i = i + 10)
            {
                Console.WriteLine();
                Console.SetCursorPosition(50, 2);
                Console.WriteLine("Loading.... {0} %", i);
                Console.SetCursorPosition(30, 3);
                Console.WriteLine("---------------------------------------------------");
                int a = (i == 10) ? 1 : 2;
                Console.SetCursorPosition(45, 4 + a);
                for (int j = 0; j < hpbd.Length; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(hpbd[j]);
                    Thread.Sleep(200);
                }
            }
            string s = "Happy Birthday Dear My Friend!";
            for (int i = 40; i <= 60; i = i + 20)
            {
                Console.SetCursorPosition(50, 2);
                Console.WriteLine("Loading....{0} ", i);
                Console.SetCursorPosition(30, 3);
                Console.WriteLine("---------------------------------------------------");
                int b = (i == 40) ? 1 : 2;
                Console.SetCursorPosition(43, 7 + b);
                for (int j = 0; j < s.Length; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(s[j]);
                    Thread.Sleep(200);
                }
                int c = (i == 40) ? 1 : 2;
                Console.SetCursorPosition(45, 7 + b + c);
                for (int j = 0; j < hpbd.Length; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(hpbd[j]);
                    Thread.Sleep(200);
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("From Phuong\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(52, 1);
            Console.WriteLine("To Sen:\n");
            for (int i = 80; i < 90; i = i + 10)
            {
                Console.SetCursorPosition(50, 2);
                Console.WriteLine("Loading....{0} %", i);
                Console.SetCursorPosition(30, 3);
                Console.WriteLine("---------------------------------------------------");
                for (int j = 1; j <= 2; j++)
                {
                    Console.SetCursorPosition(51, 3 + j);
                    Console.WriteLine();
                    for (int k = 2; k <= 12; k++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(51 + k, 3 + j);
                        Console.Write("i");
                        Thread.Sleep(200);
                    }
                }
            }
            string arr2 = "__i_i_i_i_i_i__";
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(51 + i, 6);
                Console.Write(arr2[i]);
                Thread.Sleep(200);
            }
            string arr3 = ":<3          <3:";
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(51 + i, 7);
                Console.Write(arr3[i]);
                Thread.Sleep(200);
            }
            string arr4 = "__: <3   28/6   <3 :__";
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(48 + i, 8);
                Console.Write(arr4[i]);
                Thread.Sleep(200);
            }
            string arr5 = ": <3    <3    <3    <3 :";
            for (int i = 0; i < arr5.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(47 + i, 9);
                Console.Write(arr5[i]);
                Thread.Sleep(200);
            }
            string arr6 = "__: <3      HAPPY     <3 :__";
            for (int i = 0; i < arr6.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(45 + i, 10);
                Console.Write(arr6[i]);
                Thread.Sleep(200);
            }
            string arr7 = ": <3   <3  BIRTHDAY  <3   <3 :";
            for (int i = 0; i < arr7.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(44 + i, 11);
                Console.Write(arr7[i]);
                Thread.Sleep(200);
            }
            string arr8 = ":  <3   <3   SenKa  <3   <3  :";
            for (int i = 0; i < arr8.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(44 + i, 12);
                Console.Write(arr8[i]);
                Thread.Sleep(200);
            }
            string arr9 = ":         <3     <3          :";
            for (int i = 0; i < arr9.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(44 + i, 13);
                Console.Write(arr9[i]);
                Thread.Sleep(200);
            }
            string arr10 = "_________________<3_________________";
            for (int i = 0; i < arr10.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(41 + i, 14);
                Console.Write(arr10[i]);
                Thread.Sleep(200);
            }
            string arr11 = "HAPPY BIRTHDAY TO HA KHUNG";
            for (int i = 0; i < arr11.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(50 + i, 16);
                Console.Write(arr11[i]);
                Thread.Sleep(200);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("From Phuong\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(52, 1);
            Console.WriteLine("To Sen:\n");
            int x = 0;
            string sn = "Chuc Sen sinh nhat vui ve, mau an chong lon";
            for (int i = 90; i <= 99; i++)
            {
                Console.WriteLine();
                Console.SetCursorPosition(50, 2);
                Console.WriteLine("Loading.... {0} %", i);
                Thread.Sleep(500);
                Console.SetCursorPosition(30, 3);
                Console.WriteLine("---------------------------------------------------");
            }
            while (Console.KeyAvailable != true)
            {
                if (x == 50)
                {
                    break;
                }
                Console.Clear();
                Console.SetCursorPosition(x, 3);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(sn);
                x++;
                Thread.Sleep(200);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("From Phuong\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(52, 1);
            Console.WriteLine("To Sen:\n");
            for (int i = 99; i <= 100; i++)
            {
                Console.WriteLine();
                Console.SetCursorPosition(50, 2);
                Console.WriteLine("Loading....{0} %", i);
                Console.SetCursorPosition(30, 3);
                Console.WriteLine("---------------------------------------------------");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(48, 5);
            Console.WriteLine("A SIMPLE - CODE GIFT");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(28, 7);
            Console.WriteLine("WISHING U FILL OF LAUGH, HAPPINESS, SUCCESS, HEALTH IN THE NEW AGE");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(48, 9);
            Console.WriteLine("THANKS FOR WATCHING");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("HAVE A NICE DAY!!!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(46, 13);
            Console.WriteLine("WISH ALL BEST IS FOR YOU");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(41, 15);
            Console.Write("nhap gia tri n(nhap 58 chuan nhat): ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = n / 2; i <= n; i = i + 2)
            {
                for (int j = 1; j < (n - i); j = j + 2)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = n; i >= 1; i--)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (i * 2) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
