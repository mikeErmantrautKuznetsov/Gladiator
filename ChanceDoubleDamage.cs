namespace GladiatorFights
{
    public class ChanceDoubleDamage : ISpecialForce
    {
        public int Damage()
        {
            RandomRangeClass randomRangeClass = new RandomRangeClass();
            int skewChance = randomRangeClass.GenerateRandom(30, 80);
            if (skewChance >= 40 && skewChance >= 70)
            {
                Console.WriteLine("Успех на получение возможности на двойной урон.");
            }
            else
            {
                Console.WriteLine("Не повезло нанести двойной урон.");
            }
            return skewChance;
        }
    }
}
