
using AbstractFactory.Build;
using AbstractFactory.Countries;
using System;

namespace AbstractFactory
{
    public abstract class MissionExplore
    {        
        public abstract Explore ExploreSouthAmerica();
        public abstract Explored Explored();
    }
}
