using Squares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Squares.Infrastructure
{
    /// <summary>
    /// Method for calculating square using reflection API
    /// </summary>
    public static class FigureCalculator
    {
        public static double GetSquare(string name, List<Double> parameters)
        {
            try
            {
                var type = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(t => t.BaseType == typeof(Figure) && t.IsClass && !t.IsAbstract)
                    .FirstOrDefault(x => x.Name == name);
                if (type != null)
                {
                    Figure? figure = (Figure?)Activator.CreateInstance(type);
                    if (figure != null)
                    {
                        var baseFigure = figure.GetBase(parameters);
                        return baseFigure.CalculateArea();
                    }         
                }
                return -1;
            }
            catch
            {
                return -1;
            }
        } 
    }
}
