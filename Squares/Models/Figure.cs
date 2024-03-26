using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares.Models
{
    public abstract class Figure : IFigure
    {
        public virtual double CalculateArea()
        {
            return -1;
        }

        public virtual IFigure? GetBase(List<double> parameters)
        {
            return null;
        }
        public virtual FigureInfo GetFigureInfo()
        {
            return new FigureInfo();
        }
    }
}
