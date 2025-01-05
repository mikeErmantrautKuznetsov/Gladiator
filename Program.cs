namespace GladiatorFights
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            SkillTree skillTree = new SkillTree();
            FightOnArena fighterInArena = new FightOnArena();

            Console.WriteLine("Приветствую негодяи всех мастей и сорвиголовы! Сегодня вас ждут кровавое зрелище! Время выбрать бойцов!. \n" +
                "Для продолжение обратитесь в консоль и нажмите любую кнопку.");
            Console.ReadKey();

            menu.Display();

            bool _exitProgram = false;

            while (_exitProgram != true)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите действия: " +
                    "\n 1. Выбор бойцов. " +
                    "\n 2. Выход из программы.");
                Console.WriteLine();

                string choiceCommand = Console.ReadLine();
                if (int.TryParse(choiceCommand, out int _choiceCommand))
                {
                    switch (_choiceCommand)
                    {
                        case (int)CommandConsole.StartFight:
                            Console.WriteLine();
                            Console.WriteLine("Напишите номер понравившегося бойца:");
                            int firstCharacter = Convert.ToInt32(Console.ReadLine());
                            if (menu.TryGetFighter(firstCharacter, out DataFighter fighterFirst))
                            {
                                fighterInArena.AddFighter(firstCharacter, fighterFirst);
                                skillTree.Character(firstCharacter);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Выберите соперника:");
                            int secondCharacter = Convert.ToInt32(Console.ReadLine());
                            if (menu.TryGetFighter(secondCharacter, out DataFighter fighterSecond))
                            {
                                fighterInArena.AddFighter(secondCharacter, fighterSecond);
                                skillTree.Character(secondCharacter);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Бойцы на арене:");
                            fighterInArena.Display();
                            Console.WriteLine("Начала сражения:");
                            fighterInArena.Fight(firstCharacter, secondCharacter);
                            Console.Clear();
                            menu.Display();
                            break;
                        case (int)CommandConsole.EndFight:
                            Console.WriteLine("Выход из программы...");
                            Thread.Sleep(1000);
                            _exitProgram = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}

enum CommandConsole
{
    StartFight = 1, 
    EndFight = 2
}