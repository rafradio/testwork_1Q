using System;

namespace StringArray
{
    class ProgramMain
    {
        // ограничиваем количество элементов в вводимом массиве
        public int numberOfStrings = 10;
        static void Main(string[] args) 
        {
            Console.Clear();
            InitialSettings init = new();
            // создаем первоначальный массив вводом с клавиатуры
            init.Initsets(0);
            // создаем результирующий массив
            init.CreateArray();
            // выводим на печать
            init.PrintArray(); 
        }
    }
}