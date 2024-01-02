using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class BMICalculator
    {
        private string name = "No name";
        private double height = 0; // cm, inch
        private double weight = 0; // kg, lbs
        private UnitTypes unit;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double value)
        {
            if (value >= 0)
                height = value;
        }

        public double GetWeight()
        {
            return weight;
        }

        public void SetWeight(double value)
        {
            if (value >= 0)
                weight = value;
        }

        public UnitTypes GetUnit()
        {
            return unit;
        }

        public void SetUnit(UnitTypes newUnit)
        {
            unit = newUnit;
        }
        public string BmiWeightCategory()
        {
            double bmi = CalculateBMI();
            string textOut = string.Empty;

            if (bmi < 18.5)
                textOut = "Underweight";
            else if (bmi <= 24.9)
                textOut = "Normal weight";
            else if (bmi <= 29.9)
                textOut = "Overweight (Pre-Obesity)";
            else if (bmi <= 34.9)
                textOut = "Overweight (Obesity Class I)";
            else if (bmi <= 39.9)
                textOut = "Overweight (Obesity Class II)";
            else
                textOut = "Overweight (Obesity Class III)";

            return textOut;
        }

        public double CalculateBMI()
        {
            double bmi = 0.0;

            if (unit == UnitTypes.Metric)
            {
                bmi = weight / (height * height);
            }
            else if (unit == UnitTypes.American)
            {
                bmi = 703.0 * weight / (height * height);
            }

            return bmi;
        }
    }
}