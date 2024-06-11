﻿using System;
using System.Collections.Generic;
using System.Linq;
using Lesson1_SRP.Entities;

namespace Lesson1_SRP.Calculations
{
    public class BonusProvider : IBonusProvider
    {
        public List<int> GetBonuses(List<Salary> salaries)//, DateTime personBirth)
        {
            var bonuses = new List<int>();

            //if (personBirth.Year >= 1950)
           // {
           //     bonuses.Add(5);
           // }
           // else
           // { 
                if (salaries.Select(salary => salary.Value).Any(value => value > 47000))
                {
                    bonuses.Add(2000);
                }
            //}
            return bonuses;
        }
    }

    public class BonusProvider1950AndYounger : IBonusProvider
    {
        public List<int> GetBonuses(List<Salary> salaries)
        {
            var bonuses = new List<int>();
            bonuses.Add(5);
            return bonuses;
        }
    }

    public interface IBonusProvider
    {
        List<int> GetBonuses(List<Salary> salaries);
    }
}