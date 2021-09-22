using System;
namespace PA_2
{
    public class StolenBurger : IThrow
    {
        public string Damage{get; set;}
        public string Attack{get; set;}
        public int SetThrow()
        {
            Random r = new Random();
            int x = r.Next(1,100);

            return x;
        }
        public string ThrowType()
        {
            Attack = "Throws Stolen Hamburgers";
            return Attack;
        }
    }
}