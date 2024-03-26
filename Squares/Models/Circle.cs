using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares.Models
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle() { }
        public override IFigure? GetBase(List<Double> parameters)
        {
            if (parameters.Count == GetFigureInfo().ParamsNumber)
            {
                return new Circle(parameters[0]);
            }
            else
            {
                return null;
            }

        }
        public override double CalculateArea()
        {
                return Math.PI * radius * radius;
        }
        public override FigureInfo GetFigureInfo()
        {
            return new FigureInfo
            {
                ParamsNumber = 1,
                Title = "Circle"
            };
        }
    }
}
