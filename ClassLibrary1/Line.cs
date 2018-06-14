using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxFigures
{
    public class Line : Element
    {
        public string Name { get; set; }
        public Dot DotA { get; set; }
        public Dot DotB { get; set; }

        public Line()
        {
            Name = $"Line {this.GetHashCode()}";
            DotA = new Dot();
            DotB = new Dot();
        }

        public Line(Dot dotA, Dot dotB)
        {
            Name = $"Line {this.GetHashCode()}";
            this.DotA = dotA;
            this.DotB = dotB;
        }

        public double Length()
        {
            double result = 0;

            if (DotA.X != DotB.X && DotA.Y != DotB.Y)
                result = Math.Sqrt(Math.Pow((DotB.X - DotA.X), 2.0) + Math.Pow((DotB.Y - DotA.Y), 2.0));

            return result;
        }
    }
}
