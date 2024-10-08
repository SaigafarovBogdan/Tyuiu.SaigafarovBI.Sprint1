﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SaigafarovBI.Sprint1.Task7.V22.Lib
{
    public class DataService : ISprint1Task7V22
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Pow((1.0 - Math.Tan(x)), 1.0 / Math.Tan(x)) + Math.Cos(x - y),3);
        }
    }
}
