﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MedvedevKA.Sprint3.Task1.V8.Lib
{
    public class DataService : ISprint3Task1V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            while (startValue <= stopValue)
            {
                sumSeries = sumSeries + Math.Pow((1 / Math.Cos(startValue) * Math.Pow(value, startValue)), startValue);
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
