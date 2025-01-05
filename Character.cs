namespace GladiatorFights
{
    public class Character : DataFighter
    {
        public Character(string Name, string National, int Health, int Armor, int Damage) : base(Name, National, Health, Armor, Damage) 
        { 
            this.Name = Name; 
            this.Health = Health; 
            this.Armor = Armor; 
            this.Damage = Damage; 
            this.National = National; 
        }
    }
}
