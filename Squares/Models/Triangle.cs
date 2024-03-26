using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Squares.Models
{
    public class Triangle : Figure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public Triangle() { }
        public override IFigure? GetBase(List<Double> parameters)
        {
            if (parameters.Count == GetFigureInfo().ParamsNumber)
            {
                return new Triangle(parameters[0], parameters[1], parameters[2]);       
            }
            else
            {
                return null;
            }
        }
        public override double CalculateArea()
        {

            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    /// <summary>
    /// Check If Triangle is right
    /// </summary>
    /// <returns> True if Triangle is right </returns>
        public bool IsRightTriangle()
        {
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);
            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }

        public override FigureInfo GetFigureInfo()
        {
            return new FigureInfo
            {
                ParamsNumber = 3,
                Title = "Triangle"
            };
        }
    }
}
