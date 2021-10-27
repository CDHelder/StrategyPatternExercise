using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Strategy
{
    public class BikeStrategy : ITravelStrategy
    {
        public double Calculate(double kmDistance)
        {
            return (kmDistance / 20) * 60;
        }
    }
}
