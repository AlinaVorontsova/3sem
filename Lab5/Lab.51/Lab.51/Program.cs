using System;
using System.Reflection;

namespace Lab._51
{
    class Program
    {
        /// <summary>
        /// Класс - атрибут
        /// </summary>
        [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
        public class ClassAttribute : Attribute
        {
            public ClassAttribute() { }
            public ClassAttribute(string s)
            {
                str = s;
            }
            public string str { get; set; }
        }
        /// <summary>
        /// Класс для проверки
        /// </summary>
        class DistanceForInspection
        {
            [ClassAttribute("Футы")]
            public int feet { get; set; }
            public double inches { get; set; }
            public DistanceForInspection() { feet = 0; inches = 0; }
            public DistanceForInspection(int i, double d) { feet = i; inches = d; }
            public int redoubleFeet(int f)
            {
                this.feet = f;
                return this.feet *= 2;
            }
            public double redoubleInches() => this.inches *= 2;
            public override string ToString()
            {
                return "Футы: " + feet + "дюймы: " + inches;
            }
        }
        static void Main(string[] args)
        {
            Type t = typeof(DistanceForInspection);

            Console.WriteLine("Конструкторы:");

            foreach (var i in t.GetConstructors())
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nСвойства");

            foreach (var i in t.GetProperties())
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nМетоды");

            foreach (var i in t.GetMethods())
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nСвойства с атрибутом");


            foreach (var i in t.GetProperties())
            {
                //true для поиска атрибутов в цепочке наследования этого элемента, иначе false
                var PropertyWithAttributes = i.GetCustomAttributes(typeof(ClassAttribute), false);
                if (PropertyWithAttributes.Length > 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\nВызов метода через рефлексию:");

            DistanceForInspection dfi = (DistanceForInspection)t.InvokeMember(
            null, BindingFlags.CreateInstance, null, null, new object[] { });
            object[] parameters = new object[] { 3 };
            object Result = t.InvokeMember("redoubleFeet", BindingFlags.InvokeMethod, null, dfi,
           parameters);
            Console.WriteLine("Метод, удваивающий футы: " + Result);
            Console.ReadKey();
        }

    }
}
    

