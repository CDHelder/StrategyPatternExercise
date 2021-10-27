using Domain.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TravelTimeCalculator
    {
        private readonly ITravelStrategy travelStrategy;

        public TravelTimeCalculator(ITravelStrategy travelStrategy)
        {
            this.travelStrategy = travelStrategy;
        }

        public double CalculateTravelTime(double kmDistance)
        {
            return travelStrategy.Calculate(kmDistance);
        }
    }
}
