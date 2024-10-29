using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp5Uppgift
{
    internal class Car
    {
        public string RegNum { get; private set; }
        public int NumOfWheels { get; private set; }

        public Car(string regNum,int numOfWheels)
        {
            RegNum= regNum.ToLower();
            NumOfWheels = numOfWheels;
        }

    }
}
