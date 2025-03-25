namespace GladiatorFights
{
    public class ChanceSkew : ISpecialForce
    {
        public int Damage()
        {
            RandomRangeClass randomRangeClass = new RandomRangeClass();
            int skewChance = randomRangeClass.GenerateRandom(30, 80);
            if (skewChance >= 40 && skewChance >= 70)
            {
                Console.WriteLine("Вы уклонились от атаки.");
            }
            else
            {
                Console.WriteLine("По вам нанесли урон.");
            }

            return skewChance;
        }
    }
}
