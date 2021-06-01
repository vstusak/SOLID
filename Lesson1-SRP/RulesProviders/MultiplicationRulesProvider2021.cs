﻿using Lesson1_SRP.Entities;
using System.Collections.Generic;

namespace Lesson1_SRP.RulesProviders
{
    public class MultiplicationRulesProvider2021 : IMultiplicationRulesProvider
    {
        public double ApplyRulesForMultiplication(IEnumerable<Salary> salaries, double multiplication)
        {
            return multiplication;
        }
    }
}
