using System;

namespace CongratulatorLVL1
{
    internal class Program
    {
        static void Main()
        {
            Options.ShowTodaysBirthdays();
            Options.ShowNextBirthdays();

            var flag = true;
            while (flag)
            {
                Options.PrintChoiseMenu();
                if (!int.TryParse(Console.ReadLine(), out var choise))
                {
                    Console.WriteLine("Вы ввели некорректное значение.");
                    continue;
                }
                Console.Clear();
                switch (choise)
                {
                    case 0:
                        flag = false;
                        Options.SerializeBirthdayList();
                        Console.WriteLine("Завершение работы.");
                        break;

                    case 1:
                        Options.AddNewPerson();
                        continue;

                    case 2:
                        Options.RemovePerson();
                        continue;

                    case 3:
                        Options.ChangePerson();
                        continue;

                    case 4:
                        Options.SerializeBirthdayList();
                        continue;

                    case 5:
                        Options.ShowTodaysBirthdays();
                        continue;

                    case 6:
                        Options.ShowNextBirthdays();
                        continue;

                    case 7:
                        Options.PrintListOfPerson();
                        continue;

                    default:
                        Console.WriteLine("Выберите пункт из списка.");
                        continue;
                }
            }
        }
    }
}