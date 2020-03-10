using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int totalTemp = 0;

            foreach (int temp in _temperatures)
            {
                totalTemp += temp;
            }
            return totalTemp/_temperatures.Count; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
            int tempsAbove = 0;

            foreach (int temp in _temperatures)
            {
                if (temp > threshold)
                {
                    tempsAbove++;
                }
            }
            return tempsAbove; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold
            int tempsBelow = 0;

            foreach (int temp in _temperatures)
            {
                if (temp < threshold)
                {
                    tempsBelow++;
                }
            }
            return tempsBelow; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            int tempsAt = 0;

            foreach (int temp in _temperatures)
            {
                if (temp == threshold)
                {
                    tempsAt++;
                }
            }
            return tempsAt; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}
