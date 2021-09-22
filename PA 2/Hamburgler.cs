using System;
namespace PA_2
{
    public class Hamburgler : Character
    {
        public Hamburgler()
        {
            myThrow = new ThrowMethod();
        }
        public void SetThrow(IThrow myThrow)
        {
            this.myThrow = myThrow;
        }
        public void SetDefense(IThrow myThrow)
        {
            this.myThrow = myThrow;
        }
        public override void SetBonusPower(Character enemy)
        {
            double damage;
            if (enemy.Name == "The Fry Kids")
            {
                damage = Convert.ToDouble((enemy.ThrowPower - DefensivePower) * (1.2));
                Health = Health - (int)damage;
            }
            else
            {
                damage = (enemy.ThrowPower - DefensivePower) * (1);
                Health = Health - (int)damage;
            }
        }
    }
}