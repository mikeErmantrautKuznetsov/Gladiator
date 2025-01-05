namespace GladiatorFights
{
    public class SpecialForce : RandomRangeClass, ISpecialForce
    {
        public void DoubleDamage(int Damage, int ResultDamage)
        {
            ResultDamage = Damage * 2;
        }

        public void ChanceSkew(bool ResultSkew, int Damage)
        {
            ResultSkew = true;
            Damage = 0;
        }

        public void ChanceDoubleDamage(bool ResultDamage, int Damage)
        {
            ResultDamage = true;
            Damage = Damage * 2;
        }

        public void FireBall(string TypeAttack, string TypeWeapon, int Damage)
        {
            TypeAttack = TypeWeapon;
            Damage = Damage * Damage;
        }
    }
}
