using System;

namespace lab1.Vorontsova.IU5_32B
{
    class Program
    {
        static double Prov(string s)
        {
            double ans;
           bool F= Double.TryParse(s, out ans);
            while (!F)
            {
                Console.WriteLine("Введите корректное значение");
                s = Console.ReadLine();
               F=Double.TryParse(s, out ans);
            }
            return ans;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Воронцова Алина ИУ5-32Б");
            double A, B, C;
            Console.WriteLine("Введите коэффициент А:");
            A = Prov(Console.ReadLine());
            Console.WriteLine("Коэффициент А="+A);
            Console.WriteLine("Введите коэффициент В:");
            B = Prov(Console.ReadLine());
            Console.WriteLine("Коэффициент B=" + B);
            Console.WriteLine("Введите коэффициент С:");
            C = Prov(Console.ReadLine());
            Console.WriteLine("Коэффициент C=" + C);

            if ((Math.Pow(B, 2) - 4 * A * C) < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Корней нет");
                Console.ResetColor();
                return;
            }
            else if ((Math.Pow(B, 2) - 4 * A * C) == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Первый корень х1= " + (Math.Sqrt(-B / (2 * A))));
                Console.WriteLine("Второй корень х2= " + (-Math.Sqrt(-B / (2 * A))));
            }
            else
            {
                if (((-B + Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A)) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Первый корень х1= " + Math.Sqrt((-B + Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A)));
                    Console.WriteLine("Второй корень х2= " + -1 * Math.Sqrt((-B + Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A)));
                }
                if (((-B - Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A)) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Третий корень х3= " + Math.Sqrt((-B - Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A)));
                    Console.WriteLine("Четвертый корень х4= " + -1 * Math.Sqrt((-B - Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A)));
                }
            }
            if (C > 0 && A > 0 && B > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Корней нет");
            }
            Console.ResetColor();

        }
    }
}


        
    

