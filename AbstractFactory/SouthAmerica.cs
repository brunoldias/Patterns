using AbstractFactory.Build;
using AbstractFactory.Countries;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SouthAmerica
    {
        private Explore _exploreSouthAmerica;
        private Explored _explored;

        public SouthAmerica(MissionExplore  missionExplore)
        {
            _exploreSouthAmerica = missionExplore.ExploreSouthAmerica();
            _explored = missionExplore.Explored();
        }

        public void DiedSouthAmerica()
        {
            _exploreSouthAmerica.BeingColonizer(_explored);
        }
    }
}
