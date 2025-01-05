namespace GladiatorFights
{
    public interface ISpecialForce
    {
        public void DoubleDamage(int Damage, int ResultDamage);
        public void ChanceSkew(bool ResultSkew, int Damage);
        public void ChanceDoubleDamage(bool ResultDamage, int Damage);
        public void FireBall(string TypeAttack, string TypeWeapon, int Damage);
    }
}
