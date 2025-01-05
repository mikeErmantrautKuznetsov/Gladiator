namespace GladiatorFights
{
    public class FightOnArena
    {
        private readonly Dictionary<int, DataFighter> fighterInArena = new Dictionary<int, DataFighter>();
        public void AddFighter(int key, DataFighter choiceFighter)
        {
            fighterInArena.TryAdd(key, choiceFighter);
        }

        public void Display()
        {
            foreach (KeyValuePair<int, DataFighter> _fighterInArena in fighterInArena)
            {
                Console.WriteLine($" Имя:{_fighterInArena.Value.Name}. " +
                    $" Национальность:{_fighterInArena.Value.National}. " +
                    $" Здоровье:{_fighterInArena.Value.Health}. " +
                    $"\nБроня:{_fighterInArena.Value.Armor}. " +
                    $" Урон:{_fighterInArena.Value.Damage}. ");
                Console.WriteLine();
            }
        }

        public void Fight(int _firstFighter, int _secondFighter)
        {
            var fighterFirst = fighterInArena[_firstFighter];
            var fighterSecond = fighterInArena[_secondFighter];

            while (fighterFirst.Health > 0 && fighterSecond.Health > 0)
            {
                Console.WriteLine($"Первый боец: Имя: {fighterFirst.Name} = " +
                    $"{fighterFirst.Health = (fighterFirst.Health - fighterSecond.Damage) % fighterFirst.Armor}");

                Console.WriteLine($"Второй боец: Имя: {fighterSecond.Name} = " +
                    $"{fighterSecond.Health = (fighterSecond.Health - fighterFirst.Damage) % fighterFirst.Armor}");
                Console.ReadKey();
            }
        }
    }
}
