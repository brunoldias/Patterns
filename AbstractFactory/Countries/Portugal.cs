
using AbstractFactory.Build;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Countries
{
    public class Portugal : Explore
    {
       
        public override void BeingColonizer(Explored colonized)
        {
            Console.WriteLine(this.GetType().Name + " " +
                "Colonizer " + colonized.GetType().Name);
        }
    }
}
