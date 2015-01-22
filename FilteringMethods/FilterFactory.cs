using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringMethods
{
    public enum FilterTypes
    {
        Median, Average
    }

    public class FilterFactory
    {
        public static Filter CreateFilter(FilterTypes type, int length)
        {
            Filter f = null;
            switch (type)
            {
                case FilterTypes.Average:
                    f = new AverageFilter(length);
                    break;
                case FilterTypes.Median:
                    f = new MedianFilter(length);
                    break;
            }
            return f;
        }
    }
}
