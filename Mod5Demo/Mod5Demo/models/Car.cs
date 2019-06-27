using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Demo.models
{
    [Serializable]
    class Car
    {
        protected string vin = "";

        public string Make { get; set; }
        public string Model
        {
            get; set;
        }
    }


    class RaceCar : Car
    {
        public RaceCar()
        {
            this.vin = "123";
        }

        public string Sponsor { get; set; }
    }

    class Formula1Car:RaceCar
    {
        public string TireType { get; set; }
    }

    class Minivan : Car
    {
        public Int32 NumberOfHockeyBags
        {
            get;set;
        }
    }

    class MonsterTruck : Car
    {
        public string DriverName { get; set; }
    }
}
