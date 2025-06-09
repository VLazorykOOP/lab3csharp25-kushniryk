using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    internal class Trapeze
    {
        int a;
        int b;

        int h;

        string c;

        public Trapeze(int a, int b, int h, string c)
        {
            this.a = a;
            this.b = b;
            this.h = h;
            this.c = c;
        }
        public void printTrapeze()
        {
            Console.WriteLine($"a: {a}, b: {b}, h: {h}");
        }
        public void P()
        {
            int p = a + a + b + b;
            Console.WriteLine($"P: {p}");
        }
        public void S()
        {
            int s = ((a + b) / 2) * h;
            Console.WriteLine($"S: {s}");
        }
        public void isSquare()
        {
            if (a == b) Console.WriteLine($"Trapeze is square");
            else Console.WriteLine($"Trapeze is not square");
        }
        public void SetA(int a)
        {
            this.a = a;
        }
        public void SetB(int b) 
        { 
            this.b = b; 
        }
        public void SetH(int h)
        {
            this.h = h;
        }
        public void GetC()
        {
            Console.WriteLine($"Color: {c}");
        }
    }
}
