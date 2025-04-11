namespace Assets.Scripts.Enemies
{
    internal class Shinsengumi: Enemies
    {
        private int extraDamage = 10;
        internal override int BasicAtack(int Damage)
        {

            return hp = (hp - Damage)-extraDamage;
        }
        internal override int DamageDone(int Damage)
        {
            return hp = (hp - Damage) - extraDamage;
        }

    }

}
