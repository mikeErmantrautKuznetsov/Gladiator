namespace GladiatorFights
{
    public class FightOnArena : ITakeDamage
    {
        private readonly Dictionary<int, DataFighter> _fighterInArena = new Dictionary<int, DataFighter>();

        public void Add(int key, DataFighter choiceFighter)
        {
            _fighterInArena.Add(key, choiceFighter);
        }

        public void Clear()
        {
            _fighterInArena.Clear();
        }

        public void Display()
        {
            foreach (KeyValuePair<int, DataFighter> fighterInArena in _fighterInArena)
            {
                Console.WriteLine($" Имя:{fighterInArena.Value.Name}. " +
                    $" Национальность:{fighterInArena.Value.National}. " +
                    $" Здоровье:{fighterInArena.Value.Health}. " +
                    $"\nБроня:{fighterInArena.Value.Armor}. " +
                    $" Урон:{fighterInArena.Value.Damage}. ");
                Console.WriteLine();
            }
        }

        public void TakeDamage(int damageFirstFighter, int damageSecondFighter)
        {
            var fighterFirst = _fighterInArena[damageFirstFighter];
            var fighterSecond = _fighterInArena[damageSecondFighter];

            while (fighterFirst.Health >= 0 || fighterSecond.Health >= 0)
            {
                fighterFirst.Health -= fighterSecond.Damage - (fighterFirst.Armor / 3);
                fighterSecond.Health -= fighterFirst.Damage - (fighterSecond.Armor / 3);

                if (fighterFirst.Health <= fighterSecond.Damage)
                {
                    fighterFirst.Health = 0;
                    break;
                }
                else if (fighterSecond.Health <= fighterFirst.Damage)
                {
                    fighterSecond.Health = 0;
                    break;
                }
            }
        }

        public void DisplayResult(int _firstFighter, int _secondFighter)
        {
            var fighterFirst = _fighterInArena[_firstFighter];
            var fighterSecond = _fighterInArena[_secondFighter];

            Console.WriteLine($"Первый боец: Имя: {fighterFirst.Name} = " +
                    $"Здоровье первого бойца: {fighterFirst.Health}");

            Console.WriteLine($"Второй боец: Имя: {fighterSecond.Name} = " +
                $"Здоровье второго бойца: {fighterSecond.Health}");

            if (fighterFirst.Health <= 0)
            {
                Console.WriteLine("Второй боец победил.");
            }
            else
            {
                Console.WriteLine("Первый боец победил.");
            }

            Console.ReadKey();
        }

    }
}
