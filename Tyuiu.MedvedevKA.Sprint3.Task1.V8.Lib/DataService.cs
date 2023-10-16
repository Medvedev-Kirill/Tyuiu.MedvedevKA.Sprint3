using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MedvedevKA.Sprint3.Task1.V8.Lib
{
    public class DataService : ISprint3Task1V8
    {
        public double GetMultiplySeries(double value)
        {
            double x = 0.25;
            double sum = 0;
            int k = 1;
            while (k <= 15)
            {
                sum += Math.Pow(1 / Math.Cos(k) + Math.Pow(x, k), k); 
                k++;
            }
            return Math.Round(sum, 3);
        }
    }
}
