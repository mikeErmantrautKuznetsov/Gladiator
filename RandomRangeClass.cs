namespace GladiatorFights
{
    public class RandomRangeClass
    {
        private readonly Random Random = new Random();

        public int GenerateRandom(int minRandom, int maxRandom)
        {
            int result = Random.Next(minRandom, maxRandom);
            return result;
        }
    }
}
