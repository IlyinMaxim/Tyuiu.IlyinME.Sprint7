using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.IlyinME.Sprint7.Project.V4.Lib
{
    public class DataService
    {
        public double AverageValue(double[] arrayNumber)
        {
            double avg = arrayNumber.Average();
            return avg;
        }
        public double MinValue(double[] arrayNumber)
        {
            double min = arrayNumber.Min();
            return min;
        }
        public double MaxValue(double[] arrayNumber)
        {
            double max = arrayNumber.Max();
            return max;
        }

    }
}
