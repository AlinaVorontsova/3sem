using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using static System.Math;

namespace lab2.Vorontsova.Alina
{
    interface IPrint
    {
        void Print();
    }
    class platform
    {
        static double Prov(string k)
        {
            double ans;
            bool F = Double.TryParse(k, out ans);
            while (!F)
            {
                Console.WriteLine("Введите корректное значение");
                k = Console.ReadLine();
                F = Double.TryParse(k, out ans);
            }
            return ans;
        }
        static void Main(string[] args)
        {
            
            int k;

            do
            {
                Console.WriteLine("_________Выберите цифру________");
                Console.WriteLine("1.Прямоугольник");
                Console.WriteLine("2.Квадрат");
                Console.WriteLine("3.Круг");
                Console.WriteLine("0.Выход");
                k = (int)Prov(Console.ReadLine());
                if (k == 1)
                {
                    Console.WriteLine("Введите высоту и ширину прямоугольника");
                    double h = System.Convert.ToDouble(Console.ReadLine());
                    double w = System.Convert.ToDouble(Console.ReadLine());
                    Rectangle rect = new Rectangle(h, w);
                    rect.Print();

                }
                else if (k == 2)
                {
                    Console.WriteLine("Введите сторону квадрата");
                    double h = System.Convert.ToDouble(Console.ReadLine());
                    Square sqr = new Square(h);
                    sqr.Print();

                }
                else if (k == 3)
                {
                    Console.WriteLine("Введите радиус круга");
                    double h = System.Convert.ToDouble(Console.ReadLine());
                    Circle cir = new Circle(h);
                    cir.Print();
                }
            } while (k != 0);
        }
    }

    abstract class Figure
    {

        public abstract double Area();


    }

    class Rectangle : Figure, IPrint
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public override double Area()
        {
            return this.Height * this.Width;
        }
        public override string ToString()
        {
            return $"Площадь прямоугольника с высотой {Height} и шириной {Width} равна {Area()}";

        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
    class Circle : Figure, IPrint
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double Area()
        {
            return this.Radius * this.Radius * PI;
        }
        public override string ToString()
        {
            return $"Площадь круга с радиусом {Radius} равна {Area()}";

        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
    class Square : Rectangle, IPrint
     
    {
        public double side;
        public Square(double side) : base(side, side)
        {
            this.side = side;
        }
        public override double Area()
        {
            return this.side * this.side;
        }
        public override string ToString()
        {
            return $"Площадь квадрата со стороной {side} равна {Area()}";

        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
    
  
        }


    
    




