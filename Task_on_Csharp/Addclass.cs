using System;

namespace StringArray
{
    class InitialSettings : ProgramMain
    {
        public string[] initialArray = new string[0];
        public string[] resultArray = new string[0];
        public void Initsets(int counter)
        {
            if (counter < this.numberOfStrings)
            {
                Console.Write("Введите пожалуйста текстовую строку для первоначального массива: ");
                var enterUser = Console.ReadLine();
                if (!(enterUser == ""))
                {
                    // даем возможность выхода по "end"
                    if (!(enterUser.ToLower() == "end"))
                    {
                        counter += 1;
                        Array.Resize(ref this.initialArray, counter);
                        this.initialArray[counter - 1] = enterUser;
                    
                    }
                    else 
                    {
                        if (!(counter == 0)) return;
                        else Console.WriteLine("Первоначальный массив еще пустой!");
                    
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели пустую строчку. Повторите!");
                }
                this.Initsets(counter);
            }
            else
            {
            return;
            }
        }
        public void CreateArray()
        {
            int newArrayCounter = 0;
            for (int i = 0; i < this.initialArray.Length; i++)
            {
                if (this.initialArray[i].Length <= 3)
                {
                    Array.Resize(ref this.resultArray, ++newArrayCounter);
                    this.resultArray[newArrayCounter - 1] = this.initialArray[i];
                }
            }

        }
        public void PrintArray()
        {
            Console.WriteLine("\nВведенный массив:");
            for (int i = 0; i < this.initialArray.Length - 1; i++)
            {
                Console.Write($"'{this.initialArray[i]}', ");
            }
            Console.Write($"'{this.initialArray[this.initialArray.Length - 1]}' ");

            if (this.resultArray.Length == 0) Console.WriteLine("\n\nРезультирующий массив пустой.");
            else
            {
                Console.WriteLine("\n");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Новый массив:");
                Console.BackgroundColor = ConsoleColor.Black;
                for (int i = 0; i < this.resultArray.Length - 1; i++)
                { 
                    Console.Write($"'{this.resultArray[i]}', ");
                }
                Console.Write($"'{this.resultArray[this.resultArray.Length - 1]}' ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}