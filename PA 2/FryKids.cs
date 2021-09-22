using System;
namespace PA_2
{
    public class FryKids : Character
    {
        public FryKids()
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
            
            if (enemy.Name == "Ronald McDonald")
            {
                damage = Convert.ToDouble((enemy.ThrowPower - DefensivePower) * (1.2));
                System.Console.WriteLine(damage);
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