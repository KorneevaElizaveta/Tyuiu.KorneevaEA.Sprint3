using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KorneevaEA.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MultSeries = 1;

            do
            {    
                MultSeries *= Math.Pow(5 / startValue, 3);
                startValue++;

            } while (startValue <= stopValue);

            return Math.Round(MultSeries, 3);
        }
    }
}
