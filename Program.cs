namespace GladiatorFights
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlayController playController = new PlayController();
            FightOnArena fighterInArena = new FightOnArena();

            Console.WriteLine("Приветствую негодяи всех мастей и сорвиголовы! Сегодня вас ждут кровавое зрелище!");
            Console.ReadKey();

            playController.ListFighter();

            bool exitProgram = false;

            while (exitProgram != true)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите действия: " +
                    "\n 1. Выбор бойцов. " +
                    "\n 2. Выход из программы.");
                Console.WriteLine();

                string choiceCommand = Console.ReadLine();

                if (int.TryParse(choiceCommand, out int command))
                {
                    switch (command)
                    {
                        case (int)CommandConsole.StartFight:
                            Console.WriteLine();
                            Console.WriteLine("Напишите номер понравившегося бойца:");
                            int firstCharacter = Convert.ToInt32(Console.ReadLine());
                            playController.ChoiceFighter(firstCharacter);
                            Console.WriteLine();
                            Console.WriteLine("Выберите соперника:");
                            int secondCharacter = Convert.ToInt32(Console.ReadLine());
                            playController.ChoiceFighter(secondCharacter);
                            Console.WriteLine();
                            Console.WriteLine("Бойцы на арене:");
                            fighterInArena.Display();
                            Console.WriteLine("Начала сражения:");
                            playController.Fight(firstCharacter, secondCharacter);
                            break;
                        case (int)CommandConsole.EndFight:
                            Console.WriteLine("Выход из программы...");
                            Thread.Sleep(1000);
                            exitProgram = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}

public enum CommandConsole
{
    StartFight = 1,
    EndFight
}