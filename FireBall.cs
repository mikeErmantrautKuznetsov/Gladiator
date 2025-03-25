namespace GladiatorFights
{
    public class FireBall : ISpecialForce
    {
        public int Damage()
        {
            RandomRangeClass randomRangeClass = new RandomRangeClass();
            int skewChance = randomRangeClass.GenerateRandom(30, 80);
            if (skewChance >= 40 && skewChance >= 70)
            {
                Console.WriteLine("Огненный шар поразил цель.");
            }
            else
            {
                Console.WriteLine("Огненный шар промахнулся.");
            }

            return skewChance;
        }
    }
}
