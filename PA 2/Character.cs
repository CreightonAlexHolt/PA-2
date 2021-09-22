namespace PA_2
{
    public class Character
    {
        public string Name{get; set;}
        public int Health{get; set;}
        public int ThrowPower{get; set;}
        public int DefensivePower{get; set;}
        public string Action{get; set;}
        public IThrow myThrow{get; set;}
        public void SetThrowBehavior(IThrow myThrow)
        {
            this.myThrow = myThrow;
        }
        public virtual void SetBonusPower(Character enemy)
        {

        }
        public virtual void SetBonusPower2(Character enemy)
        {
            
        }
    }
}