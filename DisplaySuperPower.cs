namespace GladiatorFights
{
    public class DisplaySuperPower
    {
        public void Display(int force)
        {
            switch (force)
            {
                case (int)Power.DoubleDamage:
                    Console.WriteLine("Двойной урон");
                    break;
                case (int)Power.ChanceSkew:
                    Console.WriteLine("Шанс на уклонение");
                    break;
                case (int)Power.ChanceDoubleDamage:
                    Console.WriteLine("Шанс на двойной урон");
                    break;
                case (int)Power.FireBall:
                    Console.WriteLine("Огненный шар");
                    break;
            }
        }
    }
}

public enum Power
{
    DoubleDamage = 1,
    ChanceSkew,
    ChanceDoubleDamage,
    FireBall
}
