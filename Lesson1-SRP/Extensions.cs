using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson1_SRP
{
    public static class Extensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> colection)
        {
            return colection == null || colection.Count() == 0;
        }

        public static bool IsCountHigherThanThreashold<T>(this IEnumerable<T> colection, int threashold)
        {
            return colection.Count() > threashold;
        }
    }
}
