namespace GladiatorFights
{
    public class PowerCharacters : ISpecialPower
    {
        public void DamagePower(ISpecialForce doubleDamage)
        {
            Console.WriteLine(doubleDamage.Damage());
        }
    }
}
