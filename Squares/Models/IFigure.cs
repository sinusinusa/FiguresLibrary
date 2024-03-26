using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares.Models
{
    public interface IFigure
    {
        /// <summary>
        /// Return square of this figure
        /// </summary>
        /// <returns> Square of figure </returns>
        public double CalculateArea();
        public IFigure? GetBase(List<Double> parameters);
    }
    public class FigureInfo
    {
        public int ParamsNumber { get; set; }
        public string Title { get; set; }
    }
}
