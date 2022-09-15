using System;

namespace StringArray
{
    class InitialSettings : ProgramMain
    {
        public string[] initialArray;
        public InitialSettings()
        {
            this.Initsets(0);


        }
        public void Initsets(int counter)
        {
            if (counter < this.numberOfStrings)
            {
                Console.Write("Введите пожалуйста текстовую строку для первоначального массива: ");
                string enterUser = Console.ReadLine();
                if (!(enterUser == null))
                {
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
    }
}