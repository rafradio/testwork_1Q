using System;

namespace StringArray
{
    class InitialSettings : ProgramMain
    {
        public string[] initialArray = new string[0];
        public string[] resultArray = new string[0];
//        public InitialSettings()
//        {
//            this.Initsets(0);
//        }
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
            for (int i = 0; i < this.initialArray.Length; i++)
            {
                int newArrayCounter = 0;
                if (this.initialArray[i].Length <= 3)
                {
                    Array.Resize(ref this.resultArray, newArrayCounter++);
                    this.resultArray[newArrayCounter - 1] = this.initialArray[i];
                }
            }

        }
    }
}