using System;
using System.Collections;
namespace ConsoleApp6
{

    public interface IMeasurable
    {
        double Perimeter();
        double Area();
    }

    class Square : IComparable<Square>, IMeasurable
    {
        protected int a;
        public Square(int a) { this.a = a; }
        public int CompareTo(Square b)
        {
            if (this.Perimeter() < b.Perimeter()) 
                return 1;
            
            else if (this.Perimeter() > b.Perimeter()) 
                return -1;
            
            return 0;
        }
        public void Show()
        {
            Console.WriteLine("Сторона квадрата: {0} , периметр квадрата: {1},площадь квадрата: {2} ", a, this.Perimeter(), this.Area());
        }
        public double Perimeter()
        {
            return a * 4;
        }

        public double Area()
        {
            return a * a;
        }

        public int A {
            get
            {
                return a;
            }
        }

    }
    
    class Program
    {
        static void Main()
        {
            Square[] a = new Square[3];
            a[0] = new Square(6);
            a[1] = new Square(3);
            a[2] = new Square(5);
            Array.Sort(a);
            Console.WriteLine();
            foreach(Square x in a )
            {
                x.Show();
            }

            Console.ReadKey();
        }
    }
}