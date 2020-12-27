
using System;
namespace Lab._5
{
    class Program
    {
        delegate object Operation(int i, double d);
        /// <summary>
        /// Функция суммирования. Преобразует double в int и возвращает сумму двух

        /// </summary>
        /// <param int-переменная="i"></param>
        /// <param double-переменная="d"></param>
        /// <returns></returns>
        static object Summ(int i, double d)
        {
            object result = i + (int)d;
            return result;
        }
        /// <summary>
        /// Метод, использующий делегат
        /// </summary>
        static object Method4(int i, double d, Operation op)
        {
            object result = op(i, d);
            return result;
        }
        /// <summary>
        /// Метод для использования Action
        /// </summary>
        static void ActionUse(int i, double d)
        {
            double result = (double)i + d;
            Console.WriteLine(result.ToString());
        }
        /// <summary>
        /// Метод, использующий Func
        /// </summary>
        static object Method4Func(int i, double d, Func<int, double, object> func)
        {
            object result = func(i, d);
            return result;
        }
        /// <summary>
        /// Метод, использующий Action
        /// </summary>
        static void Method4Action(int i, double d, Action<int, double> act)
        {
            act(i, d);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Работа с делегатами");

            Console.WriteLine("Обычный делегат");

            object Result = Method4(4, 5.4, Summ);
            Console.WriteLine(Result.ToString());

            Console.WriteLine("Использование лямбда-функции");

            Result = Method4
            (
            8,
            7.89,
            (int i, double d) =>
            {
                object result = (double)i + d;
                return result;
            }
            );
            Console.WriteLine(Result.ToString());

            Console.WriteLine("Использование обобщённого делегата Func");

            Result = Method4Func(9, 5.44, (x, y) => x + (int)y);
            Console.WriteLine(Result.ToString());

            Console.WriteLine("Использование обобщённого делегата Action");

            Method4Action(77, 88.785, ActionUse);
            Console.ReadKey();
        }
    }
}

