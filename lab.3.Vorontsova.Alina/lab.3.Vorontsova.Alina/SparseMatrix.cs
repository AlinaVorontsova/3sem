using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace lab3
{
    public class Matrix<T>
    {

        Dictionary<string, T> _matrix = new Dictionary<string, T>();    // Словарь для хранения значений

        int maxX;   // Количество элементов по горизонтали (максимальное количество столбцов)
        int maxY;   //Количество элементов по вертикали (максимальное количество строк)
        int maxZ;
        T nullElement;  //Пустой элемент, который возвращается если элемент с нужными координатами не был задан

        public Matrix(int px, int py, T nullElementParam)//конструктор для квадрата
        {
            this.maxX = px;
            this.maxY = py;
            this.nullElement = nullElementParam;
        }
        public Matrix(int px, int py, int pz, T nullElementParam)//конструктор для трехмерной модификации
        {
            this.maxX = px;
            this.maxY = py;
            this.maxZ = pz;
            this.nullElement = nullElementParam;
        }


        public T this[int x, int y] // Индексатор для доступа к данным XY
        {
            get
            {
                CheckBounds(x, y);//проверка границ матрицы
                string key = DictKey(x, y);//вычисление ключа для записи в словарь
                if (this._matrix.ContainsKey(key))//проверка наличия ключа в словаре
                {
                    return this._matrix[key];//если такой ключ в словаре есть - верни значение 
                }
                else
                {
                    return this.nullElement;//если такого ключа нет, то пустое значение
                }
            }
            set
            {
                CheckBounds(x, y);
                string key = DictKey(x, y); this._matrix.Add(key, value);//запись ключей в матрицу
            }
        }

        public T this[int x, int y, int z] // Индексатор для доступа к данным XYZ
        {
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);//вычисление ключа для записи в словарь
                if (this._matrix.ContainsKey(key))//проверка существования ключа в словаре(если да, то вернется значение элемента, если нет - пустое значение)
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.nullElement;
                }
            }
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z); this._matrix.Add(key, value);//запись ключей в матрицу
            }
        }


        void CheckBounds(int x, int y)  // Проверка границ
        {
            if (x < 0 || x >= this.maxX) throw new Exception("x=" + x + " выходит за границы");//вывод об ошибке
            if (y < 0 || y >= this.maxY) throw new Exception("y=" + y + " выходит за границы");//вывод об ошибке
        }

        void CheckBounds(int x, int y, int z)  // Проверка границ для трех мерной матрицы
        {
            if (x < 0 || x >= this.maxX) throw new Exception("x=" + x + " выходит за границы");//вывод об ошибке
            if (y < 0 || y >= this.maxY) throw new Exception("y=" + y + " выходит за границы");//вывод об ошибке
            if (z < 0 || z >= this.maxZ) throw new Exception("z=" + z + " выходит за границы");//вывод об ошибке
        }

        string DictKey(int x, int y)    // Формирование ключа XY
        {
            return x.ToString() + "_" + y.ToString();
        }

        string DictKey(int x, int y, int z)    // Формирование ключа XYZ
        {
            return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
        }

         public override string ToString()   // Значения матрицы выводятся в строковом представлении
        {

            StringBuilder b = new StringBuilder();//класс для добавления данных в строки
            
                for (int j = 0; j < maxX; j++)
                {
                    b.Append("[");//дописать в конец внутренней строки 
                    for (int i = 0; i < maxY; i++)
                    {
                        for (int k = 0; k < maxZ; k++)
                        {
                            if (k > 0) b.Append("\n");//добавление разделителя табуляции

                        b.Append(this[i, j, k].ToString());//добавить приведенный к строке текущий элемент
                        }
                        b.Append("]\n");
                    }
                }
                
            
            return b.ToString();
        }

        public void print()
        {
            Console.WriteLine(this.ToString());
        }


    }
} 
