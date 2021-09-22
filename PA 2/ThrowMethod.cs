using System;
namespace PA_2
{
    public class ThrowMethod : IThrow
    {
        public int SetThrow()
        {
            Random r = new Random();
            int x = r.Next(1,100);

            return x;
        }
    }
}