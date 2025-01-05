namespace GladiatorFights
{
    public class DataFighter
    {
        public string Name { get; set; }
        public string National { get; set; }

        public int Health { get; set; }
        public int Armor { get; set; }
        public int Damage { get; set; }

        public DataFighter(string Name, string National, int Health, int Armor, int Damage)
        {
            this.Name = Name; this.National = National; this.Health = Health; 
            this.Armor = Armor; this.Damage = Damage;
        }
    }
}
