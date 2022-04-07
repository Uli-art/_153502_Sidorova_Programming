using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{

    public sealed class Hotel
    {
        string nameOfHotel { get; set; } = "";
        int countOfPopulatedPlaces { get; set; } = 0;
        int countOfPlaces { get; set; } = 0;
        Rate HotelsRate;
        private Hotel(string nameOfHotel, int countOfPopulatedPlaces, int countOfPlaces, double HotelsRate)
        {
            this.nameOfHotel = nameOfHotel;
            this.countOfPopulatedPlaces = countOfPopulatedPlaces;
            this.countOfPlaces = countOfPlaces;

            this.HotelsRate = new Rate(HotelsRate);
        }

        public double Calculate()
        {
            return countOfPopulatedPlaces * HotelsRate.getRate();
        }
        private static Hotel _instance = null;
        public static Hotel GetInstance(string nameOfHotel, int countOfPopulatedPlaces, int countOfPlaces, double HotelsRate)
        {
            if (_instance == null)
            {
                _instance = new Hotel(nameOfHotel, countOfPopulatedPlaces, countOfPlaces, HotelsRate);
            }
            return _instance;
        }

        public void IncreaseRate(double plusRate)
        {
            HotelsRate.RateUp(plusRate);
        }
        public void DecreaseRate(double minusRate)
        {
            HotelsRate.RateDown(minusRate);
        }
        public double getRate()
        {
            return HotelsRate.getRate();
        }

    }
}
