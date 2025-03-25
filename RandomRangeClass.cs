namespace GladiatorFights
{
    public class RandomRangeClass
    {
        private readonly Random _random = new Random();

        public int GenerateRandom(int minRandom, int maxRandom)
        {
            int result = _random.Next(minRandom, maxRandom);
            return result;
        }
    }
}
