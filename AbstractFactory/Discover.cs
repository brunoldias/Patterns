using AbstractFactory.Build;
using AbstractFactory.Countries;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Discover : MissionExplore
    {
        public override Explore ExploreSouthAmerica()
        {
            return new Portugal();
        }

        public override Explored Explored()
        {
            return new Brazil();
        }
    }
}
