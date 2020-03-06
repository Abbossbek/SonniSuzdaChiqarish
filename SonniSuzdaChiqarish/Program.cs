﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonniSuzdaChiqarish
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Uch xonali son: ");
            n =Convert.ToInt32(Console.ReadLine());
            if (n < 100 || n > 999)
            {
                Console.WriteLine("Uch xonali son kiritmadingiz!\nQanta kiriting: ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            int a = n / 100;
            int b = (n / 10) % 10;
            int c = n % 10;

            switch (a)
            {
                case 1: Console.Write("Bir yuz "); break;
                case 2: Console.Write("Ikki yuz "); break;
                case 3: Console.Write("Uch yuz "); break;
                case 4: Console.Write("To'rt yuz "); break;
                case 5: Console.Write("Besh yuz "); break;
                case 6: Console.Write("Olti yuz "); break;
                case 7: Console.Write("Yetti yuz "); break;
                case 8: Console.Write("Sakkiz yuz "); break;
                case 9: Console.Write("To'qqiz yuz "); break;
            }
            switch (b)
            {
                case 1: Console.Write("o'n "); break;
                case 2: Console.Write("yigirma "); break;
                case 3: Console.Write("o'ttiz "); break;
                case 4: Console.Write("qirq "); break;
                case 5: Console.Write("ellik "); break;
                case 6: Console.Write("oltmish "); break;
                case 7: Console.Write("yetmish "); break;
                case 8: Console.Write("sakson "); break;
                case 9: Console.Write("to'qson "); break;
                case 0: Console.Write(""); break;
            }
            switch (c)
            {
                case 1: Console.Write("bir."); break;
                case 2: Console.Write("ikki."); break;
                case 3: Console.Write("uch."); break;
                case 4: Console.Write("to'rt."); break;
                case 5: Console.Write("besh."); break;
                case 6: Console.Write("olti."); break;
                case 7: Console.Write("yetti."); break;
                case 8: Console.Write("sakkiz."); break;
                case 9: Console.Write("to'qqiz."); break;
                case 0: Console.Write("."); break;
            }

            Console.ReadKey();
        }
    }
}
