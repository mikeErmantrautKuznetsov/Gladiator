namespace GladiatorFights
{
    public class SkillTree
    {
        private readonly ListCharacters _listCharacters = new ListCharacters();

        public void Character(int needCharacter)
        {
            if (_listCharacters.TryGetFighter(needCharacter, out DataFighter fighter))
            {
                Console.WriteLine($"\nИмя:{fighter.Name}. " +
                    $" Национальность:{fighter.National}. " +
                    $" Броня:{fighter.Armor}. " +
                    $" Здоровье:{fighter.Health}. " +
                    $" Урон:{fighter.Damage}. ");
                Console.WriteLine();

                AddForce(needCharacter);
            }
        }

        public void AddForce(int needForce)
        {
            ISpecialPower specialPower = new PowerCharacters();

            switch (needForce)
            {
                case (int)SpecialPower.DoubleDamage:
                    specialPower.DamagePower(new DoubleDamage());
                    break;
                case (int)SpecialPower.ChanceSkew:
                    specialPower.DamagePower(new ChanceSkew());
                    break;
                case (int)SpecialPower.ChanceDoubleDamage:
                    specialPower.DamagePower(new ChanceDoubleDamage());
                    break;
                case (int)SpecialPower.FireBall:
                    specialPower.DamagePower(new FireBall());
                    break;
            }
        }
    }
}

public enum SpecialPower
{
    DoubleDamage = 1,
    ChanceSkew,
    ChanceDoubleDamage,
    FireBall
}
