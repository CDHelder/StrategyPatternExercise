﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Strategy
{
    public class WalkingStrategy : ITravelStrategy
    {
        public double Calculate(double kmDistance)
        {
            return (kmDistance / 5) * 60;
        }
    }
}
