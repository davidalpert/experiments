using System;
using System.Collections.Generic;
using System.Drawing;

namespace Blather.Core.Helpers
{
    public static class RandomHelper
    {
        static System.Random r;

        static RandomHelper()
        {
            r = new System.Random(DateTime.Now.Millisecond);
        }

        public static IEnumerable<int> Numbers()
        {
            while (true)
            {
                yield return r.Next();
            }
        }

        public static IEnumerable<int> Numbers(int maxValue)
        {
            while (true)
            {
                yield return r.Next(maxValue);
            }
        }

        public static IEnumerable<int> Numbers(int minValue, int maxValue)
        {
            while (true)
            {
                yield return r.Next(minValue, maxValue);
            }
        }
    }
}
