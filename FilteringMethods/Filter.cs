using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilteringMethods
{
    public abstract class Filter
    {
        protected Queue<double> buffer = new Queue<double>();
        private int length;

        internal Filter(int length)
        {
            this.length = length;
        }

        public void Insert(double mittaus)
        {
            buffer.Enqueue(mittaus);
            if (buffer.Count > length)
            {
                buffer.Dequeue();
            }
        }

        public abstract double Calculate();
    }
}
