namespace GladiatorFights
{
    public class DataFighter
    {
        public string Name { get; private set; }
        public string National { get; private set; }

        public int Health { get; set; }
        public int Armor { get; set; }
        public int Damage { get; set; }

        public DataFighter(string name, string national, int health, int armor, int damage)
        {
            Name = name;
            National = national;
            Health = health;
            Armor = armor;
            Damage = damage;
        }
    }
}
