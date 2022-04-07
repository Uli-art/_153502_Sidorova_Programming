using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{
    public class Rate
    {
        private double rate { get; set; } = 0;
        public Rate(double HotelsRate) {
            this.rate = HotelsRate;
        }/*
        public Rate()
        {
            this.rate = 0;
        }
        double rate;*/
        public double getRate() { 
            return rate;
        }
        public void RateUp(double plusRate) {
            rate += plusRate;
        }
        public void RateDown(double minusRate) {
            if (minusRate > rate)
                return;
            rate -= minusRate;
        }
    }
}
