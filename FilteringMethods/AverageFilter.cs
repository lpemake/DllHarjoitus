using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilteringMethods
{
    internal class AverageFilter : Filter
    {
        internal AverageFilter(int length)
            : base(length)
        {

        }

        public override double Calculate()
        {
            return base.buffer.Average();
        }
    }
}
