using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoveIT_1.Utils
{
    public class Calculations
    {
        public static int GetNumberOfCars(int livingArea, int extraStorageArea)
        {
            if (livingArea < 0)
            {
                throw new ArgumentOutOfRangeException("livingArea");
            }
            if (extraStorageArea < 0)
            {
                throw new ArgumentOutOfRangeException("extraStorageArea");
            }
            livingArea += extraStorageArea*2;
            int numOfCars = 1;
            numOfCars += Convert.ToInt32(livingArea/50);
            return numOfCars;
        }

        public static decimal GetDistancePrice(int distanceInKm)
        {
            if (distanceInKm < 50)
            {
                return distanceInKm * 10 + 1000;
            }
            if (distanceInKm > 50 && distanceInKm < 100)
            {
                return distanceInKm * 8 + 5000;
            }
            return distanceInKm * 7 + 10000;
        }

        public static decimal GetPrice(int livingArea, int extraStorageArea, int distanceInKm)
        {
            return GetNumberOfCars(livingArea, extraStorageArea) * GetDistancePrice(distanceInKm);
        }

    }
}