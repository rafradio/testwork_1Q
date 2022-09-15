using System;

namespace StringArray
{
    class InitialSettings : ProgramMain
    {
        public InitialSettings()
        {
            this.Initsets(0);


        }
        public void Initsets(int iType)
        {
            if (iType < this.numberOfStrings)
            {
                string[] dataType = {"N", "M"};
                Console.Write($"Введите пожалуйста текстовую строку для первоначального массива: ");
                string enterUser = Console.ReadLine();
                if (int.TryParse(enterUser, out int number))
                {
                    switch (iType)
                    {
                        case 0:
//                            this.digitN = number;
                            break;
                        case 1:
//                            this.digitM = number;
                            break;
                    }
                    iType += 1;
                }
                else
                {
                    Console.WriteLine("Вы ввели не число. Повторите!");
                }
                this.Initsets(iType);
            }
            return;
        }
    }
}