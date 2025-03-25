namespace GladiatorFights
{
    public class DoubleDamage : ISpecialForce
    {
        public int Damage()
        {
            RandomRangeClass randomRangeClass = new RandomRangeClass();
            int skewChance = randomRangeClass.GenerateRandom(30, 80);
            if (skewChance >= 40 && skewChance >= 70)
            {
                Console.WriteLine("Двойной урон.");
            }
            else
            {
                Console.WriteLine("Промахнулся. А жаль.");
            }

            return skewChance;
        }
    }
}
