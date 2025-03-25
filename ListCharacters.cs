namespace GladiatorFights
{
    public class ListCharacters
    {
        private Dictionary<int, DataFighter> _champions = new Dictionary<int, DataFighter>()
        {
            {1, new DataFighter("Костя", "Человек", 100, 10, 15 ) },
            {2, new DataFighter("Крушитель", "Орк", 100, 15, 30 ) },
            {3, new DataFighter("Белоснежка", "Эльф", 100, 10, 20 ) },
            {4, new DataFighter("Омни-мэн", "Вильтрумит", 10000, 100, 1000 ) }
        };

        public void Display()
        {
            foreach (KeyValuePair<int, DataFighter> keyValuePair in _champions)
            {
                Console.WriteLine($"\nНомер:{keyValuePair.Key}. " +
                    $"Имя:{keyValuePair.Value.Name}. " +
                    $" Национальность:{keyValuePair.Value.National}. " +
                    $" Здоровье:{keyValuePair.Value.Health}. " +
                    $"\nБроня:{keyValuePair.Value.Armor}. " +
                    $" Урон:{keyValuePair.Value.Damage}. ");
                Console.WriteLine();
            }
        }

        public bool TryGetFighter(int id, out DataFighter fighter)
        {
            fighter = null;

            if (_champions.ContainsKey(id))
            {
                fighter = _champions[id];
                return true;
            }
            return false;
        }
    }
}
