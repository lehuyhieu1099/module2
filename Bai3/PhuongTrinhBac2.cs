﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Bai3
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter a : ");
    //        double a = double.Parse(Console.ReadLine());
    //        Console.Write("Enter b : ");
    //        double b = double.Parse(Console.ReadLine());
    //        Console.Write("Enter c : ");
    //        double c = double.Parse(Console.ReadLine());
    //        PhuongTrinhBac2 ptbac2 = new PhuongTrinhBac2(a, b, c);
    //        ptbac2.GetDelta();
    //        ptbac2.Getroots();
    //    }
    //}
    class PhuongTrinhBac2
    {
        private double a, b, c;
        private double delta;
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        public double Delta{ get => delta; }

        public PhuongTrinhBac2()
        {

        }
        public PhuongTrinhBac2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetDelta()
        {
            return delta = b * b - 4 * a * c;
        }
        public void Getroots()
        {
            if (delta < 0)
            {
                Console.WriteLine("No root");
            }
            if (delta == 0)
            {
                Console.WriteLine($"Has one root : x = {-b / (2 * a)}");
            }
            if (delta > 0)
            {
                Console.WriteLine("Has 2 roots: ");
                Console.WriteLine($"x1 = {(-b + Math.Pow(delta,0.5)) / (2 * a)}");
                Console.WriteLine($"x2 = {(-b - Math.Pow(delta, 0.5)) / (2 * a)}");
            }
        }
    }
}
