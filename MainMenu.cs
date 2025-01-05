namespace GladiatorFights
{
    public class MainMenu
    {
        private Dictionary<int, DataFighter> champions = new Dictionary<int, DataFighter>()
        {
            {1, new Character("Убийца", "Орк", 100, 20, 30) },
            {2, new Character("Святоша", "Эльф", 100, 20, 15) },
            {3, new Character("Олег", "Человек", 100, 20, 10) },
            {4, new Character("Потрошитель", "Берсерк", 100, 20, 25) },
        };

        public void Display()
        {
            foreach(KeyValuePair<int, DataFighter> keyValuePair in champions)
            {
                Console.WriteLine($"\nНомер:{keyValuePair.Key}. " +
                    $"Имя:{keyValuePair.Value.Name}. " +
                    $" Национальность:{keyValuePair.Value.National}. " +
                    $" Здоровье:{keyValuePair.Value.Health}. " +
                    $"\nБроня:{keyValuePair.Value.Armor}. " +
                    $" Урон:{keyValuePair.Value.Damage}. ");
                Console.WriteLine();

                keyValuePair.Value.Health = 100;
            }
        }

        public bool TryGetFighter(int id, out DataFighter fighter)
        {
            fighter = null;

            if (champions.ContainsKey(id))
            {
                fighter = champions[id];
                return true;
            }
            return false;
        }
    }
}
