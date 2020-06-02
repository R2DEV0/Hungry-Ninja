using System;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet NinjaFood = new Buffet();
            Ninja Kevin = new Ninja();

            while(Kevin.IsFull == false){
                Kevin.Eat(NinjaFood.Serve());
            }
        }
    }
}
