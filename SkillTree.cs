namespace GladiatorFights
{
    public class SkillTree : SpecialForce
    {
        private readonly MainMenu Menu = new MainMenu();
        RandomRangeClass Random = new RandomRangeClass();
        public void Character(int needCharacter)
        {
            if (Menu.TryGetFighter(needCharacter, out DataFighter fighter))
            {
                Console.WriteLine($"\nИмя:{fighter.Name}. " +
                    $"Броня:{fighter.Armor}. " +
                    $" Национальность:{fighter.National}. " +
                    $" Здоровье:{fighter.Health}. " +
                    $" Урон:{fighter.Damage}. ");
                Console.WriteLine();

                int randomPower = Random.GenerateRandom(1, 4);

                bool skew = true;
                bool resultDamage = true;

                switch(randomPower)
                {
                    case (int)SpecialPower.DoubleDamage:
                        DoubleDamage(fighter.Damage, fighter.Damage);
                        Console.WriteLine("Двойной урон.");
                        break;
                    case (int)SpecialPower.ChanceSkew:
                        ChanceSkew(skew, fighter.Damage);
                        Console.WriteLine("Шанс на уклонение.");
                        break;
                    case (int)SpecialPower.ChanceDoubleDamage:
                        ChanceDoubleDamage(resultDamage, fighter.Damage);
                        Console.WriteLine("Шанс на двойной урон.");
                        break;
                    case (int)SpecialPower.FireBall:
                        FireBall("Огненный шар", "Огненный шар", fighter.Damage);
                        Console.WriteLine("Огненный шар.");
                        break;
                }
            }
        }
    }
}

enum SpecialPower
{
    DoubleDamage = 1,
    ChanceSkew,
    ChanceDoubleDamage,
    FireBall,
}
